using UnityEngine;

public class Conversions : MonoBehaviour
{
    float number = 50f;
    string names = "SaLeV";
    int years = 19;


    private void Start()
    {
        Debug.Log($"My name is {names} and I'm {years} years old");
        int age = (int)number; // we can convert values using this (int)
        print(age);
    }

     
}
