using UnityEngine;
using System;
using UnityRandom = UnityEngine.Random; // we can use alias to rename the namespace
// to define what function will use the namespace

[Serializable]
public class Namespaces : MonoBehaviour
{
    // 
    private void Start()
    {
        // Random random = new Random(); // we have a problem here, because we have two Random classes in the same namespace
        UnityRandom.Range(0, 1); // we can use the namespace to specify which Random class we want to use
    }


    public class Player
    {

    }

    /*  public class Player // Error: The type 'Player' already exists in the namespace 'Namespaces'
        {
        } */


}
