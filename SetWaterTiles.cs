using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class SetWaterTiles
{
        public static void SetWater (string[,] Grid,int rows, int columns)
     {
        int maxWaterTiles = rows * columns / 2;
        int numWaterTile = 0;
        int randX1 = Random.Range(0, rows);
        int randY1 = Random.Range(0, columns);
        int randX2 = Random.Range(0, rows);
        int randY2 = Random.Range(0, columns);

        Grid[randX1,randY1] = "W";
        numWaterTile++;
        Grid[randX2,randY2] = "W";
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
                            
                            if(Grid[i,j] == "W")
                            {
                                int rand1 = Random.Range (0, 2);
                                if(rand1 == 0 && numWaterTile != maxWaterTiles)
                                {
                                    Grid[i+1,j] = "W";
                                    numWaterTile++;   
                                }
                                int rand2 = Random.Range (0,2);
                                if(rand2 == 0 && numWaterTile != maxWaterTiles)
                                {
                                    Grid[i-1,j] = "W";
                                    numWaterTile++;
                                }
                                int rand3 = Random.Range (0,2);
                                if(rand3 == 0 && numWaterTile != maxWaterTiles)
                                {
                                    Grid[i,j+1] = "W";
                                    numWaterTile++;
                                }
                                int rand4 = Random.Range (0,2);
                                if(rand4 == 0 && numWaterTile != maxWaterTiles)
                                {
                                    Grid[i,j-1] = "W";;
                                    numWaterTile++;
                                }
                            }
                        }
                    }
                }
            }
        }
        Debug.Log("maxWaterTiles: " + maxWaterTiles);
        Debug.Log("numWaterTiles: " + numWaterTile);
    }
}