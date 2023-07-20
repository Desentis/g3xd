using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Card : MonoBehaviour
{
    [SerializeField] private CardSO _cardSO;

    public CardSO CardSO { get { return _cardSO; } private set { _cardSO = value; } }
}
