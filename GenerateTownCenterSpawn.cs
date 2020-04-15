using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateTownCenterSpawn
{

    public static void SetTownCenterSpawns(string[,] tileGrid,int rows, int columns)
    {
        string grassTile = "G";
        string townCenter = "TC";

            int randX1 = Random.Range(1, rows - 1);
            int randY1 = Random.Range(1, columns / 4);

            int randX2 = Random.Range(1, rows - 1);
            int randY2 = Random.Range(columns / 2, columns -1);


                    if (tileGrid[randX1,randY1] == grassTile && tileGrid[randX1+1,randY1] == grassTile && tileGrid[randX1-1,randY1] == grassTile && tileGrid[randX1,randY1+1] == grassTile && tileGrid[randX1,randY1-1] == grassTile) 
                    {
                        tileGrid[randX1,randY1] = townCenter;
                    }


                    if (tileGrid[randX2,randY2] == grassTile && tileGrid[randX2+1,randY2] == grassTile && tileGrid[randX2-1,randY2] == grassTile && tileGrid[randX2,randY2+1] == grassTile && tileGrid[randX2,randY2-1] == grassTile) 
                    {
                        tileGrid[randX2,randY2] = townCenter;
                    }

    }
}
