using UnityEngine;

public class AnimatorBlendTrees : MonoBehaviour
{
    // Blend multiple animations based on parameters great for handling separate animations per directions
    // the threshold is the value that the parameter needs to reach to activate the animation

    private Animator animator;

    private void Awake()
    {
        animator = GetComponent<Animator>();
    }

    private void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            animator.SetFloat("speed", 1, .1f, Time.deltaTime); // this is useful for interpolating the animations
        }
        else
        {
            animator.SetFloat("speed", 0, .1f, Time.deltaTime); // this number 0, can be controlled by a variable, if we want to create a speed parameter for control this we can do it
        }
    }

    // we normally we create a 2d simple directional blend tree for control the movement animations
    // we we need to create two parameters for control the movement, for example goVertical and goHorizontal
    // We normally create a vector 3, and get the values of vector 3 using the readvalue of vectors
    // After that we set parameters for the blend tree
    // we can set other belnd trees on parameters for blend trees, this can be useful for managing animations
}
