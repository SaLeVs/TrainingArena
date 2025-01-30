using System.Threading;
using UnityEngine;

public class Multithreading : MonoBehaviour
{
    // Take advantage of all the cores in a cpu to run code insanely fast

    private void Start()
    {
        Thread workerThread = new Thread(new ThreadStart(CalculatePathFinding)); // here we are creating a new thread
        workerThread.Start(); // here we are starting the thread

        Debug.Log("Main thread is running");

        for (int i = 0; i < 10; i++) // this will run in the main thread and the function on CalculatePathFinding will run in the worker thread, but they will run at the same time
        {
            Debug.Log("Main thread work " + i);
            Thread.Sleep(500);
        }

        workerThread.Join(); // here we are waiting for the thread to be completed

        Debug.Log("Main thread2 is done");
    }

    private void CalculatePathFinding()
    {
        Debug.Log("Start path finding");
        for(int i = 0; i < 10; i++)
        {
            Debug.Log("Calculating path " + i);
            Thread.Sleep(600);
        }
        
        Debug.Log("End path finding");
    }

    // we cant create race conditions for the main thread and the worker thread because they are running in different threads
    // for control this we can create a lock, lock are divide by all threads, so if one thread is using the lock, the other threads will wait
    // Pay attetion on deadlocks, when one thread is waiting for another thread and the other thread is waiting for the first thread, so they will wait forever

}
