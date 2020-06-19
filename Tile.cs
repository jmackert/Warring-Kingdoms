using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Tile
{
    [SerializeField] private GameObject tileType;
    [SerializeField] private float xCord;
    [SerializeField] private float yCord;
    [SerializeField] private float zCord;

    public bool isTileSelected;

    public Tile(GameObject _tileType, float _xCord, float _yCord, float _zCord)
    {
        this.tileType = _tileType;
        this.xCord = _xCord;
        this.yCord = _yCord;
        this.zCord = _zCord;
    }

    public float getXCord()
    {
        return xCord;
    }

    public float getYCord()
    {
        return yCord;
    }

    public float getZCord()
    {
        return zCord;
    }

    public GameObject getTileType()
    {
        return tileType;
    }

    private void OnMouseDown() 
    {
            if(isTileSelected == true)
            {
                isTileSelected = false;
            }
            else
            {   
                isTileSelected = true;
                GetTileInfo();
            }
    }

    public void GetTileInfo()
    {
        Debug.Log(getTileType());
        Debug.Log(getXCord());
        Debug.Log(getYCord());
        Debug.Log(getZCord());
    }
}


