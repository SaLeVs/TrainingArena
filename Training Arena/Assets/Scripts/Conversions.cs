using UnityEngine;

public class Conversions : MonoBehaviour
{
    float number = 50f;
    string name = "SaLeV";
    int age = 19;


    private void Start()
    {
        Debug.Log($"My name is {name} and I'm {age} years old")
        int age = (int)number; // we can convert values using this (int)
        print(age);
    }

     
}
