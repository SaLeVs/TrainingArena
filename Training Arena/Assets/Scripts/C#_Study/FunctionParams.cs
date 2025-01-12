using UnityEngine;

public class FunctionParams : MonoBehaviour
{
    // Add support for a function to receive any number of parameters


    private void Start()
    {
        PrintPlayerName("S4LeV", "Code Monkey");
    }


    private void PrintPlayerName(params string[] playerNameArray) // Add this, quite useful when you dont know how many parameters you will receive, but the function will work
    {
        Debug.Log(playerNameArray.Length); // this method only work with arrays

    }

}
