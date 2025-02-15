using UnityEngine;

public class ReduceDrawCallTips : MonoBehaviour
{
    // To optmize performance, reducing draw calls is essential

    // Texture atlas: Combine multiple texctures into one, to minimize the number of textures bindings and draw calls
    // Optmize materials: Limite the number of materials and shaders used in your project. Shared materials are easier to batch together and reduce draw call overhead
    // Implement Lod: Decrease the complexituy of distant objects, reducing the number of draw calls for objects that are far from the camera
    // Apply culling techniques: Use frustum culling and occlusion culling to ensure that only objects that are visible are rendered, by not drawinf objects that are outside the cameras view or obscured by other geometry

    // SRP batching: enable the SRP batching to reduce the number of draw calls, in pipeline asset settings under advanced.
    // When using this, reduces the GPU setup between draw calls and makes material data persistent in GPU memory
    // THis can speed up CPU significantly
    // Use fewer shader variants with a minimal amount of keywords to improve SRP batching performance

    // GPU instancing: if you have a large number of identical objects, enable GPU instancing to reduce the number of draw calls
    // we can instaciate using Graphics.DrawMeshInstanced(Mesh, submeshIndex, material, Matrix4x4 List)
    // its more complex than simple using the function, but we have so much videos talking about this

    // Static batching: For non moving geometry, Unity can reduce draw calls for any mesh shraing the same material
    // Mark all meshes that never move as a Batching static in the inspector. on static property

    // acessing Render.Material duplicate the material, if you wish acess the batched objects material use Renderer.sharedMaterial


    // 1 mesh x 1 material = 1 draw call
    // 3 meshes x 1 material = 3 draw calls
    // 1 mesh x 2 materials = 2 draw calls
    // 3 meshes x 2 materials = 6 draw calls

    // So combine all meshs, and use the same material to reduce draw calls
}
