using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.Networking;

public class WebRequestsTest : MonoBehaviour
{
    // Contact an external web server to download or upload any data
    [SerializeField] private TextMeshProUGUI textMeshPro;

    private void Start()
    {
        string url = "http://google.com";
        StartCoroutine(Get(url));
    }

    private IEnumerator Get(string url)
    {
        using (UnityWebRequest unityWebRequest = UnityWebRequest.Get(url)) // this using  statement will automatically dispose of the UnityWebRequest object when it's done
        {
            yield return unityWebRequest.SendWebRequest();
            if (unityWebRequest.result == UnityWebRequest.Result.ConnectionError ||
               unityWebRequest.result == UnityWebRequest.Result.DataProcessingError ||
               unityWebRequest.result == UnityWebRequest.Result.ProtocolError)
            {
                // Error
                Debug.Log("Error: " + unityWebRequest.error);
                textMeshPro.SetText("Error: " + unityWebRequest.error);
                // onError(unityWebRequest.error);
            }
            else
            {
                // Success
                Debug.Log("Received: " + unityWebRequest.downloadHandler.text);
                textMeshPro.text = unityWebRequest.downloadHandler.text;
                // onSuccess(unityWebRequest.downloadHandler.text);
            }
        }
    }
}
