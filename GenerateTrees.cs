using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateTrees
{
    public static void SetTrees(string[,] resourceGrid, string[,] tileGrid, int rows, int columns)
    {
        string forestTile = "F";
        string grassTile = "G";

        for(int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {   
                int rand = Random.Range(0,5);
                if(rand == 1 && tileGrid[i,j] == grassTile)
                {
                    resourceGrid[i,j] = forestTile;
                }
            }
        }
    }
}
