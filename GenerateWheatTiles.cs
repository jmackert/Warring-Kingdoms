using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateWheatTiles
{
    public static void SetWheat(string[,] tileGrid, int rows, int columns)
    {
        string wheatTile = "WH";

        for(int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {   
                int rand = Random.Range(0,75);
                if(rand == 1 && tileGrid[i,j] == null)
                {
                    tileGrid[i,j] = wheatTile;
                }
            }
        }
    }
}
