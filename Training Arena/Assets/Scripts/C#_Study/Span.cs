using System;
using UnityEngine;

public class Span : MonoBehaviour
{
    // Super efficient way to deal with collections without a memory cost

    private void Start()
    {
        int[] numberArray = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        int[] subArray = new int[numberArray.Length - 2];

        Span<int> intSpan = new Span<int>(numberArray, 1, 6);
        // intSpan.Sort();
        // intSpan.CopyTo(subArray);
        // its interesting know about the methods that we can use with Span
    }
    // In unity we can use the NativeArray<T> instead of Span<T> to have the same benefits
}
