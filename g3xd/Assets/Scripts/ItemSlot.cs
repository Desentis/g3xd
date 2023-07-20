using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class ItemSlot : MonoBehaviour, IDropHandler
{
    [SerializeField] private Interactions.Type _interaction;


    public void OnDrop(PointerEventData eventData)
    {
        Debug.Log("OnDrop");
        if (eventData.pointerDrag != null)
        {
            
            if (HasCard())
            {
                eventData.pointerDrag.GetComponent<DragDrop>().ResetPosition();
                Debug.LogError("Слот занят");
                return;
            }
            Card droppedCard = eventData.pointerDrag.GetComponent<Card>();
            if (!AbleToInteract(droppedCard.CardSO.AbleInteractions))
            {
                eventData.pointerDrag.GetComponent<DragDrop>().ResetPosition();
                Debug.LogError("Слот не подходит");
                return;                
            }
            eventData.pointerDrag.GetComponent<RectTransform>().SetParent(transform);
            eventData.pointerDrag.GetComponent<RectTransform>().localPosition = Vector2.zero;
        }
    }

    private bool HasCard()
    {       
        return transform.GetComponentInChildren<DragDrop>() != null;
    }


    private bool AbleToInteract(List<Interactions.Type> cardInteraction)
    {                
        return cardInteraction.IndexOf(_interaction) != -1;
    }
}
