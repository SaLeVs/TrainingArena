using UnityEngine;

public class PhysicsOptmizationTip : MonoBehaviour
{
    // Simplify colliders
    // Mesh colliders can be expensive, so 100% accurate dont value over performance

    // Optimize your settings 
    // In the Player settings, check Prebake Collision Meshes to improve performance, this increase the distribution size of your game
    // Make sure that you edit your physics settings (project settings > physics) as well. Simplify your layer collisino Maxtrix wherever possible

    // Adjust simulation frequency
    // We can see this time on Edit > Project Settings > Time 
    // The fiexd Timestep field defines the time delta used by each physics step
    // the default value is 0.02, which is 50 times per second is equivalent to 50 fps or 50hz
    // Increase the fixed Timestep to slighty more than your target freame rate. For example, use 0.035 seconds for 30 fps on Mobile
    // and for 60 fps use 0.065 seconds

    // Decrease the maximium allowed TimeStep. Using a smaller value (like 0.1s) sacrifices some physiscs simulation accuracy
    // also limits how many physics steps many physics updates can happen in one frame
    // Simulate the physics step manually if necessary by choosing the SimulationMode during the Update phase of the frame
    // This allows you to take control when to run the physics step

    // Modify CookingOptions for MeshColliders
    // in the CookingOptions for each MeshCollider, simply uncheck the EnableMeshCleaning, WeldColocatedVertices and CookForFasterSimulation options

    // Use Physics.BakeMesh
    // If you are generating meshs procedurally during gameplay, you can create a MeshCollider at runtime
    // Use Physics.Bake mesh to prepare a mesh for use with a MeshCollider and save the baked data with the mesh itself
    // This can help reduce Scene Load time or instatiation time later
    // To optimize performance, you can offload mesh cooking to another thread with c# job sytem

    // Use Box prunning for large scenes
    // The broad phase default setting of Sweep and Prune BroadPhase (Edit > Project settings > physics > BroadPhase Type) can generate false positives for worlds that are generally flat and have many colliders
    // If your scene is large and mostly flat, avoid this issue and switch Automatic Box Prunning or Multibox Prunning BroadPhase

    // Disable automatic transform syncing
    // By default, Uinty does not sync transformations with the physics engine
    // Instead, it waits until the next physics update or until you manually call physics.SyncTransforms
    // When this is enable, any Rigidbody or Collider on that transform or its children automatically sync with the physics engine
    // Disable autoSyncTransforms unless necessary: Only enable it if precise, continuos syncing is crucial for your game meachanics
    // Use manual Syncing: For better performance, manually synchronize transforms with Physics.SyncTransforms() before calls that require the latest Transform data.

    // Use Contact Arrays
    // Contact arrays gives you a method where collision data (contacts) is stored and managed in an array format
    
}
