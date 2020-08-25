<Query Kind="Program" />

// Classes

// class - most common kind of reference type
// Preceding keywords - public, internal, abstract, sealed, static, unsafe, partial

// Field - is a variable that is a member of a class or struct (or attributes)
// --> variable should be inside the scope of the class
class Octopus
{
	string name; 			// field - by default private
	public int Age = 10; 	//field
	string name2 = "ABC";   // field
	
	public void callX()
	{
		string x = "abc";  // just a local variable
	}
}

// -- Constants --
// const keyword - evaluated statically at compile time and the compiler literally substitutes its value whenever used
// differs from readonly field -> readonly field can be assigned inside constructor
public class Test
{
	public const string Message = "Hello World";  // Field initilization - allowed!!
	
	public const double PIE = 3.145678;
	
	public readonly double radius;   // this is not const, but read-only
	
	public Test(int radius)
	{
		//Message = "Hello World2";  // not allowed
		this.radius = radius;		// allowed
	}
	
	public void CallX()
	{
		//Message = "new message";   // not allowed
		// radius = 40; 			// not allowed
	}
}

// -- Methods --
// method performs an action in a series of statements
// !! method can recieve input data by parameters and have output data back !!
// method have a !!signature!! -> signature is name, parameters, function return type, access modifier

// Method modifiers:
// static modifier -> static