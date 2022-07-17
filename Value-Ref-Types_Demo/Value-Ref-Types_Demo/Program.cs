using Value_Ref_Types_Demo;

#region Value Types

// Numbers
//float f;
//int? x = null;
//double y;
//decimal z;

//char a;
//bool b;

//MyStruct struct1;
//DaysOfTheWeek d;

//int a = 10;
//int b = a;
//b += 10;
//Console.WriteLine(a);

#endregion

#region Reference Type

//int[] c = new int[] { 1, 2, 3 };
//int[] d = c;
//d[0] = 10;
//Console.WriteLine(c[0]);

#endregion

Dog d1 = new Dog();
d1.Name = "Fido";
Dog d2 = d1;
d2.Name = "Jack";
Console.WriteLine(d2.Name); 
