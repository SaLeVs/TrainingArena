using UnityEngine;

public class LightsTip : MonoBehaviour
{
    // Avoid too many dynamic lights
    // bake lights, light probes can be more useful

    // Disable shadows
    // Shadows casting can be disabled per meshRenderer and light
    // We can create shadows using a blurred texture

    // Bake your lights into lightmaps
    // marking a object with static, and mark contribute Gi, for store in high quality

    // GPU ligh baking its designed to dramatically accelerate lightning data generation by leveraging the power of the GPU, offering faster...
    // bake time compared to traditional CPU lightmapping

    // On lighting, setings, we can change the lightmapper for GPU lightmapper or CPU lightmapper
}
