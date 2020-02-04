using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Building
{
    [SerializeField] private GameObject buildingGameObject;
    [SerializeField] private string buildingType;
    [SerializeField] private float xCord;
    [SerializeField] private float yCord;
    [SerializeField] private float zCord;

    public Building(string _buildingType, GameObject obj, float _xCord, float _yCord, float _zCord)
    {
        this.buildingType = _buildingType;
        this.buildingGameObject = obj;
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

    public string getBuildingType()
    {
        return buildingType;
    }

    public GameObject getBuildingGameObject()
    {
        return buildingGameObject;
    }
}


