using UnityEngine;

public class ProjectConfigurationTip : MonoBehaviour
{
    // If your game on unity dont use accelerometer frequency, disable this on the project settings
    // In the Player settings, disable Auo Graphics API for unsupported platforms to prevent generating excessive shader variants
    // disable target architecture for older cpus if your apllication dont supporting them
    // in quality seetings, disable needless quality levels
    // if your game dont use the physics, disable this on the project settings

    // if the game wasn`t competitive, consider using the frame rate for 30fps
    // we can change the frame rate at runtime

    // we need to maintain the hierarchy clean and plane
    // avoid create gameobjects for organization
    // and always simplify the size of hierchy and number of father and children
    // always you m ove a father, all children will move too

    // Transform once, not twice
    // always set position and rotation in the same frame
    // if we are instantiating a prefab, we can set the position and rotation in the same line for avoid make two recalculations
    
}
