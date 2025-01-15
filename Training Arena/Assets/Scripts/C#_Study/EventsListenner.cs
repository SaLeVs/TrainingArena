using System;
using UnityEngine;

public class EventsListenner : MonoBehaviour
{

   // private Events events;

    public EventsListenner(Events events)
    {
       events.OnPlayerSayHello += Events_OnPlayerSayHello;
    }

    private void Events_OnPlayerSayHello()
    {
        Debug.Log("Hello Player");
    }

    private void Start()
    {
        // events.OnPlayerDeath += Events_OnPlayerDeath;
        Events events = new Events();   
    }

    private void Events_OnPlayerDeath(object sender, System.EventArgs e)
    {
        Debug.Log("Player has died by other script");
    }

    
}
