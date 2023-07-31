using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public static class CardDatabase
{
    private const string PATH_CARDS_SO = "CardsSO";
    private static List<CardSO> cardList = Resources.LoadAll<CardSO>(PATH_CARDS_SO).ToList();
    
    public static List<CardSO> GetAllCards()
    {
        return new List<CardSO>(cardList);
    }

    public static CardSO GetCard(int index)
    {
        return cardList[index]; 
    }
}