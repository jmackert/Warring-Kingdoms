using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateTownSpawn
{

    public static void SetPlayerSpawns(string[,] buildingGrid, string[,] resourceGrid, string[,] tileGrid,int rows, int columns)
    {
        string grassTile = "G";
        string townCenter = "TC";
        
        int randX1 = Random.Range(1, rows - 1);
        int randY1 = Random.Range(1, columns / 4);

        int randX2 = Random.Range(1, rows - 1);
        int randY2 = Random.Range(columns / 2, columns -1);

        while(buildingGrid [randX1,randY1] == null)
        {
                if (tileGrid[randX1,randY1] == grassTile && tileGrid[randX1+1,randY1] == grassTile && tileGrid[randX1-1,randY1] == grassTile && tileGrid[randX1,randY1+1] == grassTile && tileGrid[randX1,randY1-1] == grassTile && resourceGrid[randX1,randY1] == null && resourceGrid[randX1+1,randY1] == null && resourceGrid[randX1-1,randY1] == null && resourceGrid[randX1,randY1+1] == null && resourceGrid[randX1,randY1-1] == null) 
                {
                    buildingGrid[randX1,randY1] = townCenter;
                }
                else
                {
                    randX1 = Random.Range(1, rows - 1);
                    randY1 = Random.Range(1, columns / 4);
                }
        }

        while(buildingGrid [randX2,randY2] == null)
        {
                if (tileGrid[randX2,randY2] == grassTile && tileGrid[randX2+1,randY2] == grassTile && tileGrid[randX2-1,randY2] == grassTile && tileGrid[randX2,randY2+1] == grassTile && tileGrid[randX2,randY2-1] == grassTile && resourceGrid[randX2,randY2] == null && resourceGrid[randX2+1,randY2] == null && resourceGrid[randX2-1,randY2] == null && resourceGrid[randX2,randY2+1] == null && resourceGrid[randX2,randY2-1] == null) 
                {
                    buildingGrid[randX2,randY2] = townCenter;
                }
                else
                {
                    randX2 = Random.Range(1, rows -1);
                    randY2 = Random.Range(columns / 2, columns - 1);
                }
        }
    }
}
