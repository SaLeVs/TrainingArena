using UnityEngine;

public class AnonymousTypes : MonoBehaviour
{
    // Structure some data without predefining a specific type


    private void Start()
    {
        Player player = new Player
        {
            playerName = "Player 1",
            id = 1
        };

        var playerData = new { Name = "Code Monkey", id = 1 }; // Anonymous Type
        Debug.Log(playerData); // Anonymous are readonly, so you can't change the values
        // probably we only use for organization and not for manipulation
        // if you put data, all data have to be equal to the data type, for exemple for add a new player data, you have to add a new name and id, only
        // the order of the data matter
    }

    public class Player
    {
        public string playerName;
        public int id;
    }
}
