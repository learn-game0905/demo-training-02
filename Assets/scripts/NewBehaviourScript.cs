using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public class Student
    {
        public int StudentID { get; set; }
        public string StudentName { get; set; }
        public int Age { get; set; }
        public string Address { get; set; }
    } // Start is called before the first frame update
    void Start()
    {
        Student std = new Student() { StudentID = 1, 
            StudentName = "Bill", 
            Age = 20, 
            Address = "New York"   
        };
        
        Student __student = new Student();
        __student.StudentID = 1;
        __student.StudentName = "Bill";
        __student.Age = 20;
        // __student.StandardID = 10;
        __student.Address = "Test";

        // Student std = __student;
        IList<Student> studentList = new List<Student>() { 
            new Student() { StudentID = 1, StudentName = "John"} ,
            new Student() { StudentID = 2, StudentName = "Steve"} ,
            new Student() { StudentID = 3, StudentName = "Bill"} ,
            new Student() { StudentID = 3, StudentName = "Bill"} ,
            new Student() { StudentID = 4, StudentName = "Ram" } ,
            new Student() { StudentID = 5, StudentName = "Ron" } ,
            null
        };
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
