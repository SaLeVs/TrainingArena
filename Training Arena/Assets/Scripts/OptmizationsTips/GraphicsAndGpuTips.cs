using UnityEngine;

public class GraphicsAndGpuTips : MonoBehaviour
{
    // If we are making mobile games, normally use the foward rendering path
    // We have so much differences between the two and deferred
    // In documentaion we have more details

    // GFXbench is a good tool to test the performance of the gpus 

    // Glossary:
    // fps: frames per second
    // CPU Main: Total time to process one frame (and update the editor for all windows
    // Cpu render thread: total time to render one frame of the game view
    // Batches: groups of draw calls to be drawn together
    // tris (triangles) and verts (vertices): Mesh geometry complexity
    // SetPass calls: number of times the Unity must switch shader passes to render the gameObjects OnScreen
    // this data show on stats button, on game view
}
