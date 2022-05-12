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
        
        // C# - Multidimensional Arrays
        /*int[,] arr2d; // two-dimensional array
        int[, ,] arr3d; // three-dimensional array
        int[, , ,] arr4d ; // four-dimensional array
        int[, , , ,] arr5d; // five-dimensional array*/
        
        /*int[,] arr2d = new int[3,2]{ 
            {1, 2}, 
            {3, 4}, 
            {5, 6} 
        };
        
        int[,] arr2d = { 
            {1, 2}, 
            {3, 4}, 
            {5, 6} 
        };*/
        
        /*int[,] arr2d = new int[3,2]{ 
            {1, 2}, 
            {3, 4}, 
            {5, 6} 
        };*/

        /*arr2d[0, 0]; //returns 1
        arr2d[0, 1]; //returns 2
        arr2d[1, 0]; //returns 3
        arr2d[1, 1]; //returns 4
        arr2d[2, 0]; //returns 5
        arr2d[2, 1]; //returns 6*/
        
        
        /*int[, ,] arr3d1 = new int[1, 2, 2]{
            { { 1, 2}, { 3, 4} }
        };

        int[, ,] arr3d2 = new int[2, 2, 2]{
            { {1, 2}, {3, 4} },
            { {5, 6}, {7, 8} }
        };

        int[, ,] arr3d3 = new int[2, 2, 3]{
            { { 1, 2, 3}, {4, 5, 6} },
            { { 7, 8, 9}, {10, 11, 12} }
        };

        arr3d2[0, 0, 0]; // returns 1 
        arr3d2[0, 0, 1]; // returns 2 
        arr3d2[0, 1, 0]; // returns 3 
        arr3d2[0, 1, 1]; // returns 4 
        arr3d2[1, 0, 0]; // returns 5 
        arr3d2[1, 0, 1]; // returns 6 
        arr3d2[1, 1, 0]; // returns 7 
        arr3d2[1, 1, 1]; // returns 8*/
        
        /*int[,,,] arr4d1 = new int[1, 1, 2, 2]{
            { 
                { { 1, 2}, { 3, 4} }     
            }
        };

        arr4d1[0, 0, 0, 0]; // returns 1
        arr4d1[0, 0, 0, 1]; // returns 2
        arr4d1[0, 0, 1, 0]; // returns 3
        arr4d1[0, 0, 1, 1]; // returns 4

        int[,,,] arr4d2 = new int[1, 2, 2, 2]{
            {
                { {1, 2}, {3, 4} },
                { {5, 6}, {7, 8} }
            }
        };

        arr4d2[0, 0, 0, 0]; // returns 1
        arr4d2[0, 0, 0, 1]; // returns 2
        arr4d2[0, 0, 1, 0]; // returns 3
        arr4d2[0, 0, 1, 1]; // returns 4
        arr4d2[0, 1, 0, 0]; // returns 5
        arr4d2[0, 1, 0, 1]; // returns 6
        arr4d2[0, 1, 1, 0]; // returns 7
        arr4d2[0, 1, 1, 1]; // returns 8*/
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
