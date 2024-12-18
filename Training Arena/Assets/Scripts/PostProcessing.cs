using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;

public class PostProcessing : MonoBehaviour
{
    /*
        You need to create a post process object
        Put Volume on object
        Enable post processing on Camera
        Put vignette and put bloom
        
        For use glow its simple create material and active on camera, render pipiline asset and put emission
        Color adjustments its important for create saturation 
        We can add volumes for locals, and change the configuration specify for this local, we just need create a new game object and put Local, and add a new trigger collider
        We can change the layer that affects Post process on Camera     */

    private void Start()
    {
        Volume volume = GetComponent<Volume>(); // With this we can get all components on volume

        if (volume.profile.TryGet<Bloom>(out Bloom bloom)) // on debug mode and double clicked on profile you can get the name of class, and with this script ou can change all values and have explicative for it
        {
            bloom.intensity.value = 10f;
        }

    }

}
