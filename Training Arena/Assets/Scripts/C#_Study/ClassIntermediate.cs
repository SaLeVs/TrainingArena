using JetBrains.Annotations;
using UnityEditor.U2D.Sprites;
using UnityEngine;

public class ClassIntermediate : MonoBehaviour
{
    // Inheritance, Overrrides, Polymorphism

    private void Start()
    {
        // Unit unit = new Unit(); - If we try to create a new object from a abstract class we will get an error
        // unit.Move();
        Player player = new Player();
        player.Move();
    }


    public abstract class Unit // Unit dont now if have a player
    {
        protected float speed; // we can use protected for inheritance, all class that derives can use this variable

        public virtual void Move()
        {
            Debug.Log("Moving at unit");
        }
        public abstract void Attack(); // abstract method, we can't have a body

    }

    public class Player : Unit // We can have inheritance from a single class
    {
        // we can make a class sealed that can't be inherited

        public Player()
        {
            speed = 10;
            
        }

        ~Player() // this is destructor, all code that was in the destructor will be executed when the object is destroyed
        {

        }

        public override void Attack() // If we dont create a class of inheritance we will get an error
        {
            throw new System.NotImplementedException();
        }

        public override void Move()
        {
            Debug.Log("Moving at player");
        }

        
    }


}
