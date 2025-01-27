using UnityEngine;

public class Default : MonoBehaviour
{
    // Get the zero-equivalent value of a certain type, whatever it may be

    private void Start()
    {
        int i = 1;
        Debug.Log(default(int)); // 0
        Debug.Log(i);
    }
}
