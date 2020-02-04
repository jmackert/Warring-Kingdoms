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
        int randY1 = Random.Range(0, columns);

        int randX2 = Random.Range(0, rows);
        int randY2 = Random.Range(0, columns);

                if (tileGrid[randX1,randY1] == grassTile && resourceGrid[randX1,randY1] == null) 
                {
                    buildingGrid[randX1,randY1] = townCenter;
                }
                if(tileGrid[randX2,randY2] == grassTile && resourceGrid[randX2,randY2] == null)
                {
                    buildingGrid[randX2,randY2] = townCenter;
                }
    }
}
