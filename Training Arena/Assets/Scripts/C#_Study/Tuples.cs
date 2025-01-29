using UnityEngine;

public class Tuples : MonoBehaviour
{
    // Structure some data without defining a type

    private void Start()
    {
        var myTuple = ("Code Monkey", 56); // Tuple
        Debug.Log(myTuple); // (Code Monkey, 56)
        myTuple.Item1 = "New Name"; // Error, Tuple values are readonly
        // we can acess the items by the name Item1, Item2, Item3, etc
        // but if we define the variables before and put the name on myTuple, we can acess and change the values
        (string name, int age) myTuple2 = ("Code Monkey", 56); // Other way to define a Tuple
        myTuple2.name = "New Name"; // OK

        var tuple = GetTuple();
        Debug.Log(tuple); // (Code Monkey, 56)
    }

    public (string name, int value) GetTuple() // we can use tuple on functions for return multiple values
    {
        return ("Code Monkey", 56);
    }
}
