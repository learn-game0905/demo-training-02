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
        
        if (i != j)
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
            Debug.Log("i is equal to j");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
