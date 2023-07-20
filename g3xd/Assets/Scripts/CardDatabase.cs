using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public static class CardDatabase
{
    const string PATH_SO_CARDS = "SOCards";
    private static List<CardSO> cardList = Resources.LoadAll<CardSO>(PATH_SO_CARDS).ToList();
    
    public static List<CardSO> GetAllCards()
    {
        return new List<CardSO>(cardList);
    }

    public static CardSO GetCard(int index)
    {
        return cardList[index]; 
    }
}