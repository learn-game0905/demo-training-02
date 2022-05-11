using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

public class learnstring : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StringBuilder sb = new StringBuilder("Hello World!", 50);

        for (int i = 0; i < sb.Length; i++)
        {
            Debug.Log(sb[i]);
        }
        
        var greet = sb.ToString();
        sb.Append("Hello ");
        sb.AppendLine("World!");
        sb.AppendLine("Hello C#");
        Debug.Log(sb);
        sb.Insert(5," C#");
        Debug.Log(sb);
        sb.Remove(6, 7);
        Debug.Log(sb);
        sb.Replace("World", "C#");
        Debug.Log(sb);

        StringBuilder sbAmout = new StringBuilder("Your total amount is ");
        sbAmout.AppendFormat("{0:C} ", 25);
        Debug.Log(sbAmout);
        
        // Anonymous Type
        var student = new { 
            Id = 1, 
            FirstName = "James", 
            LastName = "Bond",
            Address = new { Id = 1, City = "London", Country = "UK" }
        };
        Debug.Log(student.GetType().ToString());
        Debug.Log(student.Id);
        Debug.Log(student.FirstName);
        Debug.Log(student.LastName);
        
        var students = new[] {
            new { Id = 1, FirstName = "James", LastName = "Bond" },
            new { Id = 2, FirstName = "Steve", LastName = "Jobs" },
            new { Id = 3, FirstName = "Bill", LastName = "Gates" }
        };
        
        IList<Student> studentList = new List<Student>() { 
            new Student() { StudentID = 1, StudentName = "John", age = 18 },
            new Student() { StudentID = 2, StudentName = "Steve",  age = 21 },
            new Student() { StudentID = 3, StudentName = "Bill",  age = 18 },
            new Student() { StudentID = 4, StudentName = "Ram" , age = 20  },
            new Student() { StudentID = 5, StudentName = "Ron" , age = 21 } 
        };

        /*var studentss = from s in studentList
            select new { Id = s.StudentID, Name = s.StudentName };
        
        foreach(var stud in students)
            Console.WriteLine(stud.Id + "-" + stud.Name);*/
        
        // Dynamic Types
        /*dynamic MyDynamicVar = 100;
        Debug.Log("Value: {0}, Type: {1}", MyDynamicVar, MyDynamicVar.GetType());

        MyDynamicVar = "Hello World!!";
        Debug.Log("Value: {0}, Type: {1}", MyDynamicVar, MyDynamicVar.GetType());

        MyDynamicVar = true;
        Debug.Log("Value: {0}, Type: {1}", MyDynamicVar, MyDynamicVar.GetType());

        MyDynamicVar = DateTime.Now;
        Debug.Log("Value: {0}, Type: {1}", MyDynamicVar, MyDynamicVar.GetType());*/
        dynamic d1 = 100;
        // int i = d1;
		
        d1 = "Hello";
        // string greet = d1;
		
        d1 = DateTime.Now;
        DateTime dt = d1;
        
        // Nullable Types
        Nullable<int> i2 = null;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    public class Student
    {
        public int StudentID { get; set; }
        public string StudentName { get; set; }
        public int age { get; set; }
        
        public void DisplayStudentInfo(int id)
        {
        }
    }
    
}
