using UnityEditor.Splines;
using UnityEngine;

public class AditionalDebugTips : MonoBehaviour
{
    // use Debug.Break() to pause the game in the editor
    // Debug.DrawLine() to draw a line in the scene view
    // Debug.DrawRay() to draw a ray in the scene view

    // for use breakpoints 

    private int i;
    private void Start()
    {
        i = 5; // we just click on the left side of the line number to add a breakpoint
        Debug.Log(i); // then we click on the play button

        // after that we click on "anexar ao unity"
        // we can see the value of the variable i and a bunch of information
    }
}
