using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class learncalss : MonoBehaviour
{
    public static class Calculator
    {
        private static int _resultStorage = 0;
    
        public static string Type = "Arithmetic";

        public static int Sum(int num1, int num2)
        {
            return num1 + num2;
        }

        public static void Store(int result)
        {
            _resultStorage = result;
        }
    }
    
    public class StopWatch
    {
        public static int InstanceCounter = 0;
        // static constructor
        static StopWatch()
        {
            Debug.Log("Static constructor called");
        }

        // instance constructor
        public StopWatch()
        {
            Debug.Log("Instance constructor called");
        }

        // static method
        public static void DisplayInfo()
        {
            Debug.Log("DisplayInfo called");
        }

        // instance method
        public void Start() { }

        // instance method
        public void Stop() {  }
    }
    
    static int counter = 0;
    string name = "Demo Program";
    
    static void Display(string text)
    {
        Debug.Log(text);
    }

    public void SetRootFolder(string path) {  }
    // Start is called before the first frame update
    void Start()
    {
        var result = Calculator.Sum(10, 25); 
        Calculator.Store(result); 

        var calcType = Calculator.Type; 
        Calculator.Type = "Scientific"; 
        
        StopWatch sw1 = new StopWatch();
        StopWatch sw2 = new StopWatch();
        // Console.WriteLine(StopWatch.NoOfInstances); 
			
        StopWatch sw3 = new StopWatch();
        StopWatch sw4 = new StopWatch();
        // Console.WriteLine(StopWatch.NoOfInstances);
        
        counter++; // can access static fields
        Display("Hello World!"); // can call static methods

        name = "New Demo Program"; //Error: cannot access non-static members
        SetRootFolder("C:\\MyProgram");
        
        StopWatch.DisplayInfo();
        StopWatch.DisplayInfo();
        
        StopWatch sw5 = new StopWatch(); // First static constructor and then instance constructor called 
        StopWatch sw6 = new StopWatch();// only instance constructor called 
        StopWatch.DisplayInfo();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
