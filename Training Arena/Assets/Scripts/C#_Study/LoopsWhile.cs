using UnityEngine;

public class LoopsWhile : MonoBehaviour
{
    
    void Start()
    {
        // LoopWhile();
        LoopDoWhile();
    }

    
    private void LoopWhile()
    {
        int x = 0;

        while (x <= 10)
        {   
            x++;
            Debug.Log(x);
        }
    }
    
    private void LoopDoWhile()
    {
        int x = 0;
        do // important for execute one time if the condition is not true
        {
            x++;
            Debug.Log(x);
        }
        while (x < 10);
    }
}
