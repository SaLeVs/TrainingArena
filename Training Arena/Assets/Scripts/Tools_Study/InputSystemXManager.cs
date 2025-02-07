using UnityEngine;
using UnityEngine.InputSystem;

public class InputSystemXManager : MonoBehaviour
{
    // Know the difference between Input Manager and System
    // Unity 6 use new input system by default
    // Its great to undestand the antique because some projects still use it

    private void Awake()
    {
        PlayerInputActions playerInputActions = new PlayerInputActions(); // for this work you need to enable and generate a C# files on assets
        playerInputActions.Enable();
        playerInputActions.Player.Shoot.performed += Shoot_performed;   

    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        { // 0 is left click, 1 is right click, 2 is middle click
            Debug.Log("Ding");
        }

        if (Input.GetKeyDown(KeyCode.Space)) // if you press space, it will print "Space"
        {
            Debug.Log("Space");
        }

        // Debug.Log(Input.GetAxisRaw("Horizontal")); // or Input.GetButton("Jump")
    }

    // you can use the axes for name the inputs

    private void Shoot_performed(InputAction.CallbackContext obj)
    {
        Debug.Log("Shoot");
    }

}
