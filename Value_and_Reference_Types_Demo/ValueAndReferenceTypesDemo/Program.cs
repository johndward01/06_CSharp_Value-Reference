﻿using System;
using System.Collections;
using System.Runtime.InteropServices;

namespace ValueAndReferenceTypesDemo
{
    class Program
    {
        static void Main(string[] args)
        {

            //https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/types/ C# TYPE SYSTEM***


            
            double defaultValueOfDouble = default; // Beginning with C# 7.1, you can use the default literal to initialize a variable with the default value of its type
            char? defaultValueOfChar = null; // creating a nullable char Type


            // If you make a variable null .... un-expected behavior will happen!!!
            //int? number1 = null;

            //int? number2 = number1;

            //number2 += 2;

            //Console.WriteLine(number1); 
            //Console.WriteLine();
            //Console.WriteLine(number2); 





            // ------Value Type--------

            string firstName = "John";
            Console.WriteLine(firstName);

            //int x = 10;
            //int y = x;
            //y++;
            //Console.WriteLine(x);
            //Console.WriteLine();
            //Console.WriteLine(y);




            //// ------Reference Type-------

            //int[] arr1 = new int[3]; // Declaring an array

            //// Initializing an array
            //arr1[0] = 10;
            //arr1[1] = 20;
            //arr1[2] = 30;

            //int[] arr2 = arr1; // Copied the reference or the pointer to the value


            //Console.WriteLine(arr1[0]); // Output
            //Console.WriteLine(arr2[0]); // Output




























            string firstName = "Christine"; // Declared & Initialized the variable firstName 

            string lastName; // Declaring a vaiable  

            lastName = "Godfrey"; // Initialize a variable 

            //int age;
            //age = 30;

            int age = 30;

            string age1 = "30";

            int[] aBunchOfIntergers = new int[9];

            string[] studentList = new string[2];

            studentList[0] = "Christine";
            studentList[1] = "John";

            //Console.WriteLine(studentList);

            //bool isComplete = false;
            //Console.WriteLine(isComplete); // False

            //bool isAlsoComplete = isComplete;
            //Console.WriteLine(isAlsoComplete); // False

            //isAlsoComplete = true;
            //Console.WriteLine(isComplete); // False

            var s = new Stack();

            var h = new Queue();

            //int[] someArray = new int[] { 10, 20, 30 };

            //int[] someOtherArray = someArray;

            //Console.WriteLine(someArray[0]);
            //Console.WriteLine(someOtherArray[0]);

            //someOtherArray[0] = -10;

            //Console.WriteLine(someArray[0]); //?

            //Console.WriteLine(firstName);
            //Console.WriteLine();


            //foreach (var x in arr)
            //{
            //    Console.WriteLine(x);
            //}
            
            //Console.WriteLine(" " + defaultValueOfInteger);
           // Console.WriteLine(" " + defaultValueOfDouble);
            //Console.WriteLine(" " + defaultValueOfChar);
            //Console.WriteLine(" " + "----------------------");
            //-------------------------------------------------------------------------------------------------------------------------
            //When you pass a value-type variable from one method to another, the system creates a separate copy of a variable in another method.
            //If the value is changed in the one method, it will not affect the variable in the other method.

            //  (" " + ) --> All this does is adds a space so the text isn't directly against the left side of the console window


            //int num1 = 1;
            ////Methods.ChangeNumber(num1);
            //Console.WriteLine(" " + num1);
            ////-------------------------------------------------------------------------------------------------------------------------

            //int x = 1;
            //int y = x;
            //y++;
            //Console.WriteLine(" " + x);
            //Console.WriteLine(" " + y); // What will be printed out to the console?
            //Console.WriteLine(" " + "---------------------------");
            //--------------------------------------------------------------------------------------------------------------------------

            //Fraction fraction1 = new Fraction();
            //fraction1.numerator = 1;
            //fraction1.denominator = 1;

            //Fraction fraction2 = fraction1;
            //fraction2.numerator = 1111;

            //Console.WriteLine(" " + fraction1.numerator); // What will be printed out to the console? (remember: fraction1 is a reference type)
            //Console.WriteLine(" " + "---------------------------");
            ////---------------------------------------------------------------------------------------------------------------------------

            //int z = 5;
            //Methods.Change(z);
            //Console.WriteLine(" " + z); // What will be printed out to the console? (remember: z is a value type)
            //Console.WriteLine(" " + "---------------------------");
            ////---------------------------------------------------------------------------------------------------------------------------

            //Student s = new Student();
            //s.id = 2;
            //s.name = "Bobby";
            //Methods.Change(s);
            //Console.WriteLine(" " + s.id); // What will be printed out to the console? (remember: s is a reference type)
            //Console.WriteLine(" " + s.name);    
            
            ////BONUS ---------------------------------------------------------------------------------------------------------------------------
            
            //string greeting = "Hello";
            //Methods.ChangeGreeting(greeting);
            //Console.WriteLine(" " + greeting); // What will be printed out to the console? (This one's a bit tricky)
            //Console.WriteLine(" " + "---------------------------");
        }
      
    }
}
