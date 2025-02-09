using UnityEngine;

public class AnimationWindow : MonoBehaviour
{
    // Set up Keyframes and Curves to animate any object
    // the button preview works for show that object was in animation mode, not in real position
    // The root montion is for move the object indepentes of the pos that are save on animation
    // a good tip for organization is put the main object with all logics, and the children with all visual scripts
    // make this above, you can animate the children and the main object can be controlled in all positions
    // crazy, we can change the values on scripts using the animation window
    // if you select the firts keyframe, you will select all keyframes of that time
    // add a new keyframe, you can change the values of all properties of object
    // Pay attetion for change nomes of objects because the animation will not find the object
    // for modify read only animations, we can duplicate the animation clip and modify the all values
    // Animation events are useful for call methods in a specific time of animation, acessing scripts
    // the script must be attached on the object that have the animator for works
    // we can pass parameters for the functions

    private void TestAnimationsEvents()
    {
        Debug.Log("TestAnimationsEvents");
    }
}
