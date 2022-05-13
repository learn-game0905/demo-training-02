using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dictionary : MonoBehaviour
{
    // Start is called before the first fra
    void Start()
    {
        // C# - Dictionary<TKey, TValue>
        
        /*IDictionary<int, string> numberNames = new Dictionary<int, string>();
        numberNames.Add(1,"One");
        numberNames.Add(2,"Two");
        numberNames.Add(3,"Three");


        foreach(KeyValuePair<int, string> kvp in numberNames)
            Debug.Log("Key: {0}, Value: {1}", kvp.Key, kvp.Value);
		
        var cities = new Dictionary<string, string>(){
            {"UK", "London, Manchester, Birmingham"},
            {"USA", "Chicago, New York, Washington"},
            {"India", "Mumbai, New Delhi, Pune"}
        };
		
        foreach(var kvp in cities)
            Debug.Log("Key: {0}, Value: {1}", kvp.Key, kvp.Value);*/
        
        /*var cities = new Dictionary<string, string>(){
            {"UK", "London, Manchester, Birmingham"},
            {"USA", "Chicago, New York, Washington"},
            {"India", "Mumbai, New Delhi, Pune"}
        };

        Debug.Log(cities["UK"]); //prints value of UK key
        Debug.Log(cities["USA"]);//prints value of USA key

        if(cities.ContainsKey("France")){  
            Debug.Log(cities["France"]);
        }

        string result;

        if(cities.TryGetValue("France", out result))
        {
            Debug.Log(result);
        }

        for (int i = 0; i < cities.Count; i++)
        {
            Debug.Log("Key: {0}, Value: {1}", 
                cities.ElementAt(i).Key, 
                cities.ElementAt(i).Value);
        }*/
        
        /*var cities = new Dictionary<string, string>(){
            {"UK", "London, Manchester, Birmingham"},
            {"USA", "Chicago, New York, Washington"},
            {"India", "Mumbai, New Delhi, Pune"}
        };

        cities["UK"] = "Liverpool, Bristol"; 
        cities["USA"] = "Los Angeles, Boston"; 

        if(cities.ContainsKey("France")){
            cities["France"] = "Paris";
        }*/
        
        /*var cities = new Dictionary<string, string>(){
            {"UK", "London, Manchester, Birmingham"},
            {"USA", "Chicago, New York, Washington"},
            {"India", "Mumbai, New Delhi, Pune"}
        };

        cities.Remove("UK"); 

        if(cities.ContainsKey("France")){ 
            cities.Remove("France");
        }

        cities.Clear();*/
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
