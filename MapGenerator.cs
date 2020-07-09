using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapGenerator : MonoBehaviour {
    public string[,] tileGrid;
    public string[,] unitGrid;
    private static int rows = 36;
    private static int columns = 36;
    public Tile[,] tiles = new Tile[rows,columns];
    public Unit[] units = new Unit[rows * columns];
    private int unitIndex = 0;
    private int tilesIndex = 0;
    
    
    private void Start () 
    {
        GenerateTileArray ();
        //GenerateUnitArray();
    }

    private void GenerateTileArray () 
    {
        tiles = new Tile[rows, columns];

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
            }
        }
        //GenerateMountainTiles.SetMountains(tileGrid,rows,columns);
        //GenerateWaterTiles.SetWater(tileGrid,rows,columns);
        //GenerateForestTiles.SetForests(tileGrid,rows,columns);
        //GenerateWheatTiles.SetWheat(tileGrid,rows,columns);
        //GenerateGoldOreTiles.SetGoldOre(tileGrid,rows,columns);
        GenerateGrassTiles.SetGrass(tiles,rows,columns);
        GenerateTilePrefabs(); 
    }

    private void GenerateUnitArray()
    {
        unitGrid = new string[rows, columns];

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
            }
        }
        WorkerSpawner.SpawnStartingWorkers(tileGrid,unitGrid,rows,columns);
        GenerateStartingUnitsPrefabs();
    }
    private void GenerateTilePrefabs () {
        
        string grassBlock = "Grass Tile";
        /*string waterBlock = "W";
        string mountainBlock = "M";
        string forestBlock = "F";
        string wheatBlock = "WH";
        string goldOreBlock = "GO";*/
    
        for (int row = 0; row < rows; row++) {
            for (int column = 0; column < columns; column++) {

                Vector3 position = new Vector3 (row, 0, column);

                if (tiles[row,column].Equals(grassBlock)) {
                    GameObject grassTile = Instantiate (Resources.Load ("Grass_Tile_01"), position, Quaternion.identity) as GameObject;
                    tiles[row, column] = new Tile (grassTile, row, 0, column);
                }
                /*if (tileGrid[row,column] == forestBlock){
                    GameObject forestTile = Instantiate (Resources.Load ("Forest_Tile_01"), position, Quaternion.identity) as GameObject;
                    tiles[row, column] = new Tile ( forestTile, row, 0, column);
                }
                if (tileGrid[row,column] == wheatBlock){
                    GameObject wheatTile = Instantiate (Resources.Load ("Wheat_Tile_01"), position, Quaternion.identity) as GameObject;
                    tiles[row, column] = new Tile (wheatTile, row, 0, column);
                }
                    if (tileGrid[row,column] == goldOreBlock){
                    GameObject goldOreTile = Instantiate (Resources.Load ("Gold_Ore_Tile_01"), position, Quaternion.identity) as GameObject;
                    tiles[row, column] = new Tile (goldOreTile, row, 0, column);
                }
                if (tileGrid[row,column] == mountainBlock) {
                    GameObject mountainTile = Instantiate (Resources.Load ("Mountain_Tile_01"), position, Quaternion.identity) as GameObject;
                    tiles[row, column] = new Tile (mountainTile, row, 0, column);
                }
                if (tileGrid[row,column] == waterBlock) {
                    GameObject waterTile = Instantiate (Resources.Load ("Water_tile_01"), position, Quaternion.identity) as GameObject;
                    tiles[row, column] = new Tile (waterTile, row, 0, column);
                }*/
            }
        }
    }

    private void GenerateStartingUnitsPrefabs()
    {
        string workerUnit = "WK";

        for (int row = 0; row < rows; row++) {
            for (int column = 0; column < columns; column++) {

                Vector3 position = new Vector3 (row, 0, column);

                if (unitGrid[row,column] == workerUnit){
                    GameObject worker = Instantiate (Resources.Load ("Hammer"), position, Quaternion.identity) as GameObject;
                    units[unitIndex] = new Unit (worker, rows, 0, column, 10, 10, 1, 1, 5, 5);
                }
                unitIndex++;
            }
        }



    }

    public void UpdateTile(Vector3 tileGameObjectPosition)
    {
        int xPos = (int) tileGameObjectPosition.x;
        int zPos = (int) tileGameObjectPosition.z;

        Tile selectedTile = tiles[xPos,zPos];
        selectedTile.GetTileInfo();
    }
}
