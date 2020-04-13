using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateGoldOre
{
    public static void SetGoldOre(string[,] resourceGrid, string[,] tileGrid, int rows, int columns)
    {
        string grassTile = "G";
        string goldOreTile = "GO";
        int maxGoldOre = 10;
        int goldOreCount = 0;

        for(int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {   
                int rand = Random.Range(0,100);
                if(rand == 1 && tileGrid[i,j] == grassTile && goldOreCount < maxGoldOre)
                {
                    resourceGrid[i,j] = goldOreTile;
                    goldOreCount++;
                }
            }
        }
    }
}
