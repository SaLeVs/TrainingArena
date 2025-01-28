using NUnit.Framework;
using System.Collections.Generic;
using UnityEngine;

public class DataBoxing : MonoBehaviour
{
    // Make any type into an object and back

    private void Start()
    {
        int i = 56;
        object obj = i; // boxing
        i = (int)obj;   // unboxing

        List<object> objectList = new List<object> // with object list can store anything
        {
            12,
            false,
            "CodeMonkey"
        };
    }
}
