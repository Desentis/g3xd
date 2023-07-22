using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class ItemSlot : MonoBehaviour, IDropHandler
{
    [SerializeField] private Interactions.Type _interaction;
    [SerializeField] private Transform _cardPrefab;

    public void OnDrop(PointerEventData eventData)
    {
        Debug.Log("OnDrop");
        if (eventData.pointerDrag != null)
        {
            
            if (HasCard())
            {
                eventData.pointerDrag.GetComponent<DragDrop>().ResetPosition();
                Debug.LogError("���� �����");
                return;
            }
            Card droppedCard = eventData.pointerDrag.GetComponent<Card>();
            if (!AbleToInteract(droppedCard.CardSO.AbleInteractions))
            {
                eventData.pointerDrag.GetComponent<DragDrop>().ResetPosition();
                Debug.LogError("���� �� ��������");
                return;                
            }
            eventData.pointerDrag.GetComponent<RectTransform>().SetParent(transform);
            eventData.pointerDrag.GetComponent<RectTransform>().localPosition = Vector2.zero;
        }
    }

    private bool HasCard()
    {       
        return transform.GetComponentInChildren<Card>() != null;
    }


    private bool AbleToInteract(List<Interactions.Type> cardInteraction)
    {                
        return cardInteraction.IndexOf(_interaction) != -1;
    }    

    public void CardHandler()
    {
        if (HasCard())
        {
            Card currentCard = transform.GetComponentInChildren<Card>();
            CardSO outputCardSO;
            Debug.Log("TryGetRecipe");
            if (RecipeDatabase.TryGetRecipe(_interaction, currentCard, out outputCardSO))
            {
                Debug.Log("Ouptut Card: " + outputCardSO.name);
                Destroy(currentCard.gameObject);
                Transform prefab = Instantiate(_cardPrefab, Vector3.zero, Quaternion.Euler(0, 0, 0), transform);
            }

        }
        else 
        {
            Debug.Log("No card in slot " + _interaction.ToString());
        }
    }
}
