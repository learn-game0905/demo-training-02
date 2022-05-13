using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stack : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // C# - Stack<T>
        
        /*Stack<int> myStack = new Stack<int>();
        myStack.Push(1);
        myStack.Push(2);
        myStack.Push(3);
        myStack.Push(4);

        foreach (var item in myStack)
            Debug.Log(item + ",");*/
        
        /*int[] arr = new int[]{ 1, 2, 3, 4};
        Stack<int> myStack = new Stack<int>(arr);

        foreach (var item in myStack)
            Console.Write(item + ",");*/
        
        /*Stack<int> myStack = new Stack<int>();
        myStack.Push(1);
        myStack.Push(2);
        myStack.Push(3);
        myStack.Push(4);

        Console.Write("Number of elements in Stack: {0}", myStack.Count);

        while (myStack.Count > 0)
            Console.Write(myStack.Pop() + ",");

        Console.Write("Number of elements in Stack: {0}", myStack.Count);*/
        
        /*Stack<int> myStack = new Stack<int>();
        myStack.Push(1);
        myStack.Push(2);
        myStack.Push(3);
        myStack.Push(4);

        Console.Write("Number of elements in Stack: {0}", myStack.Count);

        if(myStack.Count > 0){
            Console.WriteLine(myStack.Peek()); 
            Console.WriteLine(myStack.Peek()); 
        }

        Console.Write("Number of elements in Stack: {0}", myStack.Count);*/
        
        /*Stack<int> myStack = new Stack<int>();
        myStack.Push(1);
        myStack.Push(2);
        myStack.Push(3);
        myStack.Push(4);

        myStack.Contains(2); 
        myStack.Contains(10);*/
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
