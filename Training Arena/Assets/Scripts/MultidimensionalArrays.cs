using UnityEngine;
using System;

public class MultidimensionalArrays : MonoBehaviour
{

    int[,] intArray = new int[5, 6]; // the firs comma is the number of dimensions, the second is the number of elements in each dimension
    
    // the total size of the array is 5 * 6 = 30 elements

    int[,] array2D = { { 1, 2 }, { 3, 4 } }; // we can initialize the array with values

    int[][] intArray2 = new int[5][]; // we can also create jagged arrays, which are arrays of arrays
    
    // here we are creating an array of 5 arrays, but we are not defining the size of the arrays
    // each line can have multiple elements, but the number of elements in each line can be different


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

        for (int i = 0; i < array2D.GetLength(0); i++)
        {
            for (int j = 0; j < array2D.GetLength(1); j++)
            {
                Debug.Log(i + ", " + j + ": " + array2D[i, j]);
                // in this Debug we have the numbers in each dimension and the value of the element in that position
            }
        }
    }

   
}
