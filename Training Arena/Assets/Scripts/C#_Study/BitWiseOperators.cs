using UnityEngine;

public class BitWiseOperators : MonoBehaviour
{
    // Manipulate individual bits in memory
    // basically here we will make counts with bits and binary

    private void Start()
    {
        int a = 5;
        int b = 3;
        Debug.Log(5 & 3); // 1
        Debug.Log(5 | 3); // 7
        Debug.Log(5 ^ 3); // 6
        Debug.Log(~5);    // -6

        // this dont have so much utillits, but can be useful in some cases with layer masks
    }

}
