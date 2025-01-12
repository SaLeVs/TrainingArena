using UnityEngine;

public class Class : MonoBehaviour
{
   
    // The core of any object oriented programming laanguage, how to define your own types


    private void Start()
    {
        int age = 56;
        Player player = new Player();
        Player ironManPlayer = new Player();

        Debug.Log(age);
        Debug.Log(player.GetHashCode() + " " + ironManPlayer.GetHashCode());

        ironManPlayer.name = "Movo";
        player.name = "Thiago";


        ironManPlayer.sayHello();
        player.sayHello();
        ironManPlayer.WhatIsThis("Ball");
    }


    class Player
    {
        public string name = "Veigh";

        public Player() // this is constructor
        {
            Debug.Log("Creating Player!");
        }

        public void sayHello()
        {
            Debug.Log($"Hello {name}!");
        }

        public void WhatIsThis(string what)
        {
            Debug.Log($"This is {what}!");
        }

        public void Test(string _name) // if you wnat to put the global variable here you can
        {
            name = _name; // change the name with _ or 
        }

        public void Test3(string name) // if you wnat to put the global variable here you can
        {
            this.name = name; // put this.
            
        }
    }

}
