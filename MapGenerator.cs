using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapGenerator : MonoBehaviour {
    public string[,] tileGrid;
    public string[,] resourceGrid;
    public string[,] buildingGrid;
    private static int rows = 36;
    private static int columns = 36;
    public Tile[] tiles = new Tile[rows * columns];
    public Resource[] resources = new Resource[rows * columns];
    public Building[] buildings = new Building[rows * columns];
    private int tilesIndex = 0;
    private int resourcesIndex = 0;
    private int buildingsIndex = 0;
    
    private void Start () 
    {
        GenerateTileGridArray ();
        //GenerateBuildingArray();
        getInfo();
    }
    private void getInfo()
    {
        Debug.Log(tiles[0].getTileType());
        Debug.Log(tiles[1].getTileType());
        Debug.Log(tiles[2].getTileType());
        Debug.Log(tileGrid[0,0].getTileType());
    }

    private void GenerateTileGridArray () 
    {
        tileGrid = new string[rows, columns];
        resourceGrid = new string[rows, columns];

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
            }
        }
        GenerateMountainTiles.SetMountains(tileGrid,rows,columns);
        GenerateWaterTiles.SetWater(tileGrid,rows,columns);
        GenerateGrassTiles.SetGrass(tileGrid,rows,columns);
        GenerateTrees.SetTrees(resourceGrid,tileGrid,rows,columns);
        GenerateWheat.SetWheat(resourceGrid,tileGrid,rows,columns);
        GenerateGoldOre.SetGoldOre(resourceGrid,tileGrid,rows,columns);
        GenerateTilePrefabs();
    }

    private void GenerateBuildingArray()
    {
        buildingGrid = new string[rows, columns];

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
            }
        }
        GenerateTownSpawn.SetPlayerSpawns(buildingGrid,resourceGrid,tileGrid,rows,columns);
        GenerateBuildingPrefabs();
    }

    private void GenerateTilePrefabs () {
        string grassBlock = "G";
        string waterBlock = "W";
        string mountainBlock = "M";
        string forestBlock = "F";
        string wheatBlock = "WH";
        string goldOreBlock = "GO";

    
        for (int row = 0; row < rows; row++) {
            for (int column = 0; column < columns; column++) {

                Vector3 position = new Vector3 (row, 0, column);
                Vector3 wheatPosition = new Vector3 (row, 0.8f, column);
                Vector3 goldOrePosition = new Vector3 (row, 1, column);


                if (tileGrid[row,column] == grassBlock && resourceGrid[row,column] == forestBlock){
                    GameObject grassTile = Instantiate (Resources.Load ("Grass Block"), position, Quaternion.identity) as GameObject;
                    GameObject forestTile = Instantiate (Resources.Load ("Pine Tree 01"), position, Quaternion.identity) as GameObject;
                    resources[resourcesIndex] = new Resource ("Forest", forestTile, row, 0, column);
                    tiles[tilesIndex] = new Tile ("Forest Tile", grassTile, row, 0, column);
                    resourcesIndex++;
                }
                if (tileGrid[row,column] == grassBlock && resourceGrid[row, column] == wheatBlock){
                    GameObject grassTile = Instantiate (Resources.Load ("Grass Block"), position, Quaternion.identity) as GameObject;
                    GameObject wheatTile = Instantiate (Resources.Load ("Wheat_01"), wheatPosition, Quaternion.identity) as GameObject;
                    resources[resourcesIndex] = new Resource ("Wheat", wheatTile, row, 0, column);
                    tiles[tilesIndex] = new Tile ("Wheat Tile", grassTile, row, 0, column);
                    resourcesIndex++;                   
                }
                    if (tileGrid[row,column] == grassBlock && resourceGrid[row, column] == goldOreBlock){
                    GameObject grassTile = Instantiate (Resources.Load ("Grass Block"), position, Quaternion.identity) as GameObject;
                    GameObject goldOreTile = Instantiate (Resources.Load ("Gold Ore_01"), goldOrePosition, Quaternion.identity) as GameObject;
                    resources[resourcesIndex] = new Resource ("Gold Ore", goldOreTile, row, 0, column);
                    tiles[tilesIndex] = new Tile ("Gold Ore Tile", grassTile, row, 0, column);
                    resourcesIndex++;                   
                }
                if (tileGrid[row,column] == grassBlock && resourceGrid[row,column] == null) {
                    GameObject grassTile = Instantiate (Resources.Load ("Grass Block"), position, Quaternion.identity) as GameObject;
                    tiles[tilesIndex] = new Tile ("Grass Tile", grassTile, row, 0, column);
                }
                if (tileGrid[row,column] == mountainBlock) {
                    GameObject mountainTile = Instantiate (Resources.Load ("Mountian Block 01"), position, Quaternion.identity) as GameObject;
                    tiles[tilesIndex] = new Tile ("Mountain Tile", mountainTile, row, 0, column);
                }
                if (tileGrid[row,column] == waterBlock) {
                    GameObject waterTile = Instantiate (Resources.Load ("Water Block"), position, Quaternion.identity) as GameObject;
                    tiles[tilesIndex] = new Tile ("Water Tile", waterTile, row, 0, column);
                }
                tilesIndex++;
            }
        }
    }

    private void GenerateBuildingPrefabs(){
        string townTile = "TC";
         for (int row = 0; row < rows; row++) {
            for (int column = 0; column < columns; column++) {

                Vector3 position = new Vector3 (row, 1, column);

                if (buildingGrid[row,column] == townTile) {
                    GameObject TownCenter = Instantiate (Resources.Load ("Cube"), position, Quaternion.identity) as GameObject;
                    buildings[buildingsIndex] = new Building ("Town Center", TownCenter, row, 1, column);
                }
                buildingsIndex++;
            }
        }
    }
}