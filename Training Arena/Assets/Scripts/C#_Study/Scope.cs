using UnityEngine;

public class Scope : MonoBehaviour
{
    /*
     Defines the acessibility/lifetime of some elements like variables 

      
     */

    private void Start()
    {
        int x = 10;

    }

    private void Update()
    {
      //  x = ?; we cant acess x here, because x is a local variable
    }
}
