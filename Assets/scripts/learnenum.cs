using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class learnenum : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        /*Console.WriteLine(WeekDays.Monday); // Monday
        Console.WriteLine(WeekDays.Tuesday); // Tuesday
        Console.WriteLine(WeekDays.Wednesday); // Wednesday
        Console.WriteLine(WeekDays.Thursday); // Thursday
        Console.WriteLine(WeekDays.Friday); // Friday
        Console.WriteLine(WeekDays.Saturday); // Saturday
        Console.WriteLine(WeekDays.Sunday); // Sunday*/
        
        int day = (int) WeekDays.Friday; // enum to int conversion
        // Console.WriteLine(day); //output: 4 
		
        var wd = (WeekDays) 5; // int to enum conversion
        // Console.WriteLine(wd);//output: Saturday 
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    enum WeekDays
    {
        Monday,     // 0
        Tuesday,    // 1
        Wednesday,  // 2
        Thursday,   // 3
        Friday,     // 4
        Saturday,   // 5
        Sunday      // 6
    }
    
    enum Categories: byte
    {
        Electronics = 1,  
        Food = 5, 
        Automotive = 6, 
        Arts = 10, 
        BeautyCare = 11, 
        Fashion = 15
    }
}
