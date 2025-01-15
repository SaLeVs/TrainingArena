using UnityEngine;
using System;

public class FinishExplanationAboutSubscribers : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        FinishExplanationAboutEvents finishExplanationAboutEvents = GetComponent<FinishExplanationAboutEvents>();

        if(finishExplanationAboutEvents != null)
        {
            finishExplanationAboutEvents.OnSpacePressed += TestingSubscriber_OnSpacePressed;
        }
            
    }

    //private void TestingSubscriber_OnSpacePressed(object sender, EventArgs e)
    //{
    //    Debug.Log("In the other script, the space key was pressed");
    //}

    private void TestingSubscriber_OnSpacePressed(object sender, FinishExplanationAboutEvents.OnSpacePressedEventArgs e) // in this way we can pass parameters
    {
        Debug.Log("In the other script, the space key was pressed" + " " + e._spacePressedCount);
    }
}
