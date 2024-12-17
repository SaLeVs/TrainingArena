using NUnit.Framework;
using System.Collections.Generic;
using UnityEngine;

public class ArraysAndLists : MonoBehaviour
{
    // Collections: Array and Lists


    int[] numbersArray = new int[2]; // if we dont put values, all will start with 0
    // if we want we can fill the values
    // numbersArray[0] = 10;
    // numbersArray[1] = 20;
    // numbersArray[2] = 30;
    // numbersArray[3] = 40;
    // numbersArray[4] = 50;
    // We use this when does not know the value 

    int[] ArrayNumbers = new int[] { 25, 56, 12 }; // here we are defining the values for array
    // we dont need put new int


    // we need initilialize array before use


    List<int> numbersList = new List<int>();

    void Start()
    {

        Debug.Log(numbersArray.Length); // lenght return the size of array
        Debug.Log(ArrayNumbers[0]); // index 0 are the first of array

        // we can find a array of a number on array
        Debug.Log("ArrayIndex: " + System.Array.IndexOf(ArrayNumbers, 12));

        numbersList.Add(14); // if you do this, its only add on the end of List
        numbersList.Add(15); // pass the index and after the value
        numbersList.Add(16);

        // if we need to remove a object on list we can:
        numbersList.Remove(14); // for remove the specific element or
        numbersList.RemoveAt(0); // for remove the position on index of element
        Debug.Log(numbersList.Count);

        Debug.Log(numbersList.Contains(16)); // for check if the object are on list
        Debug.Log(numbersList.IndexOf(16)); // for check the index of a object on list, if return -1 is not found
    }

    
}
