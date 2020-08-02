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

// some memory - loaded inside RAM
public class Panda 
{
	public string Name; 				// Instance field
	public static int Population;			// Static Field
	public static string Century;
	
	public Panda(string n) 		// constructor
	{
		Name = n;					// assign the instance field
		Population = Population + 1;	// Increment the static population field
	}
}

void Main()
{
	Panda p1 = new Panda("Pan Dee");
	Panda p2 = new Panda("Pan Dah");
	Panda p3 = new Panda("Pan Dah 2");
	
	Console.WriteLine(p1.Name);
	Console.WriteLine(p2.Name);
	
	//Console.WriteLine(p1.Population);
	//Console.WriteLine(p2.Population);
	
	Console.WriteLine(Panda.Population);
}




