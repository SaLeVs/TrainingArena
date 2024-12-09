using UnityEngine;

public class ConditionalStructure : MonoBehaviour
{

    // condition ?  value for assignment if true : value for assignment if false
    int x = 10, y = 20;
    string resultado;

    void Start()
    {
        resultado = y > x ? "positivo" : "negativo"; // ternary operator
        printResults();
    }


    void printResults()
    {
        int clicks = x < 10 ? 5 : -5;
        print(clicks);
    }
}
