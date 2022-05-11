using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Operators : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int x = 5 + 5;
        int y = 10 + x;
        int z = x + y;
        
        string greet1 = "Hello " + "World!";
        
        Debug.Log(x++);
        Debug.Log(x--);
        Debug.Log(+x);
        Debug.Log(-x);
        Debug.Log(5 % 2);
        
        int a = 5 + 3 * 3;
        int b = 5 + 3 * 3 /  2; 
        int c = (5 + 3) * 3 /  2; 
        int d = (3 * 3) * (3 / 3 + 5);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
