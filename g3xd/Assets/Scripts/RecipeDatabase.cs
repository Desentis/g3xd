using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public static class RecipeDatabase
{
    private const string PATH_RECIPES_SO = "RecipesSO";
    private static List<RecipeSO> recipeList = Resources.LoadAll<RecipeSO>(PATH_RECIPES_SO).ToList();

    public static List<RecipeSO> GetAllRecipes()
    {
        return new List<RecipeSO>(recipeList);
    }

    public static RecipeSO GetRecipe(int index)
    {
        return recipeList[index];
    }

    public static bool TryGetRecipe(Interactions.Type type, Card inputCard, out CardSO outputCardSO)
    {
        outputCardSO = null;
        foreach (var recipe in recipeList)
        {
            if (recipe.InputCardSO != inputCard.CardSO) 
                continue;

            foreach (var interaction in recipe.AbleInteractions)
            {
                if (interaction == type)
                {
                    outputCardSO = recipe.OutputCardSO;
                    return true;
                }
            }
        }        
        return false;
    }
}
