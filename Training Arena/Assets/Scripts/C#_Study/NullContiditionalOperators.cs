using UnityEngine;

public class NullContiditionalOperators : MonoBehaviour
{
    // Safely and compactely test if an object is null, if not, do something

    private void Start()
    {
        Player player = new Player();
        Debug.Log(player?.GetPlayerName()); // we can use this for make tests and depending on the result, do something
        // this operator cant be used for value types, only for reference types
        // So we cant use for check if a int is null, but we can use for check if a object is null
    }


    public class Player 
    { 
        public string GetPlayerName()
        {
            return "Gui";
        }
    
    }

}
