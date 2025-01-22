using UnityEngine;
using System;

public class TypeOf : MonoBehaviour
{
    // Get the system. Type object of a certain type


    private void Start()
    { 
       GetComponent<Player>();
       GetComponent(typeof(Player)); // this will return the type of the class Player
       // if appear a error for you cant acess the type, we need to use th typeof
       // if the function need the type parameter, we need the typeof  
       Debug.Log(GetComponent(typeof(Player))); // this will return the type of the class Player
    }


    public class Player : MonoBehaviour
    { 
        
        
    }

}
