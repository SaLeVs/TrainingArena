using UnityEngine;

public class Variables : MonoBehaviour
{

    // we use variables for store data

    private int count = 0, x = 5;

    // = means that variable recive a value

    private void Start()
    {
        count = 5;
        x = x - 1;
        Debug.Log(count);
    }

}
