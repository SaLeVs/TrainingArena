using UnityEngine;

public class Interfaces : MonoBehaviour
{
    // Extremely powerful freature to make your code more modular

    // Interfaces are contratcs that a class can implement
    // Allow us to define functions and properties, but not the implementation
    // When a Class implements an interface it must implement those functions
    // We always put I before the name of the interface
    // We can define a property like int myInt { get; set; }
    // For use interfaces, we put the interface on different objects, and where you have an action...
    // create a function for get the Interface component and call the function on interface
     

    private void Start()
    {
        IAttackable attackable = new Player();
        AttackObject(new Player());
        AttackObject(new Enemy()); 
        
    }

    private void AttackObject(IAttackable attackable)
    {
        attackable.Damage();
        attackable.Attack();
    }

    public interface IAttackable
    {
        public void Damage(); // interfaces need to be public
        // we cant create variables on interfaces
        // But we can have properties
        // if we put value on damage, we dont nedd to put void Damage on all interfaces and will work
        public void Attack()
        {
            Debug.Log("Attack");
        }
    }

    public class Player : IAttackable
    {
        public void Damage()
        {
            Debug.Log("Player damage");
        }
    }

    public class Enemy : IAttackable
    {
        public void Damage()
        {
            Debug.Log("Enemy damage");
        }
    }
}
