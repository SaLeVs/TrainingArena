using UnityEngine;

public class OcclusionCullingTip : MonoBehaviour
{
    // When we select a object we have a occlusion window
    // that show occluder static and occludee static
    // Occluder static: objects that are behind him
    // Occludee static: get hidden when isn`t in the camera view

    // The default is using the both
    // for example, think in a object that not cover all, a tree for example, on the bake, the tree will be not cover a barrel, so we need to thing if we can use both

    // transparent things can`t be occluder, so we need to think about this

    // on bake we have a options to smallest occluder: if the object is smaller than variable, it will not be block other objects
    // and Smallest hole: the hole that are bigger then the variable of hole, will be filled in
    // Unity recommend to put the values between 0.05 and 0.5
    // backface Threshold: Removing data and lowering the quality of the data of the baking to lower the occlusion data size
    // Sometimes backface make bad things or bugs, we need to test
    //  to think in what will be occluded, use the overdraw mode on scene view

    // we dont need to clear the data, when you bake, all will overwrite the last bake

    // Camera volumes show what will be occluded
    // we can control the camera clipping planes for distance that occlusion culling will be active

    // Dynamic objects: in the mesh renderer, on aditional settings, we have a option for mark, this being marked by default
    // But he have other function for this

    // think in a door, for example, if we disable or enable, the occlusion culling will not work
    // So we add the component occlusion portal
    // This component is like a portal, so we can change by script using the function GetComponent<OcclusionPortal>().open = true/false

    // Occlusion areas, works like a collider
    // The occlusion area have two main purposes: Unity generates higher precision data and calculations within view volumes
    // Unity generates volumes even when no object are in the area

}
