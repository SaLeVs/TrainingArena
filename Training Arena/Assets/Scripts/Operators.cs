using Mono.Cecil;
using UnityEngine;

public class Operators : MonoBehaviour
{
    /* We use operators for compare values

    == equal
    != different
    > greater than
    < less than
    >= greater or equal
    <= less or equal

    */
    
    /* 
     LOGICAL OPERATORS
     
     &&  And
     ||  Or
      !  Not
     
     */

    int x = 2, y = 4;
    // string name1 = "Sterling", name2 = "sterling"; // the upper and lower case means for unity

    string humor;
    bool pizza, soda;
    void Start()
    {
        name = !(y > x) ? "positivo" : "negativo";
        //Debug.Log(name);
        pizza = false;
        soda = false;
        humor = (pizza == true) || (soda == true) ? "feliz" : "triste";
        Debug.Log(humor);
    }


    void Update()
    {
        
    }
}
