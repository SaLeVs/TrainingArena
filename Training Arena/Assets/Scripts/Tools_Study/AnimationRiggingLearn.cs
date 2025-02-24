using UnityEngine;
using UnityEngine.Animations.Rigging;   // we need to add this namespace

public class AnimationRiggingLearn : MonoBehaviour
{
    // Add a dynamic montion on top of your animations
    // Its a package, so we need to install it
    // in documentation we have so much details about this package
    // for add animation rig make this:

    // Click on character father and on window animation rig click on rig setup
    // now we have a gameobject with rig component
    // when we click on father character, click on bone renderer setup on animation rig window, for see all bones
    // we create all objects inside of empty gameobjects childs of a gameobject with rig component that we created on first step
    // On constrained object we put the bone that we want to make the behaviour
    // If have some issues, try to switch the orientation (z, y, x)
    // On source objects we put the object that we aim
    // The target dont need to be in object, can be in the world
    // We can add gizmos for target direct in this package, we call as effector
    // we can config, but the important is disable gizmos on unity window (we can disable only for this package)

    // we can see all this working hitting play on unity or on animation window on preview mode
    // this is very performant beacause use c# jobs, and we need to disable and able for working on editor (like disable and able preview or play and pause the game)
    // When we create a script, we put on object with rig component

    // private Rig rig; // we create a variable

    private void Awake()
    {
        // rig = GetComponent<Rig>(); // and we can get on awake or serialize and atributte
        // after that we can modify values acessing rig
    }

    // We can convert the animation rigging for a skeleton to work like a legay animation
    // just select rig and click on transfer montion to skeleton
}
