using UnityEngine;

public class GPUresidentDrawerTip : MonoBehaviour
{
    // The GPU Resident Drawer automatically uses the BatchRendererGroup API to daw GamObjects with GPU instancing, wich reduces
    // the number of draw calls and frees CPU processing time

    // This cause a bigger impact for compile and init time


    // Edit -> Project Settings -> Quality -> on pipiline asset right click -> Properties
    // On GPU Resident Drawer, set to instanced drawing, for use this, we use the Foward+
    // For use foward+: Click on the desktop Renderer (universal renderer data)
    // And on Rendering path, change for Foward+

    // For make Gpu resident drawer more performatic:
    // Edit -> Project Settings -> Player -> Other Settings -> Disable static batching
    // On light settings, disable fixed lightmap size and mipmap limits

    // If some objects are with problem using GPU Resident Drawer, we can use the scrpit dissalow GPU driven rendering for disable the object
    // We can click on GPU Occlusion culling for decrease the quantity of triangles that will be rendered
     // if we have a UI warning, BatchRenderGroup variants, choose keep all

}
