using UnityEngine;

public class ShaderOptimizationTips : MonoBehaviour
{
    // Keep shaders simple and optimized

    // Minimize calculations
    // Simplify shaders by reducing the number of operations, especially in fragment shaders, where each pixel requires computation
    // avoid complex mathematical operations and heavy branching logic

    // Use combined textures
    // Utilize combined textures like occlusion, roughness and metallic (ORM) maps to reduce the number of texture lookups

    // Optmize shader graph
    // When using shader graph, focus on streamling shader logic to enhance performance

    // Profile regularly
    // Ever you add a new shader, profile it to ensure it's not causing performance issues

    // Minimize overdraw and alpha blending
    // Avoid drawing unnecessary transparent or semi-transparent images, and do not overlap barely visible objects or images

    // We can check this using RenderDoc or RenderingDebugger
}
