using System.Runtime.InteropServices;
using UnityEngine;

public class SizeOf : MonoBehaviour
{
    // Inspect the size of a certain type

    private void Start()
    {
        int i = 5;  
        Debug.Log(sizeof(int)); // 4 bytes
        // we cant use size of for classes
        // we can use marshal for that
        Debug.Log(Marshal.SizeOf(new Player()));
        // Marshal works for structs too
    }

    [StructLayout(LayoutKind.Sequential)] // we need to put this for verify class size
    public class Player
    {
        public int speed;
        public bool IsGrounded()
        {
            return true;
        }
    }
}
