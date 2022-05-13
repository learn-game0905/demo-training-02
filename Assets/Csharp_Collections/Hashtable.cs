using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hashtable : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // C# - Hashtable
        
        /*Hashtable numberNames = new Hashtable();
        numberNames.Add(1,"One"); 
        numberNames.Add(2,"Two");
        numberNames.Add(3,"Three");


        foreach(DictionaryEntry de in numberNames)
            Debug.Log("Key: {0}, Value: {1}", de.Key, de.Value);
		
        var cities = new Hashtable(){
            {"UK", "London, Manchester, Birmingham"},
            {"USA", "Chicago, New York, Washington"},
            {"India", "Mumbai, New Delhi, Pune"}
        };
		
        foreach(DictionaryEntry de in cities)
            Debug.Log("Key: {0}, Value: {1}", de.Key, de.Value);*/
        
        /*Dictionary<int, string> dict = new Dictionary<int, string>();
        dict.Add(1, "one");
        dict.Add(2, "two");
        dict.Add(3, "three");

        Hashtable ht = new Hashtable(dict);*/
        
        /*var cities = new Hashtable(){
            {"UK", "London, Manchester, Birmingham"},
            {"USA", "Chicago, New York, Washington"},
            {"India", "Mumbai, New Delhi, Pune"}
        };
    
        string citiesOfUK = (string) cities["UK"]; 
        string citiesOfUSA = (string) cities["USA"]; 

        Debug.Log(citiesOfUK);
        Debug.Log(citiesOfUSA);

        cities["UK"] = "Liverpool, Bristol"; 
        cities["USA"] = "Los Angeles, Boston"; 

        if(!cities.ContainsKey("France")){
            cities["France"] = "Paris";
        }*/
        
        /*var cities = new Hashtable(){
            {"UK", "London, Manchester, Birmingham"},
            {"USA", "Chicago, New York, Washington"},
            {"India", "Mumbai, New Delhi, Pune"}
        };

        cities.Remove("UK"); 

        if(cities.ContainsKey("France")){
            cities.Remove("France");
        }

        cities.Clear(); */
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
