

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

        nums.Max(); 
        nums.Min(); 
        nums.Sum(); 
        nums.Average(); 
        
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

        /*arr2d[0, 0];
        arr2d[0, 1];
        arr2d[1, 0];
        arr2d[1, 1];
        arr2d[2, 0];
        arr2d[2, 1];
        
        
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

        arr3d2[0, 0, 0];  
        arr3d2[0, 0, 1];  
        arr3d2[0, 1, 0];  
        arr3d2[0, 1, 1];  
        arr3d2[1, 0, 0];  
        arr3d2[1, 0, 1];  
        arr3d2[1, 1, 0];  
        arr3d2[1, 1, 1]; 
        
        /*int[,,,] arr4d1 = new int[1, 1, 2, 2]{
            { 
                { { 1, 2}, { 3, 4} }     
            }
        };

        arr4d1[0, 0, 0, 0]; 
        arr4d1[0, 0, 0, 1]; 
        arr4d1[0, 0, 1, 0]; 
        arr4d1[0, 0, 1, 1]; 

        int[,,,] arr4d2 = new int[1, 2, 2, 2]{
            {
                { {1, 2}, {3, 4} },
                { {5, 6}, {7, 8} }
            }
        };

        arr4d2[0, 0, 0, 0]; 
        arr4d2[0, 0, 0, 1]; 
        arr4d2[0, 0, 1, 0]; 
        arr4d2[0, 0, 1, 1]; 
        arr4d2[0, 1, 0, 0]; 
        arr4d2[0, 1, 0, 1]; 
        arr4d2[0, 1, 1, 0]; 
        arr4d2[0, 1, 1, 1]; 
        
        // C# Jagged Arrays: An Array of Array
        // int[][] jArray1 = new int[2][];  
        // int[][,] jArray2 = new int[3][,];
        
        /*int[][] jArray = new int[2][]; 

        jArray[0] = new int[3]{1, 2, 3};

        jArray[1] = new int[4]{4, 5, 6, 7 };*/
        
        /*int[][] jArray = new int[2][]{
            new int[3]{1, 2, 3},

            new int[4]{4, 5, 6, 7}
        };

        jArray[0][0];
        jArray[0][1];
        jArray[0][2];
        jArray[1][0];
        jArray[1][1];
        jArray[1][2];
        jArray[1][3];
        
        /*int[][] jArray = new int[2][]{
            new int[3]{1, 2, 3},

            new int[4]{4, 5, 6, 7}
        };

        for(int i=0; i<jArray.Length; i++)
        {
            for(int j=0; j < (jArray[i]).Length; j++)
                Debug.Log(jArray[i][j]);
        }*/
        
        /*int[][,] jArray = new int[2][,];

        jArray[0] = new int[3, 2] { { 1, 2 }, { 3, 4 }, { 5, 6 } };
        jArray[1] = new int[2, 2] { { 7, 8 }, { 9, 10 } }; 

        jArray[0][1, 1];
                                             
        jArray[1][1, 0];
                                             
        jArray[1][1, 1];
        
        /*int[][][] intJaggedArray = new int[2][][] 
        {
            new int[2][]  
            { 
                new int[3] { 1, 2, 3},
                new int[2] { 4, 5} 
            },
            new int[1][]
            { 
                new int[3] { 7, 8, 9}
            }
        };

        Debug.Log(intJaggedArray[0][0][0]); // 1

        Debug.Log(intJaggedArray[0][1][1]); // 5
    
        Debug.Log(intJaggedArray[1][0][2]); // 9*/
        
        // C# - ArrayList
        
        // ArrayList arlist = new ArrayList();
        // var arlist = new ArrayList();
        /*var arlist1 = new ArrayList();
        arlist1.Add(1);
        arlist1.Add("Bill");
        arlist1.Add(" ");
        arlist1.Add(true);
        arlist1.Add(4.5);
        arlist1.Add(null);
        
        var arlist2 = new ArrayList()
        {
            2, "Steve", " ", true, 4.5, null
        };*/
        
        /*var arlist1 = new ArrayList();

        var arlist2 = new ArrayList()
        {
            1, "Bill", " ", true, 4.5, null
        };

        int[] arr = { 100, 200, 300, 400 };

        Queue myQ = new Queue();
        myQ.Enqueue("Hello");
        myQ.Enqueue("World!");

        arlist1.AddRange(arlist2);  
        arlist1.AddRange(arr);  
        arlist1.AddRange(myQ);*/
        
        /*var arlist = new ArrayList()
        {
            1,
            "Bill",
            300,
            4.5f
        };

        int firstElement = (int) arlist[0];
        string secondElement = (string) arlist[1];

        var firstElement = arlist[0];
        var secondElement = arlist[1];

        arlist[0] = "Steve"; 
        arlist[1] = 100;*/
        
        /*ArrayList arlist = new ArrayList()
        {
            1,
            "Bill",
            300,
            4.5F
        };

        foreach (var item in arlist)
            Debug.Log(item + ", "); 
            
        for(int i = 0 ; i < arlist.Count; i++)
            Debug.Log(arlist[i] + ", ");*/
        
        /*ArrayList arlist = new ArrayList()
        {
            1,
            "Bill",
            300,
            4.5f
        };

        arlist.Insert(1, "Second Item");

        foreach (var val in arlist)
            Debug.Log(val);*/
        
        /*ArrayList arlist1 = new ArrayList()
        {
            100, 200, 600
        };

        ArrayList arlist2 = new ArrayList()
        {
            300, 400, 500
        };
        arlist1.InsertRange(2, arlist2);

        foreach(var item in arlist1)
            Debug.Log(item + ", ");*/
        
        /*ArrayList arList = new ArrayList()
        {
            1,
            null,
            "Bill",
            300,
            " ",
            4.5f,
            300,
        };

        arList.Remove(null);
        arList.RemoveAt(4);
        arList.RemoveRange(0, 2);*/
        
        /*ArrayList arList = new ArrayList()
        {
            1,
            "Bill",
            300,
            4.5f,
            300
        };

        Debug.Log(arList.Contains(300));
        Debug.Log(arList.Contains("Bill"));
        Debug.Log(arList.Contains(10));
        Debug.Log(arList.Contains("Steve"));*/
        
        // C# - List<T>
        
        /*List<int> primeNumbers = new List<int>();
        primeNumbers.Add(1); 
        primeNumbers.Add(5);
        primeNumbers.Add(7);

        var cities = new List<string>();
        cities.Add("New York");
        cities.Add("London");
        cities.Add("Mumbai");
        cities.Add("Chicago");
        cities.Add(null);
        
        var bigCities = new List<string>()
        {
            "New York",
            "London",
            "Mumbai",
            "Chicago"                    
        };*/
        
        /*string[] cities = new string[3]{ "Mumbai", "London", "New York" };

        var popularCities = new List<string>();
        
        popularCities.AddRange(cities);

        var favouriteCities = new List<string>();
        
        favouriteCities.AddRange(popularCities);*/
        
        /*List<int> numbers = new List<int>() { 1, 2, 5, 7, 8, 10 };
        Debug.Log(numbers[0]); 
        Debug.Log(numbers[1]); 
        Debug.Log(numbers[2]); 
        Debug.Log(numbers[3]);

        numbers.ForEach(num => Debug.Log(num + ", "));

        for(int i = 0; i < numbers.Count; i++)
            Debug.Log(numbers[i]);*/
        
        /*var students = new List<Student>() { 
            new Student(){ Id = 1, Name="Bill"},
            new Student(){ Id = 2, Name="Steve"},
            new Student(){ Id = 3, Name="Ram"},
            new Student(){ Id = 4, Name="Abdul"}
        };
        
        var result = from s in students
            where s.Name == "Bill"
            select s;
		
        foreach(var student in result)
            Console.WriteLine(student.Id + ", " + student.Name);*/
        
        /*var numbers = new List<int>(){ 10, 20, 30, 40 };

        numbers.Insert(1, 11);

        foreach (var num in numbers)
            Console.Write(num);*/
        
        /*var numbers = new List<int>(){ 10, 20, 30, 40, 10 };

        numbers.Remove(10); 

        numbers.RemoveAt(2);

        foreach (var el in intList)
            Debug.Log(el); */
        
        /*var numbers = new List<int>(){ 10, 20, 30, 40 };
        numbers.Contains(10);
        numbers.Contains(11);
        numbers.Contains(20);*/

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
