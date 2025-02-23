using System;
using UnityEngine;

public class Events : MonoBehaviour
{
    // How to have one class be notified when something happens
    // We have publisher and subscribers, when something happens, publisher notifies the subscribers
    // publisher dont know who is subscribing, subscribers dont know who is publishing
    // We dont mix logic and visual
    // We use to decouple code and make code clean
    // logic fire a event and visual update values
    // dont miss that we need to unsubscribe the event when we dont need it anymore
    // We only add -= to unsubscribe

    public event EventHandler OnPlayerDeath;

    // real test

    public event Action OnPlayerSayHello;

    private void Start()
    {
        SayHello();
    }

    private void SayHello()
    {
        if(OnPlayerSayHello != null)
        {
            OnPlayerSayHello();
        }
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            OnPlayerDeath?.Invoke(this, EventArgs.Empty);
        }
    }

    private void Damage()
    {
        Debug.Log("Player has been damaged");
    }
}
