using Unity.VisualScripting;
using UnityEngine;

public class Exercise : MonoBehaviour
{
    

    void Start()
    {
        Debug.Log(imparOrPar(2));
        Debug.Log(imparOrPar(3));
        Debug.Log(imparOrPar(4));
        Debug.Log(imparOrPar(5));
        Debug.Log("clean ------------------------------");
        Debug.Log(ParOrImpar(0));
        Debug.Log(ParOrImpar(1));
        Debug.Log(ParOrImpar(2));
        Debug.Log(ParOrImpar(3));
    }


    string imparOrPar(int number)
    {
        string txt;

        if (number == 0)
        {
            txt = "o numero é nulo";
        }
        else
        {
            int resto = number % 2;
            if (resto == 0)
            {
                txt = "o numero é par";
            }
            else
            {
                txt = "o numero é impar";
            }
        }
        return txt;
    }

    string ParOrImpar(int number)
    {
        string txt;

        switch (number)
        {
            case 0:
                txt = "o numero é nulo /2";
                break;
            default: // interesting that use the default like a else, for verify all others case that are tested before
                int resto = number % 2;
                switch (resto)
                {
                    case 0:
                        txt = "o numero é par /2";
                        break;
                    default:
                        txt = "o numero é impar /2";
                        break;
                }
                break;
        }
        return txt;
    }
}
