using UnityEngine;

public class Methods : MonoBehaviour
{
    // void means that methods dont return values

    int x, y;


    private void Start()
    {
        x = 5;
        y = 10;
        UpdateValues();
        MultiplyValues(x,y);
    }

   
    void UpdateValues()
    {
        int resultado;
        resultado = x + y;

        print(resultado);
        // we can use print only for monobehaviour scripts
        // Debug log works on all unity
    }

    void MultiplyValues (int valueA, int valueB)
    {
        int resultado;

        resultado = valueA * valueB;

        Debug.Log(resultado);
        // we can use same names for local variables

    }
}
