using UnityEngine;

public class ProgressiveLightmappesTip : MonoBehaviour
{
    // We need to put lighprobes
    // mark all objects with static flag
    // use the reflection probe on the area that will be affected by the light
    // if you bake and some objetcs are not being affected by the light, try to incresa the scale on the lightmap on the mesh renderer
    // some materials have a property called double sided, if you enable it, the light will be calculated on both sides of the mesh, disable it if you don't need it, this can cause light leaks
    // if you are using terrains modify the properties lighmap parameters for defatul medium, scale lightmap for 1 and increase the resolution to 2048
    // set the enviroment lighting for gradient, and use sky color and equator color with the gray color
    // we have a button on unity like a moon that allows us to see the lightmap scale of all objects
}
