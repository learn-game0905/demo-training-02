using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hello : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        string message = "Hello World!!";

        Debug.Log(message);

        MyClass newClass = new MyClass();
        Debug.Log(newClass.MyMethod("mes1" , "mes 2"));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

public class MyClass
{
    public string myField = string.Empty;

    public MyClass()
    {
    }

    public string MyMethod(string parameter1, string parameter2)
    {
        return "First Parameter " + parameter1 + ", second parameter " + parameter2;
    }

    public int MyAutoImplementedProperty { get; set; }

    private int myPropertyVar;

    public int MyProperty
    {
        get { return myPropertyVar; }
        set { myPropertyVar = value; }
    }
}
