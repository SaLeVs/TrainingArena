using UnityEngine;

public class ScriptableObjectsTip : MonoBehaviour
{
    // in general, scriptable objects are used to store data, but they can be used to store references to assets
    // we create a new script, and we inherit from ScriptableObject
    // we create all the variables that we want to store in the scriptable object
    // we add the attribute [CreateAssetMenu(fileName = "New Card", menuName = "Card")] to the class, for creating a new asset in the project
    // we create a new asset in the project by right-clicking in the project window, and selecting Create -> Card
    // after that, we need to display these info, so we create a normal script and put on UI that we want to display the info
    // On the script, we create a variable for reference to the scriptable object "public Card card;"
    // we can access the variables of the scriptable object by calling card.cardName, card.description, etc
    // In addition, scriptable objects are less memory-intensive
}
