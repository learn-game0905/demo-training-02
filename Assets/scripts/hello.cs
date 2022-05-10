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

        int num;
        num = 100;
        num = 200;
        int i, j = 10, k = 100;
        int a = 0,
            b = 10,
            c = 100;
        int e = 100;

        int h = e;
        h = 10 + 10;
        var chuoi = "khai bao dong";
        var m = 999;
        float rate = 10.2f;
        decimal amount = 100.50M;
        char code = 'C';
        bool isValid = true;
        string name = "Steve";

        MyClass newClass = new MyClass();
        Debug.Log(newClass.MyMethod("mes1", "mes 2"));
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
