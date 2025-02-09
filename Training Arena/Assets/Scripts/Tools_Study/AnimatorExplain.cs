using UnityEngine;

public class AnimatorExplain : MonoBehaviour
{
    // Easily manage all your animations and their logic
    // We can create a animation on project folder, but you need to put in animator window

    private Animator animator;
    private int goVerticalParameter;
    private int playFrontBackParameter;

    private void Awake()
    {
        animator = GetComponent<Animator>();
        goVerticalParameter = Animator.StringToHash("goVertical"); // making these avoid using strings and cause more carbage
        playFrontBackParameter = Animator.StringToHash("playFrontBack");
    }

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            animator.SetBool(goVerticalParameter, true);
        }

        if (Input.GetKeyDown(KeyCode.T))
        {
            animator.SetBool(goVerticalParameter, false);
        }

        if (Input.GetKeyDown(KeyCode.F))
        {
            animator.SetTrigger(playFrontBackParameter);
        }
        // animator.Play("AnimationName"); this can be useful for play a specific animation
        // we can make a transition for itself
        // layers are so much useful for control animations with characters and mix animations and controll each part of character
        // we can override animation controller for avoid make all controller again for same objects, for example enemys
        // update mode is for control the animation in the same time of the script, and fix time is for control the animation in the same time of the game
        // culling mode is for control the animation when the object is not in the camera
    }
}
