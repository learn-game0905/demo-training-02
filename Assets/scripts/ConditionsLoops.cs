using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConditionsLoops : MonoBehaviour
{
    static bool isGreater(int i, int j)
    {
        return i > j;                    
    }
    
    static bool isOdd(int i, int j , int x)
    {
        switch (x % 2)
        { 
            case 0:
                return true;
            case 1:
                return false;
            default:
                return false;
        }
    
        return false;
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
        
        /*var x = 2, y = 10;

        var result = x * 3 > y ? x : y > z? y : z;
        Debug.Log(result);*/
        
        // C# - Switch Statement
        /*int x = 10;

        switch (x)
        { 
            case 5:
                Debug.Log("Value of x is 5");
                break;
            case 10:
                Debug.Log("Value of x is 10");
                break;
            case 15:
                Debug.Log("Value of x is 15");
                break;
            default:
                Debug.Log("Unknown value");
                break;
        }*/
        
        /*int x = 125;

        switch (x % 2)
        { 
            case 0:
                Debug.Log($"{x} is an even value");
                break;
            case 1:
                Debug.Log($"{x} is an odd Value");
                break;
        }*/
        
        /*string statementType = "switch";

        switch (statementType)
        {
            case "if.else":
                Debug.Log("if...else statement");
                break;
            case "ternary":
                Debug.Log("Ternary operator");
                break;
            case "switch":
                Debug.Log("switch statement");
                break;
        }*/
        
        
        /*int x = 5;

        switch (x)
        { 
            case 1:
                Debug.Log("x = 1");
                break;
            case 2:
                Debug.Log("x = 2");
                break;
            case 4:
            case 5:
                Debug.Log("x = 4 or x = 5");
                break;
            default:
                Debug.Log("x > 5");
                break;
        }*/
        
        // int x = 125;
        // Debug.Log( isOdd(1,2,x)? "Even value" : "Odd value");
        
        /*int j = 5;

        switch (j)
        {
            case 5:
                Debug.Log(5);
                switch (j - 1)
                {
                    case 4:
                        Debug.Log(4);
                        switch (j - 2)
                        {
                            case 3:
                                Debug.Log(3);
                                break;
                        }
                        break;
                }
                break;
            case 10:
                Debug.Log(10);
                break;
            case 15:
                Debug.Log(15);
                break;
            default:
                Debug.Log(100);
                break;
        }*/
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
