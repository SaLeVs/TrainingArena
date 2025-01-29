using UnityEngine;

public class AssertTests : MonoBehaviour
{
    // Validate your code and a high level overview of how Unit Testing

    public class Player
    {
        private string playerName;

        public Player(string name)
        {
            Debug.Assert(name != null); // for use this function you need to enable debug mode on Visual Studio
            this.playerName = name;
        }
    }
}
