using UnityEngine;

public class ValueXReferenceType : MonoBehaviour
{
    // One works as a copy, the other works as a reference

    // Value types: Contain their data
    // int, float, bool, enum, struct

    // Reference types: Contain a reference to their data

    // Class, objects, array, string


    private void Start()
    {
        
        // Reference types store a reference to the data, a obj in memory

        MyClass myClass = new MyClass();
        myClass.a = 7;
        
        MyClass mySecondClass = myClass;
        mySecondClass.a = 10;

        Debug.Log("Class: " + myClass.a); // the value is 10 because it is a reference type, mySecondClass is a reference to myClass


        int a = 7;
        int b = a;
        b = 10;

        // Value types store the data itself, in locals differents on memory

        Debug.Log(a); // the value is 7 becasue it is a value type, b is a copy of a, its only a reference type


        MyStruct myStruct= new MyStruct();
        myStruct.a = 7;

        MyStruct mySecondStruct = myStruct;
        mySecondStruct.a = 10;

        Debug.Log(myStruct.a);
    }

    private class MyClass
    {
        public int a;
    }

    private struct MyStruct
    {
        public int a;
    }

}
