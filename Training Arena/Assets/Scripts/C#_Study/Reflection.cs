using System;
using System.Reflection;
using UnityEngine;

public class Reflection : MonoBehaviour
{
    // Dynamically inspect and execute your code

    // is a name for a bunch of functions that you can run on the types themselves


    private void Start()
    {

         // here we create a new instance of Player class

        Exercise exercise = new Exercise();
        exercise.MyFunction();

        MethodInfo myFunctionMethodInfo = typeof(Exercise).GetMethod("MyFunction");
        myFunctionMethodInfo.Invoke(exercise, new object[] {} );

        Type playerType = typeof(Exercise).GetNestedType("Player"); // here we get a type of specifc class
        // we will use playerType for search functions. Or we can use Type of the class directly

        object playerObject = Activator.CreateInstance(playerType);
        foreach (Type type in typeof(Exercise).GetNestedTypes(BindingFlags.NonPublic)) // here we get all classes inside Exercise class, and can add filters
        {
            Debug.Log(type); // binding flags = filters, for add more filters we can use | operator (bindingFlags.NonPublic | BindingFlags.Public)
        }

        MethodInfo myfunctionMethodInfo = playerType.GetMethod("MyFunction"); // here we get a method from a class
        // myfunctionMethodInfo.GetParameters(); // here we get the parameters of the method
        myfunctionMethodInfo.ReturnType.ToString(); // here we get the return type of the method

        myfunctionMethodInfo.Invoke(playerObject, new object[] { }); // here we create a new instance of Player class and call MyFunction method
        // Here we are using reflection to call a method that we dont know if it exists, if you look, the methods dont have references, so we can call them without knowing if they exist

        
    }


    public class Exercise
    {
        public void MyFunction()
        {
            Debug.Log("MyFunction");
        }

        public class Player
        {

        }

        private class Wizard
        {

        }

        public class Enemy { }

        // we can use reflection to execute a code that dont exist yet

    }

}
