using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateForestTiles
{
    public static void SetForests(string[,] tileGrid, int rows, int columns)
    {
        string forestTile = "F";

        for(int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {   
                int rand = Random.Range(0,5);
                if(rand == 1 && tileGrid[i,j] == null)
                {
                    tileGrid[i,j] = forestTile;
                }
            }
        }
    }
}
