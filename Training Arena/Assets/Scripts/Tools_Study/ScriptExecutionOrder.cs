using UnityEngine;

public class ScriptExecutionOrder : MonoBehaviour
{
    // Define the order that scripts are run

    public static ScriptExecutionOrder Instance { get; private set; }
    private void Awake()
    {
        Instance = this;
    }

    public void TestFunctino()
    {
        Debug.Log("Test Function");
    }

    // in edit - > project settings -> script execution order, you can change the order that the scripts are run
    // if you have a tow scripts that use awake, you can change the order that they are run
    // but tou can also initialize on awake and acess on start

}
