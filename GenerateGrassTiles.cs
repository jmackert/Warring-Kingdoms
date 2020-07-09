using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateGrassTiles
{
    public static void SetGrass(Tile[,] tiles,int rows, int columns)
    {
        string grassTile = "Grass Tile";
        //string waterTile = "Water Tile";

        for(int i = 0; i < rows; i++)
        {
            for(int j = 0; j < columns; j++)
            {
                if(tiles[i,j] == null) // checks for missing tiles
                {
                   tiles[i,j].Equals(grassTile);
                }

                /*if(i == 0 && j == 0) // bottom left corner
                {
                    if(tiles[i,j] == waterTile && tiles [i+1,j] != waterTile && tiles[i,j+1] != waterTile)
                    {
                        tiles[i,j].setTileType(grassTile);
                    }
                }
                if(i == rows -1 && j == 0) // bottom right corner
                {
                    if(tiles[i,j] == waterTile && tiles [i-1,j] != waterTile && tiles[i,j+1] != waterTile)
                    {
                        tiles[i,j].setTileType(grassTile);
                    }
                }
                if(i == 0 && j == columns -1) // top left corner
                {
                    if(tiles[i,j] == waterTile && tiles [i+1,j] != waterTile && tiles[i,j-1] != waterTile)
                    {
                        tiles[i,j].setTileType(grassTile);
                    }
                }
                if(i == rows -1 && j == columns -1) // top right corner
                {
                    if(tiles[i,j] == waterTile && tiles [i-1,j] != waterTile && tiles[i,j-1] != waterTile)
                    {
                       tiles[i,j].setTileType(grassTile);
                    }
                }

                if(i == 0 && j != columns -1 && j != 0) //left side of grid
                {
                    if(tiles[i,j] == waterTile && tiles[i+1,j] != waterTile && tiles[i,j+1] != waterTile && tiles[i,j-1] != waterTile)
                    {
                       tiles[i,j].setTileType(grassTile);
                    }
                }
                if(i == rows -1 && j != columns -1 && j != 0) //right side of grid
                {
                    if(tiles[i,j] == waterTile && tiles[i-1,j] != waterTile && tiles[i,j+1] != waterTile && tiles[i,j-1] != waterTile)
                    {
                       tiles[i,j].setTileType(grassTile);
                    }
                }
                if(j == 0 && i != rows -1 && i != 0) //bottom side of gird
                {
                    if(tiles[i,j] == waterTile && tiles[i,j+1] != waterTile && tiles[i+1,j] != waterTile && tiles[i-1,j] != waterTile)
                    {
                       tiles[i,j].setTileType(grassTile);
                    }
                }
                if(j == columns -1 && i != rows -1 && i != 0) //top side of gird
                {
                    if(tiles[i,j] == waterTile && tiles[i,j-1] != waterTile && tiles[i+1,j] != waterTile && tiles[i-1,j] != waterTile)
                    {
                       tiles[i,j].setTileType(grassTile);
                    }
                }
                if(i != 0 && j != 0 && i != rows - 1  && j != columns - 1) //inside of grid
                {
                    if(tiles[i,j] == waterTile && tiles[i-1,j] != waterTile && tiles[i+1,j] != waterTile && tiles[i,j - 1] != waterTile && tiles[i,j +1] != waterTile)
                    {
                       tiles[i,j].setTileType(grassTile);
                    }
                }*/
            }
        }
    }

}