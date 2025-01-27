using UnityEngine;

public class NameOf : MonoBehaviour
{
    // Get the name of a Type of field or function, without hardcoding strings

    private void Start()
    {
        string playerClassName = nameof(Player); // name of is a keyword that returns the name of something
        // can be useful for avoid hardcoding strings
        // But, the most value about this is when we use it in the refactoring, for example, if the name player was "Player", if we change the name of the class, the string dont will change
        // but the name of will change
        // work for fields, classes, functions, etc
        Debug.Log(playerClassName);
    }
    public class Player
    {
        public int speed;

        public bool IsGrounded()
        {
            return true;
        }
    }
}
