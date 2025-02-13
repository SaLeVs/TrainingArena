using UnityEngine;

public class LightProbesTip : MonoBehaviour
{
    // Light probes is a way to add more realistic lighting to your scene
    // When we have a scene with a lot of objects static and we had a moveable object, we can use light probes to make the lighting more realistic

    // we need to put the light static and mode mixed
    // light - light probe group
    // basically we need to add a light probe in every local that change the illumination
    // probes can not be inside of the objects, this can cause bugs
    // we can test the probes moving the object and see if the lighting is correct
    // if we have a bugs in game, we need to disable auto generate and add generate manually on lightmapping settingss
}
