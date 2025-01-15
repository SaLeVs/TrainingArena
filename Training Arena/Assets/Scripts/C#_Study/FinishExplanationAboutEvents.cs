using System;
using UnityEngine;

public class FinishExplanationAboutEvents : MonoBehaviour
{
    public event EventHandler<OnSpacePressedEventArgs> OnSpacePressed;

    public class OnSpacePressedEventArgs : EventArgs // this will more advenced for pass parameters
    {
        public int _spacePressedCount;

    }

    private int spacePressedCount;

    private void Start()
    {
       // OnSpacePressed += Testing_OnSpacePressed;
    }
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            // OnSpacePressed?.Invoke(this, EventArgs.Empty); // here we are firing off your event
            // we need a subscriber to this event to do something, otherwise nothing will happen
            spacePressedCount++;
            OnSpacePressed?.Invoke(this, new OnSpacePressedEventArgs { _spacePressedCount = spacePressedCount });
        }
    }

    private void Testing_OnSpacePressed(object sender, EventArgs e)
    {
        Debug.Log("Space was pressed");
    }
}
