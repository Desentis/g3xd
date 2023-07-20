using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class CardVisual : MonoBehaviour
{
    private CardSO card;

    public Text nameText;
    public Text desriptionText;
    public Text manaText;
    public Text attackText;
    public Image spriteImage;

    public void Start()
    {
        card = transform.GetComponent<Card>().CardSO;
        nameText.text = card.Name;
        desriptionText.text = card.Desription;
        manaText.text = card.Cost.ToString();
        attackText.text = card.Attack.ToString();
        spriteImage.sprite = card.Picture;
    }

    
}


