using UnityEngine;

public class ConstantsReadOnly : MonoBehaviour
{
    // Variables that have a value that will never change

    int age;
    private const float PLAYER_SPEED = 5f; // Constants are always uppercase

    // We cant declare a constant without a value
    // Constants works at compile time

    private readonly float PLAYER_HEALTH = 100f; // Readonly works at runtime
    // We can create variables of class using readonly

    // can be useful

    private void Start()
    {
        Debug.Log(PLAYER_SPEED);
        //  PLAYER_HEALTH = 50f; // We cant change the value of a constant
        Debug.Log(PLAYER_HEALTH);
    }
}
