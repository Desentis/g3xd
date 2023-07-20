using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Card", menuName = "CardSO")]
public class CardSO : ScriptableObject
{

    [SerializeField] private int _id;
    public int Id { get => _id; private set { _id = value; } }

    [SerializeField] private string _name;
    public string Name { get => _name; private set { _name = value; }}

    [SerializeField] private string _desription;
    public string Desription { get => _desription; private set { _desription = value; }}

    [SerializeField] private int _cost;
    public int Cost { get => _cost; private set { _cost = value; }}

    [SerializeField] private int _attack;
    public int Attack { get => _attack; private set { _attack = value; }}

    [SerializeField] private Sprite _picture;
    public Sprite Picture { get => _picture; private set { _picture = value; } }

    [SerializeField] private List<Interactions.Type> _ableInteractions;
    public List<Interactions.Type> AbleInteractions { get => _ableInteractions; private set { _ableInteractions = value; } }
   

    /*public Card()
    {

    }

    public Card(int id, string cardName, int cost, int power, string cardDesription)
    {
        this.id = id;
        this.cardName = cardName;
        this.cost = cost;
        this.power = power;
        this.cardDesription = cardDesription;
    }*/
}
