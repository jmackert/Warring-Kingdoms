using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class GenerateWaterTiles
{
        public static void SetWater (string[,] tileGrid,int rows, int columns)
     {
        int maxWaterTiles = rows * columns;
        int numWaterTile = 0;
        int randX1 = Random.Range(0, rows);
        int randY1 = Random.Range(0, columns);
        int randX2 = Random.Range(0, rows);
        int randY2 = Random.Range(0, columns);
        string waterTile = "W";

        tileGrid[randX1,randY1] = waterTile;
        numWaterTile++;
        tileGrid[randX2,randY2] = waterTile;
        numWaterTile++;

        for(int h = 0; h < 5; h++)
        {
            for (int i = 0; i < rows; i++) 
            {
                for (int j = 0; j < columns; j++) 
                {
                    if(numWaterTile != maxWaterTiles)
                    {
                        if(i != 0 && j != 0 && i != rows - 1  && j != columns - 1)
                        {
                            
                            if(tileGrid[i,j] == waterTile)
                            {
                                int rand1 = Random.Range (0, 2);
                                if(rand1 == 0 && numWaterTile != maxWaterTiles)
                                {
                                   tileGrid[i+1,j] = waterTile;
                                    numWaterTile++;   
                                }
                                int rand2 = Random.Range (0,2);
                                if(rand2 == 0 && numWaterTile != maxWaterTiles)
                                {
                                   tileGrid[i-1,j] = waterTile;
                                    numWaterTile++;
                                }
                                int rand3 = Random.Range (0,2);
                                if(rand3 == 0 && numWaterTile != maxWaterTiles)
                                {
                                   tileGrid[i,j+1] = waterTile;
                                    numWaterTile++;
                                }
                                int rand4 = Random.Range (0,2);
                                if(rand4 == 0 && numWaterTile != maxWaterTiles)
                                {
                                   tileGrid[i,j-1] = waterTile;;
                                    numWaterTile++;
                                }
                            }
                        }

                    if(i != 0 && j != 0 && i != rows - 1  && j != columns - 1) //checks for one off non-water tiles and replaces them with water tiles
                    {
                        if(tileGrid[i,j] != waterTile && tileGrid[i-1,j] == waterTile && tileGrid[i+1,j] == waterTile && tileGrid[i,j - 1] == waterTile && tileGrid[i,j +1] == waterTile)
                        {
                           tileGrid[i,j] = waterTile;
                        }
                    }
                }
            }
        }
        }
        Debug.Log("max: " + maxWaterTiles);
        Debug.Log("total: " + numWaterTile);
    }
}