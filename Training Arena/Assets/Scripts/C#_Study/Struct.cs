using UnityEngine;
using static Struct;

public class Struct : MonoBehaviour
{
    // Similar to a class, but value type


    private void Start()
    {

        PlayerStruct playerStruct = new PlayerStruct();
        playerStruct.a = 1;

        PlayerClass playerClass = new PlayerClass();
        playerClass.a = 1;

        TesteFunctionStruct(playerStruct);
        TestFunctionClass(playerClass);

        Debug.Log("Player Struct: " + playerStruct.a); // the value is 1 because it is a value type, the function TesteFunctionStruct is a copy of playerStruct
        Debug.Log("Player Class: " + playerClass.a); // the value is 2 because it is a reference type, the function TestFunctionClass is a reference to playerClass

    }

    private void TesteFunctionStruct(PlayerStruct _playerStruct)
    {
        _playerStruct.a = 2;
    }

    private void TestFunctionClass(PlayerClass _playerClass)
    {
        _playerClass.a = 2;
    }

    public struct PlayerStruct
    {
        public int a;
    }

    public class PlayerClass
    {
        public int a;
    }

    // We use struct to save data, like a player, a weapon, a item, etc
    // we can use struct for save memory and make game faster
    // Use for data that cant change
    // Heap and stack are areas in memory that programs use to store data
    // Stack is used for static memory allocation and Heap for dynamic memory allocation
    // MyClass obj = new MyClass(); - Object stores on heap 
    // int a = 7; - Variable stores on stack.

}
