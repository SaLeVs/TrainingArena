using UnityEngine;

public class NullCoalescingOperator : MonoBehaviour
{
    // Test if object is null, if so, assign or return a specific value

    private string playerName;  


    private void Start()
    {
        int playerNameLength;
        playerName = "Gui";

        playerNameLength = GetStringLength(playerName ?? ""); // if playerName is null, return the value in the right side of the operator, but if it is not null, return the value in the left side of the operator
        Debug.Log(playerNameLength);


        Player player = null;
        player ??= new Player(); // if player is null, create a new instance of Player class and assign it to player variable

    }

    private int GetStringLength(string name)
    {
        return name.Length;
    }

    private class Player 
    {
       
    }
}
