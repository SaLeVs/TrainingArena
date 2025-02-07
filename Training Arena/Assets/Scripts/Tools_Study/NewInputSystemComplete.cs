using System;
using UnityEngine;
using UnityEngine.InputSystem;

public class NewInputSystemComplete : MonoBehaviour
{
    // complete input system explanation
    // we have four types for send messages on the new input system


    private Rigidbody sphereRigidbody;
    private PlayerInput playerInput;

    private void Awake()
    {
        sphereRigidbody = GetComponent<Rigidbody>();
        playerInput = GetComponent<PlayerInput>();
        
        PlayerInputs playerInputs = new PlayerInputs(); // be default when you create, you need to enable it
        playerInputs.Player.Enable();
        playerInputs.Player.Jump.performed += Jump_performed; // perfomed, started and canceled can be used here
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

}
