using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Card", menuName = "RecepieSO")]
public class RecipeSO : ScriptableObject
{
    [SerializeField] private CardSO _inputCardSO;
    [SerializeField] private CardSO _outputCardSO;
    [SerializeField] private List<Interactions.Type> _ableInteractions;

    public CardSO InputCardSO => _inputCardSO;
    public CardSO OutputCardSO => _outputCardSO;
    public List<Interactions.Type> AbleInteractions => _ableInteractions;
}
