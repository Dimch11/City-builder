using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CityMap
{
    public CityStructure this[int x, int y]
    {
        get => TryGetTile();
    }

    CityStructure[,] tiles;

    private CityStructure TryGetTile()
    {

    }
}
