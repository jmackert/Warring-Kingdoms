using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapGenerator : MonoBehaviour {
    public string[, ] tileGrid;
    public string[, ] resourceGrid;
    private static int rows = 36;
    private static int columns = 36;
    public Tile[] tiles = new Tile[rows * columns];
    public Resource[] resources = new Resource[rows * columns];
    private int tilesIndex = 0;
    private int resourcesIndex = 0;
    
    private void Start () 
    {
        GenerateTileGridArray ();
        GenerateResourceArray();
    }

    private void GenerateTileGridArray () 
    {
        tileGrid = new string[rows, columns];

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
            }
        }
        GenerateMountainTiles.SetMountains(tileGrid,rows,columns);
        GenerateWaterTiles.SetWater(tileGrid,rows,columns);
        GenerateGrassTiles.SetGrass(tileGrid,rows,columns);
        GenerateTilePrefabs();
    }

    private void GenerateResourceArray()
    {
        resourceGrid = new string[rows, columns];

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
            }
        }
        GenerateTrees.SetTrees(resourceGrid,tileGrid,rows,columns);
        GenerateResourcePrefabs();
    }

    private void GenerateResourcePrefabs()
    {
        string forestBlock = "F";

        for (int row = 0; row < rows; row++)
        {
            for (int column = 0; column < columns; column++)
            {
                Vector3 position = new Vector3 (row, 0, column);

                if (resourceGrid[row,column] == forestBlock)
                {
                    GameObject forestTile = Instantiate (Resources.Load ("Pine Tree 01"), position, Quaternion.identity) as GameObject;
                    resources[resourcesIndex] = new Resource ("Forest", forestTile, row, 0, column);
                }
                resourcesIndex++;
            }
        }
    }

    private void GenerateTilePrefabs () {
        string grassBlock = "G";
        string waterBlock = "W";
        string mountainBlock = "M";
    
        for (int row = 0; row < rows; row++) {
            for (int column = 0; column < columns; column++) {

                Vector3 position = new Vector3 (row, 0, column);

                if (tileGrid[row,column] == grassBlock) {
                    GameObject grassTile = Instantiate (Resources.Load ("Grass Block"), position, Quaternion.identity) as GameObject;
                    tiles[tilesIndex] = new Tile ("Grass", grassTile, row, 0, column);
                }
                if (tileGrid[row,column] == mountainBlock) {
                    GameObject mountainTile = Instantiate (Resources.Load ("Mountian Block 01"), position, Quaternion.identity) as GameObject;
                    tiles[tilesIndex] = new Tile ("Mountain", mountainTile, row, 0, column);
                }
                if (tileGrid[row,column] == waterBlock) {
                    GameObject waterTile = Instantiate (Resources.Load ("Water Block"), position, Quaternion.identity) as GameObject;
                    tiles[tilesIndex] = new Tile ("Water", waterTile, row, 0, column);
                }
                tilesIndex++;
            }
        }
    }
}