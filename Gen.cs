using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gen : MonoBehaviour {
    public string[, ] Grid;
    private static int rows = 36;
    private static int columns = 36;
    public Tile[] tiles = new Tile[rows * columns];
    private int tilesIndex = 0;


    private void Start () 
    {
        GenerateGridArray ();
        SetWaterTiles.SetWater(Grid,rows,columns);
        SetGrassTiles.SetGrass(Grid,rows,columns);
        GenerateTiles();
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
                else if (rand == 1) 
                {
                    Grid[i, j] = "M";
                }
                else if (rand == 2)
                 {
                    Grid[i, j] = "G";
                }
            }
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