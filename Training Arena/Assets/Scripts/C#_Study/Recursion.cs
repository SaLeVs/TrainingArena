using UnityEngine;

public class Recursion : MonoBehaviour
{
    // Mathematical way of making looping logic

    private void Start()
    {
        Debug.Log("First Incrementer: " + RecursionIncrementer(0));
        Debug.Log("Second Incrementer: " + RecursionIncrementerMax(0, 5, 1));
    }

    private int RecursionIncrementer(int _number)
    {
        if (_number < 5)
        {
            return RecursionIncrementer(_number + 1);
        }
        else
        {
            return _number;
        }
    }

    private int RecursionIncrementerMax(int _number, int _numberMax, int incrementAmount)
    {
        if (_number < _numberMax)
        {
            return RecursionIncrementerMax(_number + incrementAmount, _numberMax, incrementAmount);
        }
        else
        {
            return _number;
        }
    }

    // its similar a loops, but its a different way of doing it

}
