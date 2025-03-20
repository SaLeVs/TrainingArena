using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.Networking;
using System;

public class WebRequestsTest : MonoBehaviour
{
    // Contact an external web server to download or upload any data
    [SerializeField] private TextMeshProUGUI textMeshPro;

    private void Start()
    {
        string url = "http://google.com:12345";
        Get(url, (string error) =>
        {
            Debug.LogError("Error: " + error);
            textMeshPro.SetText("Error: " + error);
        }, (string text) =>
        {
            Debug.Log("Success: " + text);
            textMeshPro.SetText(text);
        });
    }

    private void Get(string url, Action<string> onError, Action<string> onSuccess)
    {
        StartCoroutine(GetCoroutine(url, onError, onSuccess));
    }

    private IEnumerator GetCoroutine(string url, Action<string> onError, Action<string> onSuccess)
    {
        using (UnityWebRequest unityWebRequest = UnityWebRequest.Get(url)) // this using  statement will automatically dispose of the UnityWebRequest object when it's done
        {
            yield return unityWebRequest.SendWebRequest();
            if (unityWebRequest.result == UnityWebRequest.Result.ConnectionError ||
               unityWebRequest.result == UnityWebRequest.Result.DataProcessingError ||
               unityWebRequest.result == UnityWebRequest.Result.ProtocolError)
            {
                // Error
                onError(unityWebRequest.error);
            }
            else
            {
                // Success
                onSuccess(unityWebRequest.downloadHandler.text);
            }
        }
    }
}
