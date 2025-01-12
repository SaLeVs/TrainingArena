using UnityEngine;

public class Properties : MonoBehaviour
{
    // mix of a function and a variable

    private static string PlayerName { get; set; }

    private void Start()
    {
        PlayerName = "Code Monkey";
        Debug.Log(PlayerName);
    }


    // We can make changes on get or sert, like put rules or things like this
    // We can modify if get or set are private or public
}
