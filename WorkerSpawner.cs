using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WorkerSpawner
{
    public static void SpawnStartingWorkers(string[,] tileGrid, string[,] unitGrid, int rows, int columns)
    {
        string grassTile = "G";
        string worker = "WK";

        int randX1 = Random.Range(1, rows - 1);
        int randY1 = Random.Range(1, columns / 4);

        if (tileGrid[randX1,randY1] == grassTile)
        {
            unitGrid[randX1,randY1] = worker;
        }

    }
}
