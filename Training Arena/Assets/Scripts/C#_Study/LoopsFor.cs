using NUnit.Framework;
using System.Collections.Generic;
using UnityEngine;

public class LoopsFor : MonoBehaviour
{
    
    void Start()
    {
        LoopFor();
    }

    
    private void LoopFor()
    {
        for (int i = 0; i < 10; i++)
        {
            Debug.Log(i);
            
        }
        Debug.Log("---------------------------------------");

        string[] enemies = { "Goblin", "Orc", "Troll" }; // we can use for to check all index of array

        for (int i = 0; i < enemies.Length; i++)
        {
            Debug.Log("Enemy: " + enemies[i]);
            
        }
        Debug.Log("---------------------------------------");

        List<string> powerUps = new List<string> { "Speed", "Shield", "Double Jump" }; // Or use for check lists

        for (int i = 0; i < powerUps.Count; i++) 
        { 
            Debug.Log("PowerUps: " + powerUps[i]);
            
        }
        Debug.Log("---------------------------------------");
    }
}
