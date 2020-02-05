using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateTownSpawn
{

    public static void SetPlayerSpawns(string[,] buildingGrid, string[,] resourceGrid, string[,] tileGrid,int rows, int columns)
    {
        string grassTile = "G";
        string townCenter = "TC";
        
        int randX1 = Random.Range(0, rows);
        int randY1 = Random.Range(0, columns / 4);

        int randX2 = Random.Range(0, rows);
        int randY2 = Random.Range(columns / 2, columns);

        while(buildingGrid [randX1,randY1] == null)
        {
                if (tileGrid[randX1,randY1] == grassTile && resourceGrid[randX1,randY1] == null) 
                {
                    buildingGrid[randX1,randY1] = townCenter;
                }
                else
                {
                    randX1 = Random.Range(0, rows);
                    randY1 = Random.Range(0, columns / 4);
                }
        }

        while(buildingGrid [randX2,randY2] == null)
        {
                if (tileGrid[randX2,randY2] == grassTile && resourceGrid[randX2,randY2] == null) 
                {
                    buildingGrid[randX2,randY2] = townCenter;
                }
                else
                {
                    randX2 = Random.Range(0, rows);
                    randY2 = Random.Range(columns / 2, columns);
                }
        }
    }
}
