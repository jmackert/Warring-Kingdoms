using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateGrassTiles
{
    public static void SetGrass(string[,] tileGrid,int rows, int columns)
    {
        string grassTile = "G";
        string waterTile = "W";

        for(int i = 0; i < rows; i++)
        {
            for(int j = 0; j < columns; j++)
            {
                if(tileGrid[i,j] == null) // checks for missing tiles
                {
                   tileGrid[i,j] = grassTile;
                }

                if(i == 0 && j == 0) // bottom left corner
                {
                    if(tileGrid[i,j] == waterTile && tileGrid [i+1,j] != waterTile && tileGrid[i,j+1] != waterTile)
                    {
                       tileGrid[i,j] = grassTile;
                    }
                }
                if(i == rows -1 && j == 0) // bottom right corner
                {
                    if(tileGrid[i,j] == waterTile && tileGrid [i-1,j] != waterTile && tileGrid[i,j+1] != waterTile)
                    {
                       tileGrid[i,j] = grassTile;
                    }
                }
                if(i == 0 && j == columns -1) // top left corner
                {
                    if(tileGrid[i,j] == waterTile && tileGrid [i+1,j] != waterTile && tileGrid[i,j-1] != waterTile)
                    {
                       tileGrid[i,j] = grassTile;
                    }
                }
                if(i == rows -1 && j == columns -1) // top right corner
                {
                    if(tileGrid[i,j] == waterTile && tileGrid [i-1,j] != waterTile && tileGrid[i,j-1] != waterTile)
                    {
                       tileGrid[i,j] = grassTile;
                    }
                }

                if(i == 0 && j != columns -1 && j != 0) //left side oftileGrid
                {
                    if(tileGrid[i,j] == waterTile && tileGrid[i+1,j] != waterTile && tileGrid[i,j+1] != waterTile && tileGrid[i,j-1] != waterTile)
                    {
                       tileGrid[i,j] = grassTile;
                    }
                }
                if(i == rows -1 && j != columns -1 && j != 0) //right side oftileGrid
                {
                    if(tileGrid[i,j] == waterTile && tileGrid[i-1,j] != waterTile && tileGrid[i,j+1] != waterTile && tileGrid[i,j-1] != waterTile)
                    {
                       tileGrid[i,j] = grassTile;
                    }
                }
                if(j == 0 && i != rows -1 && i != 0) //bottom side oftileGrid
                {
                    if(tileGrid[i,j] == waterTile && tileGrid[i,j+1] != waterTile && tileGrid[i+1,j] != waterTile && tileGrid[i-1,j] != waterTile)
                    {
                       tileGrid[i,j] = grassTile;
                    }
                }
                if(j == columns -1 && i != rows -1 && i != 0) //top side oftileGrid
                {
                    if(tileGrid[i,j] == waterTile && tileGrid[i,j-1] != waterTile && tileGrid[i+1,j] != waterTile && tileGrid[i-1,j] != waterTile)
                    {
                       tileGrid[i,j] = grassTile;
                    }
                }
                if(i != 0 && j != 0 && i != rows - 1  && j != columns - 1) //inside oftileGrid
                {
                    if(tileGrid[i,j] == waterTile && tileGrid[i-1,j] != waterTile && tileGrid[i+1,j] != waterTile && tileGrid[i,j - 1] != waterTile && tileGrid[i,j +1] != waterTile)
                    {
                       tileGrid[i,j] = grassTile;
                    }
                }
            }
        }
    }

}