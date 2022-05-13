using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ValueTuple : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // C# - ValueTuple
        
        /*ValueTuple<int, string, string> person = (1, "Bill", "Gates");
        person.Item1;  
        person.Item2;   
        person.Item3;   */
        
        /*(int, string, string) person = (1, "James", "Bond");
        person.Item1;  
        person.Item2;   
        person.Item3;*/
        
        /*var numbers = (1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14);
         var person = (Id:1, FirstName:"Bill", LastName: "Gates");
        (int Id, string FirstName, string LastName) person = (1, "Bill", "Gates");
        person.Id;   
        person.FirstName;  
        person.LastName; */
        
        /*(int Id, string FirstName, string LastName) person = (PersonId:1, FName:"Bill", LName: "Gates");

        (string, string, int) person = (PersonId:1, FName:"Bill", LName: "Gates");*/
        
        /*string firstName = "Bill", lastName = "Gates";
        var per = (FirstName: firstName, LastName: lastName);
        
        DisplayTuple((1, "Bill", "Gates"));
        
        var person = GetPerson();
        Console.WriteLine("{0}, {1}, {2}", person.Item1, person.Item2, person.Item3);
        
        var person = GetPerson();
        Console.WriteLine("{0}, {1}, {2}", person.Id, person.FirstName, person.LastName);*/
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    /*static void DisplayTuple((int, string, string) person)
    {
        Console.WriteLine("{0}, {1}, {2}", person.Item1, person.Item2, person.Item3);
    }
    
    static (int, string, string) GetPerson() 
    {
        return (1, "Bill", "Gates");
    }
    
    static (int Id, string FirstName, string LastName) GetPerson() 
    {
        return (Id:1, FirstName: "Bill", LastName: "Gates");
    }*/
    
}
