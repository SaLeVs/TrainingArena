using UnityEngine;

public class StaticConstructor : MonoBehaviour
{
    // Run initialization code before anything in a class is used

    private void Start()
    {
        Debug.Log(Player.i); 
        Player.TestFunction(); // this will appear before the constructor static and before the normal constructor
        Player player = new Player();
    }

    // we avoid use of start on the constructor object, because we can use the static constructor for that

    public class Player
    {
        static Player() // we cant put parameters here, or make public or private
        {
            Debug.Log("Player Static Constructor"); // this always run before the constructor
            i = 10;
        }

        public static int i;

        public static void TestFunction() // if we put static here, we can access this function without creating an instance of the class
        {
            Debug.Log("Test Function");
        }

        public Player() 
        {
            Debug.Log("Player Constructor");    
        }
    }
}
