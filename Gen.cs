using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gen : MonoBehaviour {
    public string[, ] Grid;
    public Tile[] tiles = new Tile[rows * columns];
    private static int rows = 36;
    private static int columns = 36;
    private int tilesIndex = 0;
    private int maxWaterTiles = rows * columns / 2;
    private int numWaterTile = 0;

    private void Start () 
    {
        GenerateGridArray ();
        Debug.Log("maxNumWaterTiles: " + maxWaterTiles);
        Debug.Log("numWaterTiles: " + numWaterTile);
    }


    private void GenerateGridArray () 
    {
        Grid = new string[rows, columns];

        for (int i = 0; i < rows; i++)
         {
            for (int j = 0; j < columns; j++)
             {
                int rand = Random.Range (0, 3);
                if (rand == 0) 
                {
                    Grid[i, j] = "G";
                }
                if (rand == 1) 
                {
                    Grid[i, j] = "M";
                }
                if (rand == 2)
                 {
                    Grid[i, j] = "G";
                }
                if (rand == 3 && numWaterTile != maxWaterTiles) 
                {
                    Grid[i, j] = "W";
                    numWaterTile++;
                }
            }
        }

        SetWater2();
        //SetWater();
        //SetGrass();
        GenerateTiles();
        //LogGrid();
    }

    private void SetWater ()
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

    private void  SetWater2()
    {
        int randX1 = Random.Range(0, rows);
        int randY1 = Random.Range(0, columns);
        Grid[randX1,randY1] = "W";
        numWaterTile++;
        int randX2 = Random.Range(0, rows);
        int randY2 = Random.Range(0, columns);
        Grid[randX2,randY2] = "W";
        numWaterTile++;

        for(int i = 0; i < 5; i++)
        {
            SetWater();
        }
    }



    private void SetGrass()
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

    private void LogGrid()
    {
        for(int i = 0; i < rows; i++)
        {
            for(int j = 0; j < columns; j++)
            {
                Debug.Log(Grid[i,j]);
            }

            Debug.Log("Break!!!!");
        }
    }

    private void GenerateTiles () {
        for (int row = 0; row < rows; row++) {
            for (int column = 0; column < columns; column++) {

                Vector3 position = new Vector3 (row, 0, column);

                if (Grid[row,column] == "G") {
                    GameObject grassTile = Instantiate (Resources.Load ("Grass Tile"), position, Quaternion.identity) as GameObject;
                    tiles[tilesIndex] = new Tile ("Grass", grassTile, row, 0, column);
                }
                if (Grid[row,column] == "M") {
                    GameObject mountainTile = Instantiate (Resources.Load ("Mountain Tile"), position, Quaternion.identity) as GameObject;
                    tiles[tilesIndex] = new Tile ("Mountain", mountainTile, row, 0, column);
                }
                if (Grid[row,column] == "S") {
                    GameObject sandTile = Instantiate (Resources.Load ("Sand Tile"), position, Quaternion.identity) as GameObject;
                    tiles[tilesIndex] = new Tile ("Sand", sandTile, row, 0, column);
                }
                if (Grid[row,column] == "W") {
                    GameObject waterTile = Instantiate (Resources.Load ("Water Tile"), position, Quaternion.identity) as GameObject;
                    tiles[tilesIndex] = new Tile ("Water", waterTile, row, 0, column);
                }
                tilesIndex++;
            }
        }
    }
}