using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Card : MonoBehaviour
{
    [SerializeField] private CardSO _cardSO;
    public CardSO CardSO => _cardSO;

    public Card(CardSO cardSO)
    {
        _cardSO = cardSO;
    }
}
