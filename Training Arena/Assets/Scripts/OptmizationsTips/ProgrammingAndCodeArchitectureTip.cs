using UnityEngine;

public class ProgrammingAndCodeArchitectureTip : MonoBehaviour
{
    // Understand about the unity Player loop
    // Dont abuse of Update, lateUpdate and FixedUpdate
    // If we need to use the Update, we can use a way for running in n frames
    
    private int interval = 5;

    void Update()
    {
        if (Time.frameCount % interval == 0)
        {
            // Do something
        }
    }

    // avoid heavy logic in start/awake
    // If we dont need use the Unity API, we can use the constructor for some start
    // we can use events on starts for dont put many logic in the start
    // we can use the singleton pattern for avoid many starts
    // pooling objects can help too
    // scriptable objects can help for data and settings



    // even empty monoBehaviours require resources, so you should remove blank update or lateUpdate methods
    // remove debu.log statemantes

    // use hash values for strings
    // avoid use addComponent at runtime
    // if we need to use het component, make on start and save on variable
    





}
