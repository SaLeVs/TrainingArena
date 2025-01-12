using Unity.VisualScripting;
using UnityEngine;

public class Counters : MonoBehaviour
{

    int number = 1;
    float time;

    void Start()
    {
        number++; // for increase one each frame
        number--; // for decrease one each frame
        number += 3; // if you put this, will increase the number
        number -= 2; // if you put this, will decrease the number
        Debug.Log(number);
    }

    
    void Update()
    {
        time = time + Time.deltaTime;
       // Debug.Log(time);
    }
}
