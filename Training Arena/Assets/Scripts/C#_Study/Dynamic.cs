using UnityEngine;

public class Dynamic : MonoBehaviour
{
    // Write code against a type that does note exist at compile time

    dynamic d; // dynamic type means it can be anything
               // works on runtime, not compile time

    private void Start()
    {
        d = new object();
        // d.Test();   // no error at compile time, but error at runtime
    }

    // we can use dynamic with json data

}
