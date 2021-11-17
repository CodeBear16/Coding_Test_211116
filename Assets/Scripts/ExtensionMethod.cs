using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class ExtensionMethod
{
    public static bool Between(this int value, int a, int b)
    {
        if (value >= a && value < b)
            return true;
        else
            return false;
    }

    public static bool Between(this float value, float a, float b)
    {
        if (value >= a && value <= b)
            return true;
        else
            return false;
    }
}
