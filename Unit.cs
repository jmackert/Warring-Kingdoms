using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Unit
{
    [SerializeField] private GameObject unitType;
    [SerializeField] private float xCord;
    [SerializeField] private float yCord;
    [SerializeField] private float zCord;
    [SerializeField] private float maxHealth;
    [SerializeField] private float currentHealth;
    [SerializeField] private float attack;
    [SerializeField] private float defense;
    [SerializeField] private float movementSpeed;
    [SerializeField] private float sight;



    public Unit(GameObject _unitType, float _xCord, float _yCord, float _zCord, float _maxHealth, float _currentHealth, float _attack, float _defense, float _movementSpeed, float _sight)
    {
        this.unitType = _unitType;
        this.xCord = _xCord;
        this.yCord = _yCord;
        this.zCord = _zCord;
        this.maxHealth = _maxHealth;
        this.currentHealth = _currentHealth;
        this.attack = _attack;
        this.defense = _defense;
        this.movementSpeed = _movementSpeed;
        this.sight = _sight;
    }

    public GameObject getTileType()
    {
        return unitType;
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

    public float getCurrentHealth()
    {
        return currentHealth;
    }

    public float getMaxHealth()
    {
        return maxHealth;
    }

    public float getAttack()
    {
        return attack;
    }

    public float getDefense()
    {
        return defense;
    }

    public float getMovementSpeed()
    {
        return movementSpeed;
    }

    public float getSight()
    {
        return sight;
    }

}


