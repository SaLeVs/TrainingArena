using UnityEngine;
using System;

public class MultidimensionalArrays : MonoBehaviour
{

    int[,] intArray = new int[5, 6]; // the firs comma is the number of dimensions, the second is the number of elements in each dimension

    int[,] array2D = { { 1, 2 }, { 3, 4 } }; // we can initialize the array with values



    void Start()
    {
        for (int i = 0; i < intArray.GetLength(0); i++)
        {
            for (int j = 0; j < intArray.GetLength(1); j++)
            {
                Debug.Log(i + ", " + j + ": " + intArray[i, j]);
                // in this Debug we have the numbers in each dimension and the value of the element in that position
            }
        }   
    }

   
}
