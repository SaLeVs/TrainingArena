using UnityEngine;

public class Variables : MonoBehaviour
{

    // we use variables for store data

    private int count = 0, x = 5;
    float jumpForce = 5.5f;
    string playerName = "Valverde";

    // = means that variable recive a value


    private void Awake()
    {
        count++;
    }

    private void Start()
    {
        count = count + 5;
        x = x - 1;
        print(playerName);
        print("jumpForce: " + jumpForce);
        Debug.Log(count);
        Debug.Log(x);
    }


    private void Update()
    {
        print(playerName);
    }

    private void DebugPlayerName()
    {
        print(playerName);
    }
}
