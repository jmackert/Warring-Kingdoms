using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateMountainTiles
{
    public static void SetMountains(string[,] tileGrid,int rows, int columns)
    {
        int maxNumMountainTiles = rows * columns / 12;
        int numMountainTiles = 0;
        string mountainTile = "M";

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                int rand = Random.Range (0, 15);
                if (rand == 1 && numMountainTiles != maxNumMountainTiles) 
                {
                    tileGrid[i, j] = mountainTile;
                    numMountainTiles++;
                }
            }
        }
    }
}