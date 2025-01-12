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

    
}
