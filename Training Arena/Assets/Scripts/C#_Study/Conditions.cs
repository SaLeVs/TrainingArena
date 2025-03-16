using UnityEngine;

public class Conditions : MonoBehaviour
{
    int coins = 100, characterCoust = 100;

    void Start()
    {
        if (coins > characterCoust)
        {
            coins -= characterCoust;
            print("can buy character");
            print(coins);
        }
        else if(coins == characterCoust)
        {
            coins -= characterCoust;
            print("can buy character, 0 coins");
            print(coins);
        }
        else
        {
            print("can not buy character");
            print(coins);
        }
    }

    // We use if and else when conditions are complexies or not based on a single variable
    // we can use if and else for combine with logical operators

    // We will use switch when we have a lot of conditions based on a single variable
    // make code more clean
    
}
