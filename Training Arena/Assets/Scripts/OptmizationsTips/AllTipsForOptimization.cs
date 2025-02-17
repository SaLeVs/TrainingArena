using UnityEngine;

public class AllTipsForOptimization : MonoBehaviour
{
    // Unity recommends using the URP for developing mobile games, xr and web
    // We dont need wait for significant performance problems to start profiling
    // Devices can exceed this budget of temperature for short periods, like in cutscenes and loading sequences, but not for a prolonged duration

    // Avoid mobile native resolution
    // We can use Screen.SetResolution(width, height, false) to lower the output resolution and regain some performance
    
    // Limit use of Cameras
    // Only use the Camera components required for rendering . On lower-end mobile, each camera can use up to 1ms of CPU time
    
}
