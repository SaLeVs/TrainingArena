using UnityEngine;

public class ReduceGcTip : MonoBehaviour
{
    // in c# strings are reference types not value types
    // Reduce the use of strings creation or manipulation
    // avoid use json and xml, prefer store data on scriptable objects
    // use string build class if you need to build strings at runtime

    // Unity functions call, some functions create heap allocations
    // For example, use Gameobject.CompareTag instead of Gameobject.tag == "Player"

    // Boxing, avoid passing a value-type variable in place of a reference-typed variable
    // try to provide concrete overrides with the value type you want to pass in

    // Courotines, Though yield does not produce garbage, creating a new WaitForSeconds object does
    // Cache and reuse WaitForSeconds objects objects rather than creating it in the yield line
}
