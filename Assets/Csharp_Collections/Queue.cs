using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Queue : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // C# - Queue<T>
        
        /*Queue<int> callerIds = new Queue<int>();
        callerIds.Enqueue(1);
        callerIds.Enqueue(2);
        callerIds.Enqueue(3);
        callerIds.Enqueue(4);

        foreach(var id in callerIds)
            Debug.Log(id);*/
        
        /*Queue<string> strQ = new Queue<string>();
        strQ.Enqueue("H");
        strQ.Enqueue("e");
        strQ.Enqueue("l");
        strQ.Enqueue("l");
        strQ.Enqueue("o");

        Debug.Log("Total elements: {0}", strQ.Count);

        while (strQ.Count > 0)
            Debug.Log(strQ.Dequeue());

        Debug.Log("Total elements: {0}", strQ.Count);*/
        
        /*Queue<string> strQ = new Queue<string>();
        strQ.Enqueue("H");
        strQ.Enqueue("e");
        strQ.Enqueue("l");
        strQ.Enqueue("l");
        strQ.Enqueue("o");

        Debug.Log("Total elements: {0}", strQ.Count); 

        if(strQ.Count > 0){
            Debug.Log(strQ.Peek()); 
            Debug.Log(strQ.Peek()); 
        }

        Debug.Log("Total elements: {0}", strQ.Count);*/
        
        /*Queue<int> callerIds = new Queue<int>();
        callerIds.Enqueue(1);
        callerIds.Enqueue(2);
        callerIds.Enqueue(3);
        callerIds.Enqueue(4);

        callerIds.Contains(2); 
        callerIds.Contains(10);*/ 
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
