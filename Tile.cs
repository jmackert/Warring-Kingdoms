using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Tile
{
    [SerializeField] private float xCord;
    [SerializeField] private float yCord;
    [SerializeField] private float zCord;
    [SerializeField] private string tileType = "Grass Tile";
    [SerializeField] private GameObject tileGameObject;

    public Tile(float _xCord, float _yCord, float _zCord)
    {
        this.xCord = _xCord;
        this.yCord = _yCord;
        this.zCord = _zCord;
    }

    public float GetXCord()
    {
        return xCord;
    }

    public float GetYCord()
    {
        return yCord;
    }

    public float GetZCord()
    {
        return zCord;
    }

    public GameObject GetTileGameObject()
    {
        return tileGameObject;
    }

    public void SetTileGameObject(GameObject _tileGameObject)
    {
        tileGameObject = _tileGameObject;
    }

    public void SetTileType(string _tileType)
    {
        tileType = _tileType;
       // Debug.Log("Tile Type: " + tileType);
    }

    public string GetTileType()
    {
        return tileType;
    }
    public void GetTileInfo()
    {
        Debug.Log(GetTileGameObject());
        Debug.Log(GetXCord());
        Debug.Log(GetYCord());
        Debug.Log(GetZCord());
    }
}


