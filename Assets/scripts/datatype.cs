using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class datatype : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //DateTime dt = new DateTime(); // assigns default value 01/01/0001 00:00:00
        //
        //
        // DateTime dt1 = new DateTime();
        // DateTime dt2 = new DateTime(2015, 12, 31);
        // DateTime dt3 = new DateTime(2015, 12, 31, 5, 10, 20);
        // DateTime dt4 = new DateTime(2015, 12, 31, 5, 10, 20, DateTimeKind.Utc);
        //
        // DateTime dt5 = new DateTime(636370000000000000); 
        //
        // // DateTime.MinValue.Ticks;  //min value of ticks
        // // DateTime.MaxValue.Ticks; // max value of ticks
        //
        // DateTime currentDateTime = DateTime.Now;  //returns current date and time
        // DateTime todaysDate = DateTime.Today; // returns today's date
        // DateTime currentDateTimeUTC = DateTime.UtcNow;// returns current UTC date and time
        //
        // DateTime maxDateTimeValue = DateTime.MaxValue; // returns max value of DateTime
        // DateTime minDateTimeValue = DateTime.MinValue; // returns min value of DateTime
        //
        // static DateTime dt6 = new DateTime(2015, 12, 31);
        //
        // static TimeSpan ts = new TimeSpan(25,20,55);
        //
        // DateTime newDate = dt6.Add(ts);
        //
        // // Console.WriteLine(newDate);//1/1/2016 1:20:55 AM
        //
        // static DateTime dt111 = new DateTime(2015, 12, 31);
        // static DateTime dt222 = new DateTime(2016, 2, 2);
        // TimeSpan result = dt222.Subtract(dt111);//33.00:00:00
        
        /*DateTime dt1 = new DateTime(2015, 12, 20);
        DateTime dt2 = new DateTime(2016, 12, 31, 5, 10, 20); 
        TimeSpan time = new TimeSpan(10, 5, 25, 50);

        Console.WriteLine(dt2 + time); // 1/10/2017 10:36:10 AM
        Console.WriteLine(dt2 - dt1); //377.05:10:20
        Console.WriteLine(dt1 == dt2); //False
        Console.WriteLine(dt1 != dt2); //True
        Console.WriteLine(dt1 > dt2); //False
        Console.WriteLine(dt1 < dt2); //True
        Console.WriteLine(dt1 >= dt2); //False
        Console.WriteLine(dt1 <= dt2);//True*/
        
        /*var str = "5/12/2020";
        DateTime dt;
            
        var isValidDate = DateTime.TryParse(str, out dt);

            if(isValidDate)
            Console.WriteLine(dt);
            else
        Console.WriteLine($"{str} is not a valid date string");*/
        
        // data Struct
        Coordinate point = new Coordinate();
        // Console.WriteLine(point.x); //output: 0  
        // Console.WriteLine(point.y); //output: 0
        Coordinate1 point1 = new Coordinate1(10, 20);

        // Console.WriteLine(point.x); //output: 10  
        // Console.WriteLine(point.y); //output: 20 
        // Coordinate3 point3 = Coordinate3();
        // point3.SetOrigin();

        // Console.WriteLine(point.x); //output: 0  
        // Console.WriteLine(point.y); //output: 0  
        // Coordinate4 point4 = Coordinate.GetOrigin();

        // Console.WriteLine(point.x); //output: 0  
        // Console.WriteLine(point.y); //output: 0 
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    // static void StructEventHandler(int point)
    // {
    //     Console.WriteLine("Coordinate changed to {0}", point);
    // }
    
    struct Coordinate5
    {
        private int _x, _y;

        public int x 
        {
            get{
                return _x;
            }

            set{
                _x = value;
                // CoordinatesChanged(_x);
            }
        }

        public int y
        {
            get{
                return _y;
            }

            set{
                _y = value;
                // CoordinatesChanged(_y);
            }
        }

        // public event Action<int> CoordinatesChanged;
    }
    
    struct Coordinate4
    {
        public int x;
        public int y;

        public Coordinate4(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public static Coordinate GetOrigin()
        {
            return new Coordinate();
        }
    }
    
    struct Coordinate3
    {
        public int x { get; set; }
        public int y { get; set; }

        public void SetOrigin()
        {
            this.x = 0;
            this.y = 0;
        }
    }
    
    struct Coordinate1
    {
        public int x;
        public int y;

        public Coordinate1(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
    }
    
    struct Coordinate
    {
        public int x;
        public int y;
    }
}
