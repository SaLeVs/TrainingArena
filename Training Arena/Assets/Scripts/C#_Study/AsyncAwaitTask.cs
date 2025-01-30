using System.Threading.Tasks;
using UnityEngine;

public class AsyncAwaitTask : MonoBehaviour
{
    // Asyncronous programming, run logic without blocking the main thread

    private static string serverReturnData;

    private async void Start()
    {
        //Task task = ContactWebSever();

        //if (task.IsCompleted)
        //{
        //    int dataLength = serverReturnData.Length;
        //    Debug.Log(dataLength);
        //}

        await CookEggs(); // here we are call the function and wait for the return
        await CookBacon();
        await CookToast();

        Task eggsTask = CookEggs(); // here function will call always at same time
        Task baconTask = CookBacon();
        Task toastTask = CookToast();

        await Task.WhenAll(eggsTask, baconTask, toastTask); // here we are waiting for all the task to be completed
        Debug.Log("Breakfast done");

        Debug.Log(serverReturnData);
    }

    public static async Task ContactWebSever()
    {
        Debug.Log("Contacting Web Server");
        await Task.Delay(3000);
        Debug.Log("Got response");
        serverReturnData = "Data";
        Debug.Log("Got response");
    }

    public static async Task CookEggs()
    {
        Debug.Log("Cooking Eggs");
        await Task.Delay(3000);
        Debug.Log("Eggs are ready");
    }

    public static async Task CookBacon()
    {
        Debug.Log("Cooking bacon");
        await Task.Delay(4000);
        Debug.Log("Bacon are ready");
    }

    public static async Task CookToast()
    {
        Debug.Log("Cooking toast");
        await Task.Delay(1000);
        Debug.Log("Toast are ready");
    }

}
