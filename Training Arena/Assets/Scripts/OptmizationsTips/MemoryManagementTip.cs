using UnityEngine;

public class MemoryManagementTip : MonoBehaviour
{
    // As inefficient memory management can lead to performance issues such as slow frame rate
    // Manage object lifeclycles, ever time you dont need more a object, destroy it and set references to null
    // Object pooling is a technique that consists of storing objects that are not being used in a pool, so that they can be reused later
    // we need to reduce garbage collection
    // avoid frequente allocations in updtade, use value types instead of reference types
    // Lazy loading: load assets only when they are needed
    // unload unused assets use Resources.unloadUnusedAssets() to free up memory occupied by assets that are no longer needed
    // use addresasble assets to load and unload assets
}
