using UnityEngine;
using static IsAsCasting;

public class SwichTypeMatching : MonoBehaviour
{
    // Switch on type instead of just on Value
    private void Start()
    {
        IDefensable defensable = new Player2();

        switch (defensable) // we can test the type of interface and can acess the methods of the class that implements the interface
        {
            case Player2 player2:
                player2.Defense(); 
                break;
            case Enemy2 enemy2 when enemy2.health > 50: // we can also test the properties of the class that implements the interface
                enemy2.Defense();
                break;
            case Enemy2 enemy2: // we can use the same if normal case go after the "when"
                enemy2.Defense();   
                break;
        }
    }
    


    public interface IDefensable
    {
        public void Defense();

    }

    public class Player2 : IDefensable
    {
        public int health = 100;

        public void Defense()
        {
            Debug.Log("Player defense");
        }
    }

    public class Enemy2 : IDefensable
    {
        public int health = 100;

        public void Defense()
        {
            Debug.Log("Enemy defense");
        }
    }
}
