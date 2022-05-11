using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hello : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        /*string message = "Hello World!!";

        Debug.Log(message);

        int num;
        num = 100;
        num = 200;
        int i, j = 10, k = 100;
        int a = 0,
            b = 10,
            c = 100;
        int e = 100;

        int h = e;
        h = 10 + 10;
        var chuoi = "khai bao dong";
        // var m = 999;
        float rate = 10.2f;
        decimal amount = 100.50M;
        char code = 'C';
        bool isValid = true;
        string name = "Steve";

        uint ui = 100u;
        float fl = 10.2f;
        long l = 45755452222222l;
        ulong ul = 45755452222222ul;
        // double d = 11452222.555d;
        decimal mon = 1000.15m;

        int q = default(int); // 0
        // float f = default(float);// 0
        decimal w = default(decimal);// 0
        bool t = default(bool);// false
        char y = default(char);// '\0'

        // C# 7.1 onwards
        int p = default; // 0
        float n = default;// 0
        decimal o = default;// 0
        bool x = default;// false
        char z = default;// '\0'

        // data type byte
        byte b1 = 255;
        // byte b2 = -128;// compile-time error: Constant value '-128' cannot be converted to a 'byte'
        sbyte sb1 = -128;
        sbyte sb2 = 127;
        // short
        short s1 = -32768;
        short s2 = 32767;
        // short s3 = 35000;//Compile-time error: Constant value '35000' cannot be converted to a 'short'

        ushort us1 = 65535;
        // ushort us2 = -32000; //Compile-time error: Constant value '-32000' cannot be converted to a 'ushort'

        // Console.WriteLine(Int16.MaxValue);//32767
        // Console.WriteLine(Int16.MinValue);//-32768
        // Console.WriteLine(UInt16.MaxValue);//65535
        // Console.WriteLine(UInt16.MinValue);//0
        // int
        int i11 = -2147483648;
        int j22 = 2147483647;
        // int k33 = 4_294_967_295; //Compile-time error: Cannot implicitly convert type 'uint' to 'int'.

        uint ui1 = 4294967295;
        uint ui2 = unchecked((uint)-1); //Compile-time error: Constant value '-1' cannot be converted to a 'uint'

        /*Console.WriteLine(Int32.MaxValue);//2147483647
        Console.WriteLine(Int32.MinValue);//-2147483648
        Console.WriteLine(UInt32.MaxValue);//4294967295
        Console.WriteLine(UInt32.MinValue);//0#1#

        /*Console.WriteLine(Byte.MaxValue);//255
        Console.WriteLine(Byte.MinValue);//0
        Console.WriteLine(SByte.MaxValue);//127
        Console.WriteLine(SByte.MinValue);//-128#1#
        // Long
        long l1 = -9223372036854775808;
        long l2 = 9223372036854775807;

        ulong ul1 = 18223372036854775808ul;
        ulong ul2 = 18223372036854775808UL;

        /*Console.WriteLine(Int64.MaxValue);//9223372036854775807
        Console.WriteLine(Int64.MinValue);//-9223372036854775808
        Console.WriteLine(UInt64.MaxValue);//18446744073709551615
        Console.WriteLine(UInt64.MinValue);//0#1#

        // data float
        float f1 = 123456.5F;
        float f2 = 1.123456f;

        // Console.WriteLine(f1);//123456.5
        // Console.WriteLine(f2);//1.123456
        // double
        double d11 = 12345678912345.5d;
        double d22 = 1.123456789123456d;

        // Console.WriteLine(d1);//12345678912345.5
        // Console.WriteLine(d2);//1.123456789123456
        // decimal
        decimal d1 = 123456789123456789123456789.5m;
        decimal d2 = 1.1234567891345679123456789123m;

        // Console.WriteLine(d1);
        // Console.WriteLine(d2);
        //Scientific Notation
        double d = 0.12e2;
        // Console.WriteLine(d);  // 12;

        float f = 123.45e-2f;
        // Console.WriteLine(f);  // 1.2345

        decimal m = 1.2e6m;
        // Console.WriteLine(m);// 1200000

        string ch = "S";
        string word = "String";
        string text = "This is a string.";
        // string str1 = "Hello"; // uses string keyword
        //
        // String str2 = "Hello"; // uses System.String class
        
        char[] chars = {'H','e','l','l','o'};

        string str1 = new string(chars);  
        String str2 = new String(chars); 

        foreach (char ccc in str1)
        {
            Console.WriteLine(ccc);
        }
        
        string text1 = "This is a \"string\" in C#.";
        string str = "xyzdef\\rabc";
        string path = "\\\\mypc\\ shared\\project";
        
        string str3 = @"xyzdef\rabc";
        string path2 = @"\\mypc\shared\project";
        string email2 = @"test@test.com";
        
        string str111 = "this is a \n" + 
                      "multi line \n" + 
                      "string";
		
        // Verbatim string
        string str222 = @"this is a 
        multi line 
        string";
        
        string text2 = "This is a \"string\" in C#."; // valid
        // string text3 = @"This is a "string." in C#."; // error
        // string text4 = @"This is a \"string\" in C#."; // error
        string text5 = @"This is a ""string"" in C#."; // valid
        
        string name123 = "Mr." + "James " + "Bond" + ", Code: 007";
 
        string firstName1111 = "James";
        string lastName1111 = "Bond";
        string code123 = "007";
 
        string agent = "Mr." + firstName1111 + " " + lastName1111 + ", Code: " + code;
        
        string firstName = "James";
        string lastName = "Bond";
        string code431 = "007";
 
        string fullName = $"Mr. {firstName} {lastName}, Code: {code}";
        
        MyClass newClass = new MyClass();
        Debug.Log(newClass.MyMethod("mes1", "mes 2"));*/
    }

    // Update is called once per frame
    void Update()
    {

    }
}

public class MyClass
{
    public string myField = string.Empty;

    public MyClass()
    {
    }

    public string MyMethod(string parameter1, string parameter2)
    {
        return "First Parameter " + parameter1 + ", second parameter " + parameter2;
    }

    public int MyAutoImplementedProperty { get; set; }

    private int myPropertyVar;

    public int MyProperty
    {
        get { return myPropertyVar; }
        set { myPropertyVar = value; }
    }
}
