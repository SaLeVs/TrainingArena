using NUnit.Framework;
using System.Collections.Generic;
using UnityEngine;

public class AllLoops : MonoBehaviour
{

    // Loops

    private void Start()
    {
        LoopsWhile();
        LoopsDoWhile();
        LoopsFor();
        LoopsForeach();
    }

    private void LoopsWhile()
    {
        /*
           while(Condition = true)
           {
            // Do something
           }   

        if condition is true will working
        */

        int i = 0; // if you initialize variable inside of the loop the loop never have end

        while (i < 3) 
        { 
            Debug.Log("Loop While: " + i);
            i++;    
        }

    }

    private void LoopsDoWhile()
    {
        /*
           Do {
            
           }
           while(Condition = true); 
        */
        int i = 0;

        do
        {
            Debug.Log("Loop DoWhile: " + i);
            i++;
        }
        while (i < 3);

    }

    private void LoopsFor()
    {
        /*
           for (Initialize the variable; condition; increment/decrement) 
            {

                // Do Something
            }

        */
        string[] nameArray = new string[]
        {
           "IronMan",
           "Hulk",
           "Thor",
           "SpiderMan"
        };

        for (int i = 0; i < nameArray.Length; i++) // we dont need to increment in foor loop
        {
            Debug.Log("Loop For: " + nameArray[i]);
        }

        List<string> arrayName = new List<string>()
        {
           "IronMan",
           "Hulk",
           "Thor",
           "SpiderMan"
        };

        for (int i = 0; i < arrayName.Count; i++) // we dont need to increment in foor loop
        {
            Debug.Log("Loop list with For: " + arrayName[i]);
        }
    }

    private void LoopsForeach()
    {
        /*
           foreach (ITERATOR in COLLECTION) 
            {
                // Do Something
            }

        we use for collections
        */

        string[] nameArray = new string[]
        {
           "SuperMan",
           "BatMan",
           "Flash"
        };

        foreach (string name in nameArray) // we use string because its the variable of array
        {
            Debug.Log("Loop foreach: " + name); // we print the variable name
        }

    }
}
