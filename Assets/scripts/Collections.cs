using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collections : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // C# Arrays
        /*int[] evenNums;

        string[] cities;*/
        
        /*int[] evenNums = new int[5]{ 2, 4, 6, 8, 10 }; 

        string[] cities = new string[3]{ "Mumbai", "London", "New York" };*/
        
        /*var evenNums = new int[]{ 2, 4, 6, 8, 10}; 

        var cities = new string[]{ "Mumbai", "London", "New York" };*/
        
        /*int[] evenNums;

        evenNums = new int[5];
        
        evenNums = new int[]{ 2, 4, 6, 8, 10 };*/
        
        /*int[] evenNums = new int[5];
        evenNums[0] = 2;
        evenNums[1] = 4;

        Debug.Log(evenNums[0]);
        Debug.Log(evenNums[1]);*/
        
        /*int[] evenNums = { 2, 4, 6, 8, 10 };

        for(int i = 0; i < evenNums.Length; i++)
            Debug.Log(evenNums[i]);  

        for(int i = 0; i < evenNums.Length; i++)
            evenNums[i] = evenNums[i] + 10;*/
        
        /*int[] evenNums = { 2, 4, 6, 8, 10}; 
        string[] cities = { "Mumbai", "London", "New York" }; 

        foreach(var item in evenNums)
            Debug.Log(item);   

        foreach(var city in cities)
            Debug.Log(city);*/
        
        /*int[] nums = new int[5]{ 10, 15, 16, 8, 6 };

        nums.Max(); // returns 16
        nums.Min(); // returns 6
        nums.Sum(); // returns 55
        nums.Average(); // returns 55*/
        
        /*int[] nums = new int[5]{ 10, 15, 16, 8, 6 };

        Array.Sort(nums); // sorts array 
        Array.Reverse(nums); // sorts array in descending order
        Array.ForEach(nums, n => Debug.Log(n)); // iterates array
        Array.BinarySearch(nums, 5);// binary search*/ 
        
        /*int[] nums = { 1, 2, 3, 4, 5 };

        UpdateArray(nums); 

        foreach(var item in nums)
            Debug.Log(item);*/
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    public static void UpdateArray(int[] arr)
    {
        for(int i = 0; i < arr.Length; i++)
            arr[i] = arr[i] + 10;   
    }
    
}
