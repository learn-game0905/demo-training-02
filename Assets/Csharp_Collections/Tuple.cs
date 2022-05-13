using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tuple : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // C# - Tuple
        
        /*var person = Tuple.Create(1, "Steve", "Jobs");
        person.Item1; 
        person.Item2; 
        person.Item3; 


        var numbers = Tuple.Create("One", 2, 3, "Four", 5, "Six", 7, 8);
        numbers.Item1; 
        numbers.Item2; 
        numbers.Item3; 
        numbers.Item4; 
        numbers.Item5; 
        numbers.Item6; 
        numbers.Item7; 
        numbers.Rest; 
        numbers.Rest.Item1; */
        
        /*var numbers = Tuple.Create(1, 2, 3, 4, 5, 6, 7, Tuple.Create(8, 9, 10, 11, 12, 13));
        numbers.Item1; 
        numbers.Item7; 
        numbers.Rest.Item1;
        numbers.Rest.Item1.Item1;
        numbers.Rest.Item1.Item2;*/
        
        /*var numbers = Tuple.Create(1, 2, Tuple.Create(3, 4, 5, 6, 7,  8), 9, 10, 11, 12, 13 );
        numbers.Item1; 
        numbers.Item2; 
        numbers.Item3; 
        numbers.Item3.Item1; 
        numbers.Item4; 
        numbers.Rest.Item1;*/
        
        /*var person = Tuple.Create(1, "Steve", "Jobs");
        DisplayTuple(person);*/
        
        // var person = GetPerson();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    /*static Tuple<int, string, string> GetPerson() 
    {
        return Tuple.Create(1, "Bill", "Gates");
    }
    
    static void DisplayTuple(Tuple<int,string,string> person)
    {
        Debug.Log($"Id = { person.Item1}");
        Debug.Log($"First Name = { person.Item2}");
        Debug.Log($"Last Name = { person.Item3}");
    }*/
}
