using Unity.VisualScripting;
using UnityEngine;

public class TernaryConditionalOperator : MonoBehaviour
{
    // Super compact way of doing simple if else statements

    private void Start()
    {
        Player player = new Player();
        Debug.Log(player.GetPlayerStateString());
    }

    private class Player
    {
        private int health = 0;

        public string GetPlayerStateString()
        {
            // if (health > 50)
            // {
            //    return "Healthy";
            // }
            // else
            // {
            //    return "Injured";
            // }

            // The code above can be written in a more compact way using the ternary conditional operator
            return health > 0 ? "Healthy" : "Injured";
        }


    }

      
}
