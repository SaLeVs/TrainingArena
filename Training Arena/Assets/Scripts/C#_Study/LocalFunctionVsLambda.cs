using System;
using UnityEngine;

public class LocalFunctionVsLambda : MonoBehaviour
{
    // Learn the difference between these two similar conceptss
    // local function defines on the compile time, lambda defines on the runtime
    // its more optimized to use local functions

    private void Start()
    {
        Print("Hello World"); // we can use local functions before that they are 

        void Print(string message)
        {
            Debug.Log(message);
        }

        Action<string> myAction2 = Print;
    }

    
}
