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
    

    int x = 2, y = 4;
    string name1 = "Sterling", name2 = "sterling"; // the upper and lower case means for unity

    void Start()
    {
        print(x == y);
        print(name1 != name2);
  
    }


    void Update()
    {
        
    }
}
