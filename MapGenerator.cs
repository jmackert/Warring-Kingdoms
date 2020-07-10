using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapGenerator : MonoBehaviour {
    //public string[,] tileGrid;
    //public string[,] unitGrid;
    private static int rows = 36;
    private static int columns = 36;
    public Tile[,] tiles = new Tile[rows,columns];
    //public Unit[] units = new Unit[rows * columns];
    //private int unitIndex = 0;
    //private int tilesIndex = 0;
    
    
    private void Start () 
    {
        GenerateTileArray ();
        //GenerateUnitArray();
    }

    private void GenerateTileArray () 
    {
        tiles = new Tile[rows, columns];

        for (int row = 0; row < rows; row++)
        {
            for (int column = 0; column < columns; column++)
            {
                tiles[row, column] = new Tile (row, 0, column);
            }
        }
        SetTileTypes();
        GenerateTilePrefabs();
        
        for (int row = 0; row < rows; row++)
        {
            for (int column = 0; column < columns; column++)
            {               
                //Debug.Log(tiles[row,column].GetTileType());
            }
        }
    }

    /*private void GenerateUnitArray()
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
    }*/
    private void GenerateTilePrefabs () {
        
        string grassBlock = "Grass Tile";
        string waterBlock = "Water Tile";
        string mountainBlock = "Mountain Tile";
        string forestBlock = "Forest Tile";
        string wheatBlock = "Wheat Tile";
        string goldOreBlock = "Gold Ore Tile";
    
        for (int row = 0; row < rows; row++) {
            for (int column = 0; column < columns; column++) {

                Vector3 position = new Vector3 (row, 0, column);

                if (tiles[row,column].GetTileType().Equals(grassBlock)) {
                    GameObject grassTile = Instantiate (Resources.Load ("Grass_Tile_01"), position, Quaternion.identity) as GameObject;
                    tiles[row,column].SetTileGameObject(grassTile);
                }
                if (tiles[row,column].GetTileType().Equals(forestBlock)){
                    GameObject forestTile = Instantiate (Resources.Load ("Forest_Tile_01"), position, Quaternion.identity) as GameObject;
                    tiles[row,column].SetTileGameObject(forestTile);
                }
                if (tiles[row,column].GetTileType().Equals(wheatBlock)){
                    GameObject wheatTile = Instantiate (Resources.Load ("Wheat_Tile_01"), position, Quaternion.identity) as GameObject;
                    tiles[row,column].SetTileGameObject(wheatTile);
                }
                    if (tiles[row,column].GetTileType().Equals(goldOreBlock)){
                    GameObject goldOreTile = Instantiate (Resources.Load ("Gold_Ore_Tile_01"), position, Quaternion.identity) as GameObject;
                    tiles[row,column].SetTileGameObject(goldOreTile);
                }
                if (tiles[row,column].GetTileType().Equals(mountainBlock)) {
                    GameObject mountainTile = Instantiate (Resources.Load ("Mountain_Tile_01"), position, Quaternion.identity) as GameObject;
                    tiles[row,column].SetTileGameObject(mountainTile);
                }
                if (tiles[row,column].GetTileType().Equals(waterBlock)) {
                    GameObject waterTile = Instantiate (Resources.Load ("Water_tile_01"), position, Quaternion.identity) as GameObject;
                    tiles[row,column].SetTileGameObject(waterTile);
                }
            }
        }
    }

    /*private void GenerateStartingUnitsPrefabs()
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
    }*/

    public void UpdateTile(Vector3 tileGameObjectPosition)
    {
        int xPos = (int) tileGameObjectPosition.x;
        int zPos = (int) tileGameObjectPosition.z;

        Tile selectedTile = tiles[xPos,zPos];
        selectedTile.GetTileInfo();
    }

    private void SetMountains()

    {
        int maxNumMountainTiles = rows * columns / 12;
        int numMountainTiles = 0;
        string mountainTile = "Mountain Tile";

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                int rand = Random.Range (0, 15);
                if (rand == 1 && numMountainTiles != maxNumMountainTiles)
                {
                    tiles[i, j].SetTileType(mountainTile);
                    Debug.Log("added mountain @ " + tiles[i,j]);
                    numMountainTiles++;
                }
            }
        }
    }
    private void SetWater ()
        {
            int maxWaterTiles = rows * columns;
            int numWaterTile = 0;
            int randX1 = Random.Range(0, rows);
            int randY1 = Random.Range(0, columns);
            int randX2 = Random.Range(0, rows);
            int randY2 = Random.Range(0, columns);
            string waterTile = "Water Tile";

            tiles[randX1,randY1].SetTileType(waterTile);
            numWaterTile++;
            tiles[randX2,randY2].SetTileType(waterTile);
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
                                if(tiles[i,j].GetTileType().Equals(waterTile))
                                {
                                    
                                    int rand1 = Random.Range (0, 2);
                                    if(rand1 == 0 && numWaterTile != maxWaterTiles)
                                    {
                                        tiles[i+1,j].SetTileType(waterTile);
                                        numWaterTile++;
                                    }
                                    int rand2 = Random.Range (0,2);
                                    if(rand2 == 0 && numWaterTile != maxWaterTiles)
                                    {
                                        tiles[i-1,j].SetTileType(waterTile);
                                        numWaterTile++;
                                    }
                                    int rand3 = Random.Range (0,2);
                                    if(rand3 == 0 && numWaterTile != maxWaterTiles)
                                    {
                                        tiles[i,j+1].SetTileType(waterTile);
                                        numWaterTile++;
                                    }
                                    int rand4 = Random.Range (0,2);
                                    if(rand4 == 0 && numWaterTile != maxWaterTiles)
                                    {
                                        tiles[i,j-1].SetTileType(waterTile);
                                        numWaterTile++;
                                    }
                                }
                            }
                        //checks for one off non-water tiles and replaces them with water tiles
                        if(i != 0 && j != 0 && i != rows - 1  && j != columns - 1) 
                        {
                            if(tiles[i,j].GetTileType() != waterTile && tiles[i-1,j].GetTileType().Equals(waterTile) && tiles[i+1,j].GetTileType().Equals(waterTile) && tiles[i,j - 1].GetTileType().Equals(waterTile) && tiles[i,j +1].GetTileType().Equals(waterTile))
                            {
                                tiles[i,j].SetTileType(waterTile);
                            }
                        }
                    }
                }
            }
            }
            Debug.Log("max: " + maxWaterTiles);
            Debug.Log("total: " + numWaterTile);
        }
    private void SetGrass()
        {
            string grassTile = "Grass Tile";
            string waterTile = "Water Tile";

            for(int i = 0; i < rows; i++)
            {
                for(int j = 0; j < columns; j++)
                {
                    if(tiles[i,j] == null) // checks for missing tiles
                    {
                    tiles[i,j].SetTileType(grassTile);
                    }

                    if(i == 0 && j == 0) // bottom left corner
                    {
                        if(tiles[i,j].GetTileType().Equals(waterTile) && tiles[i+1,j].GetTileType() != waterTile&& tiles[i,j+1].GetTileType() != waterTile)
                        {
                            tiles[i,j].SetTileType(grassTile);
                        }
                    }
                    if(i == rows -1 && j == 0) // bottom right corner
                    {
                        if(tiles[i,j].GetTileType().Equals(waterTile) && tiles[i-1,j].GetTileType() != waterTile && tiles[i,j+1].GetTileType() != waterTile)
                        {
                            tiles[i,j].SetTileType(grassTile);
                        }
                    }
                    if(i == 0 && j == columns -1) // top left corner
                    {
                        if(tiles[i,j].GetTileType().Equals(waterTile) && tiles[i+1,j].GetTileType() != waterTile && tiles[i,j-1].GetTileType() != waterTile)
                        {
                            tiles[i,j].SetTileType(grassTile);
                        }
                    }
                    if(i == rows -1 && j == columns -1) // top right corner
                    {
                        if(tiles[i,j].GetTileType().Equals(waterTile) && tiles[i-1,j].GetTileType() != waterTile)
                        {
                            tiles[i,j].SetTileType(grassTile);
                        }
                    }

                    if(i == 0 && j != columns -1 && j != 0) //left side of grid
                    {
                        if(tiles[i,j].GetTileType().Equals(waterTile) && tiles[i+1,j].GetTileType() != waterTile && tiles[i,j+1].GetTileType() != waterTile)
                        {
                            tiles[i,j].SetTileType(grassTile);
                        }
                    }
                    if(i == rows -1 && j != columns -1 && j != 0) //right side of grid
                    {
                        if(tiles[i,j].GetTileType().Equals(waterTile) && tiles[i-1,j].GetTileType() != waterTile && tiles[i,j+1].GetTileType() != waterTile)
                        {
                            tiles[i,j].SetTileType(grassTile);
                        }
                    }
                    if(j == 0 && i != rows -1 && i != 0) //bottom side of gird
                    {
                        if(tiles[i,j].GetTileType().Equals(waterTile) && tiles[i,j+1].GetTileType() != waterTile && tiles[i+1,j].GetTileType() != waterTile && tiles[i-1,j].GetTileType() != waterTile)
                        {
                            tiles[i,j].SetTileType(grassTile);
                        }
                    }
                    if(j == columns -1 && i != rows -1 && i != 0) //top side of gird
                    {
                        if(tiles[i,j].GetTileType().Equals(waterTile) && tiles[i+1,j].GetTileType() != waterTile && tiles[i-1,j].GetTileType() != waterTile)
                        {
                            tiles[i,j].SetTileType(grassTile);
                        }
                    }
                    if(i != 0 && j != 0 && i != rows - 1  && j != columns - 1) //inside of grid
                    {
                        if(tiles[i,j].GetTileType().Equals(waterTile) && tiles[i-1,j].GetTileType() != waterTile && tiles[i+1,j].GetTileType() != waterTile && tiles[i,j - 1].GetTileType() != waterTile && tiles[i,j +1].GetTileType() != waterTile)
                        {
                            tiles[i,j].SetTileType(grassTile);
                        }
                    }
                }
            }
        }
    private void SetWheat()
        {
            string wheatTile = "Wheat Tile";

            for(int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {   
                    int rand = Random.Range(0,75);
                    if(rand == 1 && tiles[i,j] == null)
                    {
                        tiles[i,j].SetTileType(wheatTile);
                    }
                }
            }
        }
    private void SetForests()
    {
        string forestTile = "Forest Tile";

        for(int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {   
                int rand = Random.Range(0,5);
                if(rand == 1 && tiles[i,j] == null)
                {
                    tiles[i,j].SetTileType(forestTile);
                }
            }
        }
    }
    private void SetGoldOre()
    {
        string goldOreTile = "Gold Ore Tile";
        int maxGoldOre = 10;
        int goldOreCount = 0;

        for(int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {   
                int rand = Random.Range(0,100);
                if(rand == 1 && tiles[i,j] == null && goldOreCount < maxGoldOre)
                {
                    tiles[i,j].SetTileType(goldOreTile);
                    goldOreCount++;
                }
            }
        }
    }
    private void SetTileTypes()
    {
        SetMountains();
        SetWater();
        SetForests();
        SetWheat();
        SetGoldOre();
        SetGrass();
    }



}
