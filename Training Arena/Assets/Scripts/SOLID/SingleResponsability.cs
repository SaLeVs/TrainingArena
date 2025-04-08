using UnityEngine;

public class SingleResponsability : MonoBehaviour
{
    // Interesting that we use the single responsability create a class that commands all, and others class dont comunicate with each other
    // For example, we have a class for get the input values and other for do the movement based on the input values
    // And what we make? we expose the input values like a property, and the class that commands all get this values and pass for the movement class
    // So, the movement class and input class doesnt know that each other exist
}
