using UnityEngine;

public class AnimationOptimizationTips : MonoBehaviour
{
    // Use generic rig rather than humanoid rig
    // Generic rigs are more efficient than humanoid rigs, as they have fewer bones and constraints
    // When importing humanoid animation, use an avatarMask to remove IK Goals or finger animations dont use root motion

    // Use alternatives for simple animation
    // Avoid overusing animators, particularty with UI elements, since they come with extra overhead
    // Create easing functions or use a third party tweening library where possible (e.g DOTWeen)

    // Avoid scale curves
    // Animating scale curves is more expensive than animating translation or rotation curves
    // This does not apply to constant curves (curvess that have the same value for the lenght of the animation clips)

    // Update only when visible
    // Set the animator´s culling mode to Based on Renderes and disable skinned mesh renderes Update When Offscreen property

    // Optimize workflow
    // Use hashes instead of strings to query the animator
    // implement a small AI layer to control the animator, you can make it provide simple callbacks for OnStateChange, OnTrasitionBegin and other events
    // Use State Tags to easily match your AI state machine to the Unity state machines
    // Use additional curves to simulate events
    // Use additional curves to mark up your animations, for example in conjunction with target machine

    // Separete animating hierachies
    // Ensure that animating hierachies do not share a commom parent (unless that parent is the root of the scene)
    // For example, if we have a big father, all children will recalculate when father moves, so each animation must be have a father 

    // Minimize binding costs
    // Be aware of the high costs associated with binding operations in the animation system
    // Avoid frequently adding clips, adding or removing GameObjects and components and enablind or disabling objects during runtime
    // Which generally require rebinding
    // All of theses operations are computationally expensive

    // Avoid using component-based constraints on deep hierarchies
    // Such as characters with complex structures with complex structures as this can result in poor performance

    // Consider performance implicatinos of animation rigging
    // Whenever possible, utilize the build-in IK (inverse kinematics) pass in the Humanoid rig to improve performance

}
