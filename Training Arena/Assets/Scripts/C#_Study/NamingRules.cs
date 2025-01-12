using System;
using UnityEngine;

public class NamingRules : MonoBehaviour
{
    // Always use good names for all your elements to help you manage complexity.
    // PascalCase : this one starts with a capital letter and then lowercase for ebery word afterwards.
    // camelCase : this one also has a capital for every second word but the first one is lower case.
    // snake_case : this one you just use an underscore to separate the various words.


    // Constants : UpperCase SnakeCase
    public const int CONSTANT_FIELD = 56;

    // Properties : PascalCase
    public static NamingRules Instance { get; private set; }

    // Events : PascalCase
    public event EventHandler OnSomethingHappened;

    // Fields : camelCase
    private float memberVariable;

    // Function Names : PascalCase
    private void Awake()
    {
        Instance = this;
    }
    
    // Function Params : camelCase
    private void DoSomething(float time)
    {
        memberVariable = time + Time.deltaTime;

        if(memberVariable > 0)
        {
            // Do something else...
        }
    }

    // dont use single-letter names in code. The goal of writing code is not to make it compact, but to make it understandable.
    // dont use acronyms or abbreviations, you might not remember
}
