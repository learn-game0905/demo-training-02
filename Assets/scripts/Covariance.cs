using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Covariance : MonoBehaviour
{
    public class Small
    { 

    }
    public class Big: Small
    {

    }
    public class Bigger : Big
    { 
    
    }
    
    public delegate Small covarDel(Big mc);
    
    public static Big Method1(Big bg)
    {
        Debug.Log("Method1");
    
        return new Big();
    }
    public static Small Method2(Big bg)
    {
        Debug.Log("Method2");
    
        return new Small();
    }
    // Start is called before the first frame update
    void Start()
    {
        covarDel del = Method1;

        Small sm1 = del(new Big());

        del= Method2;
        Small sm2 = del(new Big());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
