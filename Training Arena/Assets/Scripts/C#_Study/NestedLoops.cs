using UnityEngine;

public class NestedLoops : MonoBehaviour
{
    //  Learn to write loops within loops


    void Start()
    {
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 2; j++) // normally  we use i, j, k, l, m. Its a convention of nested loops
            {
                Debug.Log(i + ", " + j);
            }   
        }
        // mix nested loops with bools can be valious for create new logics
        // we can mix all types of loops with each other
    }

}
