using System.Collections.Generic;
using UnityEngine;

public class OtherCollections : MonoBehaviour
{
    // Stack, Queue, HashSet

    private void Start()
    {
        Stack();
        Queue();
        HashSet();
    }


    private static void HashSet()
    {
        HashSet<string> stringHashSet = new HashSet<string>();

        stringHashSet.Add("Code Monkey"); // all elements are unique, so if you try to add the same element, it will not be added, 
        stringHashSet.Add("Code Monkey");
        Debug.Log(stringHashSet.Count); // this will print 1

        stringHashSet.Add("Iron Man");
        Debug.Log(stringHashSet.Count); // this will print 2    
        stringHashSet.Remove("Iron Man");

        Debug.Log(stringHashSet.Count); // this will print 1

        // we can use HashSet to check if a element is unique or not
    }

    private void Stack()
    {
        // Think like stack a papers, we can place a paper on top of the stack or remove the top paper
        // First In Last Out (FILO)

        Stack<string> nameStack = new Stack<string>();

        nameStack.Push("Code Monkey");
        nameStack.Push("IronMan");
        nameStack.Push("Spider-Man");

        Debug.Log(nameStack.Pop()); // can use like this, but if you dont have certain if have any on stack, you can use TryPop
        Debug.Log(nameStack.TryPop(out string tryPopResult) + ": " + tryPopResult); // TryPop returns bool, if stack is empty, it returns false, but if contains, it returns true and assigns the value to the variable
    }

    private void Queue()
    {
        // Think in queue of people, first in first out (FIFO)

        Queue<string> stringQueue = new Queue<string>();

        stringQueue.Enqueue("Code Monkey");
        stringQueue.Enqueue("IronMan");
        stringQueue.Enqueue("Spider-Man");

        Debug.Log(stringQueue.Dequeue()); // can use like this, but if you dont have certain if have any on queue, you can use TryDequeue. This removes the first element of the queue
        Debug.Log(stringQueue.TryDequeue(out string tryDequeueResult) + ": " + tryDequeueResult); // TryDequeue returns bool, if queue is empty, it returns false, but if contains, it returns true and assigns the value to the variable
    }

}
