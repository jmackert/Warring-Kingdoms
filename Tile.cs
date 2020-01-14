using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Tile
{
    [SerializeField] private GameObject tileGameObject;
    [SerializeField] private string tileType;
    [SerializeField] private float xCord;
    [SerializeField] private float yCord;
    [SerializeField] private float zCord;

    public Tile(string _tileType, GameObject obj, float _xCord, float _yCord, float _zCord)
    {
        this.tileType = _tileType;
        this.tileGameObject = obj;
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

    public string getTileType()
    {
        return tileType;
    }

    public GameObject getTileGameObject()
    {
        return tileGameObject;
    }
}


