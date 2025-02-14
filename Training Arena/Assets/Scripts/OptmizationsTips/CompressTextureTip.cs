using UnityEngine;

public class CompressTextureTip : MonoBehaviour
{
    // Use ATSC for mobile, Xr and web
    // The vast majority of textures in your game should be compressed using the ATSC format.

    // Compreess the mesh, we need to experiment with the compression settings to find the best balance between quality and performance
    // We need to disable read/write on meshs, this can consume much memory
    // Disable rigs and blend shapes if your mesh dont need skeletal or blendshape, disable it
    // if you are certain that the mesh material will not need normals or tangents, uncheck normals and tangents

}
