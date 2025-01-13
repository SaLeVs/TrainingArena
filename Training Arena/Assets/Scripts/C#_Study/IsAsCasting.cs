using UnityEngine;
using static Interfaces;

public class IsAsCasting : MonoBehaviour
{
    // Learn the various ways to test and convert between types


    private void Start()
    {
        IMovementable movementable = new Player();

        if(movementable is Player)
        {
            Debug.Log("Is Player"); // this wil run
            Player player = movementable as Player; // or Player player = (Player)movementable;
            player.PlayerSayHello();

            // if we use cas (player)movementable and the movementable is not a player, the game will crash
            // If we use as, the player will be null and will work

        }

        if (movementable is Enemy)
        {
            Debug.Log("Is Enemy"); // this will not run
        }

        if(movementable.GetType() == typeof(Player))
        {
            Debug.Log("Is player get type"); // this will run
        }
    }


    public interface IMovementable
    {
        public void Move(); 
       
    }

    public class Player : IMovementable
    {
        public void Move()
        {
            Debug.Log("Player movement");
        }

        public void PlayerSayHello()
        {
            Debug.Log("Hello");
        }
    }

    public class Enemy : IMovementable
    {
        public void Move()
        {
            Debug.Log("Enemy movement");
        }
    }
}
