﻿using UnityEngine;

public static class RandomExtensions
{
    public static bool RandomBool()
    {
        return Random.Range(0, 2) == 1;
    }
}