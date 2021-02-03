<Query Kind="Program" />

// Enums

// special *value* type that lets you specify a group of named numeric constants

public enum BorderSide { Left = 0, 
						Right = 1,
						Top = 2, 
						Bottom = 3 
						};

//void Main()
//{
//	//int a = 10;
//	// BorderSide type will take one of the BorderSide enum value
//	BorderSide side = BorderSide.Left;
//	if (side == BorderSide.Left){
//		Console.WriteLine("This is left");
//	}
//	
//	Console.WriteLine((int)BorderSide.Right);
//}

// Flags Enums
// To prevent ambiguities, members of a combinable enum require explicitly assigned values -> typically in powers of two
[Flags]
public enum BorderSides {
	None = 0, 	//0
	Left = 1, 	//2^0
	Right = 2, 	//2^1
	Top = 4,	//2^2
	Bottom = 8  //2^3
}

// Nested Types
// secured inside kind of usage classes
public class TopLevel 
{
	public class Nested {	//Nested class 
		public static void Foo() {
			Console.WriteLine("TopLevel.X");
		}
	} 
	
	public enum Color { Red, Blue, Tan } //Nested enum
	
	// this is connected at class level -> this is not initilized for each object
	public static int b = 20;
	
	// data field
	public int a = 10;
}

void Main() {
	// Nested n = new Nested(); -> not possible
	
	TopLevel t = new TopLevel();
	Console.WriteLine(t.a); 
	
	// trying to access static field of the class
	Console.WriteLine(TopLevel.b);
	
	// trying to access nested types
	TopLevel.Nested.Foo();
	TopLevel.Color col = TopLevel.Color.Red;
}


