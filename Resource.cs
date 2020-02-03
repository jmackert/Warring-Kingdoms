using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Resource
{
    [SerializeField] private GameObject resourceGameObject;
    [SerializeField] private string resourceType;
    [SerializeField] private float xCord;
    [SerializeField] private float yCord;
    [SerializeField] private float zCord;

    public Resource(string _resourceType, GameObject obj, float _xCord, float _yCord, float _zCord)
    {
        this.resourceType = _resourceType;
        this.resourceGameObject = obj;
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

    public string getResourceType()
    {
        return resourceType;
    }

    public GameObject geResourceGameObject()
    {
        return resourceGameObject;
    }
}


