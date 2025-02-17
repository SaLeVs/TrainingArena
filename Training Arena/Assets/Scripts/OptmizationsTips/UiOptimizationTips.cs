using UnityEngine;

public class UiOptimizationTips : MonoBehaviour
{
    // Divide your canvases
    // If youe have one large canvas with thousands of elements forces the whole canvas to update, wich can generate a CPU spike
    // Divide UI elements basead on how frequently they need to be refreshed
    // Keep static UI elements on separate canvas and dynamic elements that update at the same time on smaller sub-canvases
    // Ensure that all UI elements within eache Canvas have the same Z value, materials and textures.

    // Hidle invisible UI elements
    // If your invisible UI elements is active, it might still be using draw calls
    // Eplicity disable any invisible UI components and re-enable them as needed
    // If you only need to turn off the canvas component rather than the whole GameObject
    // This prevent your game from having to rebuild meshes and verticer when you re-enable the component

    // Limit GraphicRaycaster and disable Raycast Target
    // Remove the defacult GraphicRaycaster from the top canvas in the hierarchy
    // Instead add the GraphicRaycaster exclusively to individual elements that need to interact (buttons, scrollrects, etc)
    // We use GraphicRaycaster for listen input events, like onscreen toucher or clickes
    // In addition, disable Raycast target on all Ui text and images that do not need to be interacted 

    // Avoid Layout Groups
    // Layout groups update inefficiently so use them sparingly
    // However, if your content isn't dynamic, its generally best to avoid using them and use anchors for proportional layout instead

    // Avoid large List and Grid views
    // If you need to create a large list or grid view, consider reusing a smaller pool of UI elements rather than creating a UI element for every item
    // We have a sample on GitHub project

    // Use multiple resolutions and aspect ratios
    // With mobiles devices now using very different resolutions and screen sizes, create alternate versions of your UI to provide the best experience on each device
    // We can use device simulator for text in each device

    // When using a fullscreen UI, hide everything else
    // if your pause or start screen cover everything else in the scene, disable the camera that is redering the 3d scene
    // Simirlary disable any background Canvas elements hidden behind the top Canvas
    // Consider lowering the Application.targetFrameRate during a fullscreen UI

    // Assing the Camera to world space and Camera Space Canvases
    // Leaving the Event or Render Camera field blank forces unity to fill in Camera.main, which is unnecessarily expensive
    // Consider using screen space - Overlay for your Canvas RenderMode if possible, as that does not require a camera



}
