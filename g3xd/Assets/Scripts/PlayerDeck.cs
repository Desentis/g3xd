using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDeck : MonoBehaviour
{    


    private void Start()
    {
        
    }
    public void Shuffle()
    {
        Debug.Log("Test");
        foreach (CardSO card in CardDatabase.GetAllCards()) 
        {
            Debug.Log(card.Name);
        }
        
    }

}
