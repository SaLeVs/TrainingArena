using System;
using UnityEngine;
using UnityEngine.InputSystem;

public class NewInputSystemComplete : MonoBehaviour
{
    // complete input system explanation
    // we have four types for send messages on the new input system


    private Rigidbody sphereRigidbody;
    private PlayerInput playerInput;
    private PlayerInputs playerInputs;

    private void Awake()
    {
        sphereRigidbody = GetComponent<Rigidbody>();
        playerInput = GetComponent<PlayerInput>();
        
        PlayerInputs playerInputs = new PlayerInputs(); // be default when you create, you need to enable it
        playerInputs.Player.Enable();
        playerInputs.Player.Jump.performed += Jump_performed; // perfomed, started and canceled can be used here
        playerInputs.Player.Movement.performed += Movement_performed; // Here we are reading values
    }

    private void Movement_performed(InputAction.CallbackContext context)
    {
        Vector2 inputVector = context.ReadValue<Vector2>();
        float speed = 50f;
        sphereRigidbody.AddForce(new Vector3(inputVector.x, 0, inputVector.y) * speed, ForceMode.Force);
    }

    private void Jump_performed(InputAction.CallbackContext context)
    {
        Debug.Log("Jump on performed");
        sphereRigidbody.AddForce(Vector3.up * 5f, ForceMode.Impulse);
    }

    public void Jump()
    {
        Debug.Log("Jump");
        sphereRigidbody.AddForce(Vector3.up * 5f, ForceMode.Impulse);
    }

    //public void Jump(InputAction.CallbackContext context) // 
    //{
    //    Debug.Log("Jump");
    //    sphereRigidbody.AddForce(Vector3.up * 5f, ForceMode.Impulse);
    //}

    // we have a mehthod of csharp events but is bad
    // buttons for hold are very easy to use
    // we have to generate a C# file for the input system, its the best method
    // If you generate a c# file, dont use the autosave, beacause everthyng that you change will recompile unity
    // Control scheme is a way to group inputs, can be useful for organize the inputs
    // for listen the buttons with a controler, you need to play the game in the editor, close and now its working
    // and making the use of scheme, we can only do one script for all inputs

    // deadzone can be useful, you can find on processors
    // normalize is for when you need so much precision

    // Pass through is useful for if for some reason you want read input from every device at once
    // SwitchCurrentActionMap is useful for change the current action map, for example, if you need to control the car, not the player
    // we can change the bind on the current game using performInteractiveRebinding
}
