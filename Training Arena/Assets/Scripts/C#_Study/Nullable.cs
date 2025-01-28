using System;
using UnityEngine;

public class Nullable : MonoBehaviour
{
    // Make any type support null, even value types

    // we cant assign null to value types, but c# has a solution for this
    int? i = null; // int? is a shorthand for Nullable<int>
    Nullable<int> j = null; // this is the same as the above line, but we need to use the system namespace

    private void Start()
    {
        Setup(); // we can call the method without passing any value beacuse we have set the default value to null instead of 0, can be good for optional parameters
        Debug.Log(i+j);
    }

    private void Setup(int? i = null) // this make more sense than setting the default value to 0
    {
        Debug.Log(i);

    }
}
