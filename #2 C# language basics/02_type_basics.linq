<Query Kind="Program" />

// Type: something that defines the blueprint for a value

// C# - type safe language

/*
void Main()
{
	var x = 12 * 30;
	Console.WriteLine(x);
}
*/

// Variable - denotes a storage location that can contain different values

// C# provides no keyword as `undefined` - replacement is null

// -- Predefined Types -- (Primitive)

// int
/*
void Main()
{
	int x = 12 * 30;
	Console.WriteLine(x);
}
*/

// string
/*
void Main()
{
	int year = 2020;
	string x = "Hello World";
	x = x + 20;
	Console.WriteLine(x);
}*/

// bool - 2 values: true or false
/*
void Main()
{
	bool simpleVar = true;
	if (simpleVar)	
		Console.WriteLine("This will print");
	
	int x = 5400;
	// boolean expression
	bool lessThanAMile = x < 5280;
	if (lessThanAMile)	
		Console.WriteLine("This will print again");
}*/

// --- Custom Type Example ---

// Custom Type
/*
public class UnitConverter
{
	int ratio; // Field
	// overridding default constructor
	public UnitConverter()
	{
	
	}
	// overrides the default constructor
	public UnitConverter(int unitRatio) // Constructor
	{
		ratio = unitRatio;
	}
	public int Convert(int unit) //Method
	{
		return unit * ratio;
	}
}

void Main()
{
	// Type
	// int x = 10;
	// string x = "abc";
	UnitConverter feetToInchesConverter = new UnitConverter(12);
	UnitConverter milesToFeetConverter = new UnitConverter(5280);
	
	Console.WriteLine(feetToInchesConverter.Convert(30));
	Console.WriteLine(milesToFeetConverter.Convert(1));
}
*/
// Primitive (old type - supported in C/C++) - int, string, char, bool, float
// Predefined types - primitive + their own implementations (BigInt)
// Custom Types - classes/interface/structs

// -- Instance vs static members --
//
//// some memory - loaded inside RAM
//public class Panda 
//{
//	public string Name; 				// Instance field
//	public static int Population;			// Static Field
//	public static string Century;
//	
//	public Panda(string n) 		// constructor
//	{
//		Name = n;					// assign the instance field
//		Population = Population + 1;	// Increment the static population field
//	}
//}
//
//void Main()
//{
//	Panda p1 = new Panda("Pan Dee");
//	Panda p2 = new Panda("Pan Dah");
//	Panda p3 = new Panda("Pan Dah 2");
//	
//	Console.WriteLine(p1.Name);
//	Console.WriteLine(p2.Name);
//	
//	//Console.WriteLine(p1.Population);
//	//Console.WriteLine(p2.Population);
//	
//	Console.WriteLine(Panda.Population);
//}

// -- Conversions --

//void Main()
//{
//	int x = 12345;  		//32-bit integer
//	long y = x; 			//Implicit conversion to 64-bit integer
//	short z = (short)x; 	// 16-bit integer (Explicit conversion)
//}

// -- Value types vs reference types

// custom type
// value type
public struct Point 
{
	public int X, Y; //fields
}

// reference type
public class Point2
{
	public int X, Y; //fields
}

//static void Main() 
//{
//	Point p1 = new Point();	//value type object
//	p1.X = 7;
//	
//	Point p2 = p1;		//Assignment causes copy via value (value types)
//	
//	Console.WriteLine(p1.X);
//	Console.WriteLine(p2.X);
//	
//	p1.X = 9;	// Change p1.X
//	
//	Console.WriteLine(p1.X);
//	Console.WriteLine(p2.X);
//	
//	Point2 p3 = new Point2();	//reference type object
//	p3.X = 7;
//	
//	Point2 p4 = p3;		//Assignment causes copy via reference (reference types)
//	
//	Console.WriteLine(p3.X);
//	Console.WriteLine(p4.X);
//	
//	p3.X = 9;	// Change p1.X
//	
//	Console.WriteLine(p3.X);
//	Console.WriteLine(p4.X);
//	
//	int a = 10;
//	
//	int b = a;
//	
//	b = 20;
//	
//	
//	// -- Null
//	// Point p = null; // cannot make it null
//	// Point2 p = null; // null reference
//}

// struct - Int32, Boolean - value types (when something can't be null)
// classes - String - reference types (when objects can take null values)
// interface ~ class

static void Main()
{
	int a = 10;
    int b = a; //copy via value
    a = 20;

    string name1 = "abc";
   	string name2 = name1; // copy via reference
    name1 = "abc2";
	
	Console.WriteLine(b);
	
	Console.WriteLine(name2);
}









