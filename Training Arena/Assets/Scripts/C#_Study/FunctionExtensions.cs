 using UnityEngine;


public static class TransformExtensions
{
    public static void MoveRight(this Transform transform) // we can add parameters here
    {
        transform.position += new Vector3(1, 0, 0);
    }

    public static bool IsTrue(this bool b)
    {
        return b;
    }
}

public class FunctionExtensions : MonoBehaviour
{
    // Extend a type with a new function without modifying it


    private void Start()
    {
        MyTranform myTranform = null;
        myTranform.MoveRight();

        transform.MoveRight();
        TransformExtensions.MoveRight(transform);

    }

    public class MyTranform
    {
        public Vector3 position;

        public void MoveRight()
        {
            position += new Vector3(1, 0, 0);
        }
    }

    // we use this for modify functions that already exist on unity objects, for facilitate the use of them, and avoid repeating code
}
