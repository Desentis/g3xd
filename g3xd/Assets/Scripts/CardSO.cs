using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Card", menuName = "CardSO")]
public class CardSO : ScriptableObject
{
    [SerializeField] private int _id;
    [SerializeField] private string _name;
    [SerializeField] private string _desription;
    [SerializeField] private int _cost;
    [SerializeField] private int _attack;
    [SerializeField] private Sprite _picture;
    [SerializeField] private List<Interactions.Type> _ableInteractions;

    public int Id => _id;    
    public string Name => _name;    
    public string Desription => _desription;
    public int Cost => _cost;
    public int Attack => _attack;
    public Sprite Picture => _picture;
    public List<Interactions.Type> AbleInteractions => _ableInteractions;
}
