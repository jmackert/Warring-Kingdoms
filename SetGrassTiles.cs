using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetGrassTiles
{
    public static void SetGrass(string[,] Grid,int rows, int columns)
    {
        for(int i = 0; i < rows; i++)
        {
            for(int j = 0; j < columns; j++)
            {
                if(Grid[i,j] == null)
                {
                    Grid[i,j] = "G";
                }

                if(i == 0 && j == 0) // bottom left corner
                {
                    if(Grid[i,j] == "W" && Grid [i+1,j] != "W" && Grid[i,j+1] != "W")
                    {
                        Grid[i,j] = "G";
                    }
                }
                if(i == rows -1 && j == 0) // bottom right corner
                {
                    if(Grid[i,j] == "W" && Grid [i-1,j] != "W" && Grid[i,j+1] != "W")
                    {
                        Grid[i,j] = "G";
                    }
                }
                if(i == 0 && j == columns -1) // top left corner
                {
                    if(Grid[i,j] == "W" && Grid [i+1,j] != "W" && Grid[i,j-1] != "W")
                    {
                        Grid[i,j] = "G";
                    }
                }
                if(i == rows -1 && j == columns -1) // top right corner
                {
                    if(Grid[i,j] == "W" && Grid [i-1,j] != "W" && Grid[i,j-1] != "W")
                    {
                        Grid[i,j] = "G";
                    }
                }

                if(i == 0 && j != columns -1 && j != 0) //left side of grid
                {
                    if(Grid[i,j] == "W" && Grid[i+1,j] != "W" && Grid[i,j+1] != "W" && Grid[i,j-1] != "W")
                    {
                        Grid[i,j] = "G";
                    }
                }
                if(i == rows -1 && j != columns -1 && j != 0) //right side of grid
                {
                    if(Grid[i,j] == "W" && Grid[i-1,j] != "W" && Grid[i,j+1] != "W" && Grid[i,j-1] != "W")
                    {
                        Grid[i,j] = "G";
                    }
                }
                if(j == 0 && i != rows -1 && i != 0) //bottom side of grid
                {
                    if(Grid[i,j] == "W" && Grid[i,j+1] != "W" && Grid[i+1,j] != "W" && Grid[i-1,j] != "W")
                    {
                        Grid[i,j] = "G";
                    }
                }
                if(j == columns -1 && i != rows -1 && i != 0) //top side of grid
                {
                    if(Grid[i,j] == "W" && Grid[i,j-1] != "W" && Grid[i+1,j] != "W" && Grid[i-1,j] != "W")
                    {
                        Grid[i,j] = "G";
                    }
                }
                if(i != 0 && j != 0 && i != rows - 1  && j != columns - 1)
                {
                    if(Grid[i,j] == "W" && Grid[i-1,j] != "W" && Grid[i+1,j] != "W" && Grid[i,j - 1] != "W" && Grid[i,j +1] != "W")
                    {
                        Grid[i,j] = "G";
                    }
                }
            }
        }
    }

}