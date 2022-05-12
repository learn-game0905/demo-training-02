using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConditionsLoops : MonoBehaviour
{
    static bool isGreater(int i, int j)
    {
        return i > j;                    
    }
    // Start is called before the first frame update
    void Start()
    {
        int i = 10, j = 20;

        /*if (i < j)
        {
            Debug.Log("i is less than j");
        }        

        if (isGreater(i,j))
        {
            Debug.Log("i is greater than j");
        }*/
        
        /*if (i == j)
        {
            Debug.Log("i is equal to j");
        }
        else if (i > j)
        {
            Debug.Log("i is greater than j");
        }
        else if (i < j)
        {
            Debug.Log("i is less than j");
        }*/
        
        /*if (i > j)
        {
            Debug.Log("i is greater than j");
        }
        else if (i < j)
        {
            Debug.Log("i is less than j");
        }
        else
        {
            Debug.Log("i is equal to j");
        }*/
        
        /*if (i != j)
        {
            if (i < j)
            {
                Debug.Log("i is less than j");
            }
            else if (i > j)
            {
                Debug.Log("i is greater than j");
            }
        }
        else
            Debug.Log("i is equal to j");*/
        
        // C# - Ternary Operator ?:
        /*int x = 20, y = 10;

        var result = x > y ? "x is greater than y" : "x is less than y";

        Debug.Log(result);
        
        int x = 10, y = 100;

        if (x > y)
            Debug.Log("x is greater than y");
        else
            Debug.Log("x is less than y");*/
        
        /*int x = 10, y = 100;

        string result = x > y ? "x is greater than y" : 
            x < y ? "x is less than y" : 
            x == y ? "x is equal to y" : "No result";

        Debug.Log(result);*/
        
        var x = 2, y = 10;

        var result = x * 3 > y ? x : y > z? y : z;
        Debug.Log(result);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
