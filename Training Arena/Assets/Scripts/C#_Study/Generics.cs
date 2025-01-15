using UnityEngine;

public class Generics : MonoBehaviour
{
    // make your classes work with any data type


    private void Start()
    {
        MyList<int> myIntList = new MyList<int>();
        myIntList.field = 5;
        Debug.Log(myIntList.field);

        MyList<bool> myBoolList = new MyList<bool>(); // we can define and create other object and modify the same properties
        myBoolList.field = true;
        Debug.Log(myBoolList.MyFunction());

    }
        
    private class MyList<T> 
    {
        public T field;

        public T MyFunction()
        {
            return default;
            // return null; // return cant be null, because it is a value type
        }
    }

    private class MySecondClass<T> where T : class, new() // Here we are defining that T must be a class
    {
        public T field;
        
        public T MyFunction2()
        {
            new T(); // this work because we add the New() constraint   
            return new T();
        }
    }

    private void TestFunction<T>() // normally we define the functions with generics
    {

    }
}
