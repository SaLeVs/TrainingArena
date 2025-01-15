using System;
using UnityEngine;

public class Delegates : MonoBehaviour
{
    // Store a function within a variable parameter

    private delegate void attackDelegate(); // void here
    private attackDelegate attackAction;

    private delegate int MyDelegate(string str);
    private Action myAction; // this dont will return anything, Action is for void
    private Func<string, int> myFunc; // this will return something, Func is for return

    private bool toggleButton = false;

    Action MyAction2 = () => { Debug.Log("Magic spell attack"); }; // if we do this, we dont need to declare the method
    Action<int> MyAction3 = (int i) => { Debug.Log("Mental attack"); }; // Using delegates with parameters
    Func<int, bool> MyAction4 = (int i) => { return false; }; // Using delegates with parameters and return


    private void Start()
    {
       attackAction = MeleeAttack; // assign the method to the delegate
       myAction = MeleeAttack; 
       MyDelegate myDelegate = MyTestFunction;

        attackAction = MeleeAttack;
        attackAction += RangedAttack; // we can add more than one method to the delegate, we can erase a method with -=
        attackAction(); // This will call both methods
    }


    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.A)) // Good way to create a toggle button
        {
            if (toggleButton)
            {
                attackAction = MeleeAttack; 
                toggleButton = false;     
            }
            else
            {
                attackAction = RangedAttack; 
                toggleButton = true;         
            }
        }

        attackAction(); 

        if (Input.GetKeyDown(KeyCode.S))
        {
            toggleButton = !toggleButton; // sempre pensar nisso ao usar toggles
            attackAction = toggleButton ? RangedAttack : MeleeAttack; // I love ternary operators
        }
    }


    private int MyTestFunction(string myString)
    {
        return 0;
    }

    private void MeleeAttack() // the type of delegate is the same as the method, void here
    {
        Debug.Log("Melee Attack"); // the number of parameters must be the same
    }

    private void RangedAttack() // the type of delegate is the same as the method, void here
    {
        Debug.Log("Ranged Attack"); // the number of parameters must be the same
    }
}
