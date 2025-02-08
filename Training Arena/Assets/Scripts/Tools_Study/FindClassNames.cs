using Unity.Cinemachine;
using UnityEngine;

public class FindClassNames : MonoBehaviour
{
    // Learn how to interact with any tool of freature

    // This is a tip for find the class names and allow you to find and modify all classes in unity
    // Right click mouse on the component and click on "Edit Script"
    // Pay attetion, if one variable is inside on one group, for example, Vertical fov is inside on Lens group


    private void Awake()
    {
        CinemachineCamera cinemachineCamera = GetComponent<CinemachineCamera>();
    }
}
