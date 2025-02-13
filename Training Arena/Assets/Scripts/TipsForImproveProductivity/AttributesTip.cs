using UnityEngine;

[RequireComponent(typeof(Rigidbody))] // this requires the component to be added to the game object, basically, if you dont have the rigidbody component, it will add it automatically when start, and we cant remove these component of game object
[SelectionBase] // this makes the game object to be selected by clicking on the game object instead of children, just to be better for selection
public class AttributesTip : MonoBehaviour
{
    private Rigidbody rb; // this is a reference to the rigidbody component    
    [SerializeField] private GameObject myGameObject;   // this allows us to see the private field in the inspector
    [Range(0, 100)] public int myInt;                   // this allows us to set a range for the int value
    [HideInInspector] public int p = 5;                  // this hides the field in the inspector, just to organize the inspector view
    [Space(10)] // this creates a space in the inspector, just a visual change
    [Tooltip("This is a tooltip overview")] public int health; // this allows us to add a tooltip to the field in the inspector                         
    [Space(50)]
    [Multiline] public string textToEdit;
    [Multiline(20)] public string moreTextToEdit; 


    private void Start()
    {
        rb = GetComponent<Rigidbody>(); // this gets the rigidbody component                  
    }
}
