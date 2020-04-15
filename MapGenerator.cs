using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapGenerator : MonoBehaviour {
    public string[,] tileGrid;
    private static int rows = 36;
    private static int columns = 36;
    public Tile[] tiles = new Tile[rows * columns];
    private int tilesIndex = 0;
    
    private void Start () 
    {
        GenerateTileArray ();
    }

    private void GenerateTileArray () 
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
        GenerateForestTiles.SetForests(tileGrid,rows,columns);
        GenerateWheatTiles.SetWheat(tileGrid,rows,columns);
        GenerateGoldOreTiles.SetGoldOre(tileGrid,rows,columns);
        GenerateGrassTiles.SetGrass(tileGrid,rows,columns);
        GenerateTownCenterSpawn.SetTownCenterSpawns(tileGrid,rows,columns);
        GenerateTilePrefabs();
    }

    private void GenerateTilePrefabs () {
        string grassBlock = "G";
        string waterBlock = "W";
        string mountainBlock = "M";
        string forestBlock = "F";
        string wheatBlock = "WH";
        string goldOreBlock = "GO";
        string townCenterBlock = "TC";

    
        for (int row = 0; row < rows; row++) {
            for (int column = 0; column < columns; column++) {

                Vector3 position = new Vector3 (row, 0, column);

                if (tileGrid[row,column] == forestBlock){
                    GameObject forestTile = Instantiate (Resources.Load ("Forest_Tile_01"), position, Quaternion.identity) as GameObject;
                    tiles[tilesIndex] = new Tile ( forestTile, row, 0, column);
                }
                if (tileGrid[row,column] == wheatBlock){
                    GameObject wheatTile = Instantiate (Resources.Load ("Wheat_Tile_01"), position, Quaternion.identity) as GameObject;
                    tiles[tilesIndex] = new Tile (wheatTile, row, 0, column);
                }
                    if (tileGrid[row,column] == goldOreBlock){
                    GameObject goldOreTile = Instantiate (Resources.Load ("Gold_Ore_Tile_01"), position, Quaternion.identity) as GameObject;
                    tiles[tilesIndex] = new Tile (goldOreTile, row, 0, column);
                }
                if (tileGrid[row,column] == grassBlock) {
                    GameObject grassTile = Instantiate (Resources.Load ("Grass_Tile_01"), position, Quaternion.identity) as GameObject;
                    tiles[tilesIndex] = new Tile (grassTile, row, 0, column);
                }
                if (tileGrid[row,column] == mountainBlock) {
                    GameObject mountainTile = Instantiate (Resources.Load ("Mountain_Tile_01"), position, Quaternion.identity) as GameObject;
                    tiles[tilesIndex] = new Tile (mountainTile, row, 0, column);
                }
                if (tileGrid[row,column] == waterBlock) {
                    GameObject waterTile = Instantiate (Resources.Load ("Water_tile_01"), position, Quaternion.identity) as GameObject;
                    tiles[tilesIndex] = new Tile (waterTile, row, 0, column);
                }
                if (tileGrid[row,column] == townCenterBlock) {
                GameObject townCenterTile = Instantiate (Resources.Load ("Town_Center_tile_01"), position, Quaternion.identity) as GameObject;
                tiles[tilesIndex] = new Tile (townCenterTile, row, 0, column);
                }
                tilesIndex++;
            }
        }
    }
}