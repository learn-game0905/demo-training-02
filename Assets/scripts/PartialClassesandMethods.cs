using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PartialClassesandMethods : MonoBehaviour
{
    
    public class Employee
    {
        public int EmpId { get; set; }
        public string Name { get; set; }

        public Employee(int id, string name){
            this.EmpId = id;
            this.Name = name;
        }

        public void DisplayEmpInfo(){
            Debug.Log(this.EmpId + " " + this.Name );
        }
        
    }
    // Start is called before the first frame update
    void Start()
    {
        // var emp = new Employee();
        // Console.WriteLine(emp.EmpId); 

        // Console.ReadLine();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
