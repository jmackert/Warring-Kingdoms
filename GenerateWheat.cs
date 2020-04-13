using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateWheat
{
    public static void SetWheat(string[,] resourceGrid, string[,] tileGrid, int rows, int columns)
    {
        string grassTile = "G";
        string wheatTile = "WH";

        for(int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {   
                int rand = Random.Range(0,75);
                if(rand == 1 && tileGrid[i,j] == grassTile)
                {
                    resourceGrid[i,j] = wheatTile;
                }
            }
        }
    }
}
