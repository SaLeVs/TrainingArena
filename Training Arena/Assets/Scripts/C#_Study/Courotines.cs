using System.Collections;
using UnityEngine;

public class Courotines : MonoBehaviour
{

    private void Start()
    {
        StartCoroutine(MyCourotine());
    }

    private IEnumerator MyCourotine()
    {
        Debug.Log("Before Yield");
        yield return new WaitForSeconds(3); // wait for 3 seconds
        yield return new WaitForEndOfFrame(); // wait for the end of the frame
        yield return new WaitForFixedUpdate(); // wait for the end of the fixed update

        Debug.Log("After Yield");
    }
}
