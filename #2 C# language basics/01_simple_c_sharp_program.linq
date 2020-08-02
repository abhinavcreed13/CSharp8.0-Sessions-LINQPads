<Query Kind="Program" />

// using System; // Importing namespace

/*
class Test // class declaration 
{
	static void Main() // method declaration
	{
		int x = 12 * 30; 		// Statement 1 (Statement declaration)
		Console.WriteLine(x); 	//Statement 2
	} // End of Method
}	// End of class
*/

/*
class Test // class declaration 
{
	
	static void Main() // method declaration
	{
		Console.WriteLine(FeetToInches(30));
		Console.WriteLine(FeetToInches(100));
	} // End of Method
	
	static int FeetToInches(int feet)
	{
		int inches = feet * 12;
		return inches;
	}
}*/	// End of class

// ---- SYNTAX ----

// Compilation
// C# is a compiler(whole code -> IL) not a (interpreter - Python)
// Interpreter - reads code line-by-line (order becomes important)

// Identifiers: They are the names that programmers choose for their classes/methods/variables...

// Keywords: names that mean something special to the compiler
// using, class, static, void, int ...
// ! Most of the keywords are reversed !

// ! Use reserved keyword as identifiers !
/*
class @class //legal
{

}
*/

// Contextual Keywords: you can use them as identifiers
// add, alias, async, await, remove, where,...

// -- Literals, Punctuators, Operators --
// Literals - primitive pieces of data lexically embedded into the program
// string name = "abc" (abc is a literal)
// int a = 10 (10 is a literal)

// Punctuators - help in defining some structure of the program (compiler needs to accept it)
// { } ; =>
// { } - statement blocks
// ; - terminate a statement
// => - lambda expression symbol - used to create anonymous functions (function without a name)

// Operators - transform/combine expressions

void Main(){
	Console.WriteLine
		(1 + 2 + 3 + 4 + 5);
}

// Comments - single line comment (CTRL + K + C / CTRL + K + U)
/*
	Multi line comment
*/

// Define other methods, classes and namespaces here