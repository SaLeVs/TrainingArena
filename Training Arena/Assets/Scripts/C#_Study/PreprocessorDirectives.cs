using Unity.VisualScripting;
using UnityEngine;



public class PreprocessorDirectives : MonoBehaviour
{
    #region Variables // the use of regions is for organization
    private int i;
    private int j;
    private int k;
    private int l;
    #endregion

    // Give the compiler instructions to be followed at compile time


    private void Start()
    {
    #if TEST // THIS IS NOT INCLUDED IN THE BUILD
         Debug.Log("Testing is defined");
    #endif

        // this can be useful for test debugs and delete all just remove the symbol
        /// In edit, Player Settings, Other Settings, Scripting Define Symbols we can define symbols and remove all debugs with this if for does not include on build
    }

}
