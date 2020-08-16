<Query Kind="Program" />

// --- Statement
// A statement block - series of statements appearing inside {}

// -- Declaration statements
// string someWord = "rosebud";

// Local variables
// always scoped inside the braces {}
/*
void Main()
{
	int x; // defined 
	{
		int y;
		int x; // Error - x is already defined
	}
	{
		int y; // OK - y not in scope
	}
	Console.WriteLine(y); // Error - y is out of scope
}
*/

// Selection Statements -> if, switch
// Conditional operator -> ?:
// Loop statements -> while, for, foreach, do-while
/*
void Main()
{
	if(2+2 == 5) Console.WriteLine("Does not compute");
	else
		if(2+2 == 4)
			Console.WriteLine("Computes");
			
	if(true)
	{
		if(false)
			Console.WriteLine();	
	}
	else
		Console.WriteLine("executes");
}
*/

// if-else-if-else chain -> multiple conditions

// -- switch statements

//static void ShowCard(int cardNumber)
//{
//	
//	switch(cardNumber)
//	{
//		case 13:
//			Console.WriteLine("King");
//			break;
//			
//		case 12:
//			Console.WriteLine("Queen");
//			break;
//			
//		case 11:
//			Console.WriteLine("Jack");
//			break;
//			
//		case -1:
//			goto case 12;
//			
//		default:  // similar to else of if-else-if-else chain
//			Console.WriteLine(cardNumber);
//			break;
//	}
//	
//	switch(cardNumber)
//	{
//		// or condition in if-else world
//		case 13:
//		case 12:
//		case 11:
//			Console.WriteLine("Face card");
//			break;
//		default:
//			Console.WriteLine("Plain card");
//			break;
//	}
//}
//
//void Main()
//{
//	ShowCard(11);
//}

// (C# 7+) - you can also switch on 'types'
/*
static void TellMeTheType(object x)
{
	switch(x)
	{
		case int i:
			Console.WriteLine("It's an int!");
			Console.WriteLine($"The square of {i} is {i*i}");
			break;
		case string s:
			Console.WriteLine("It's a string!");
			Console.WriteLine($"The length of {s} is {s.Length}");
			break;
		default:
			Console.WriteLine("I don't know what x is");
			break;
	}
}

void Main()
{
	TellMeTheType(10);
	TellMeTheType(11);
	TellMeTheType("hello");
	TellMeTheType(false);
}
*/

// switch expressions (C# 8+)
/*
void Main()
{
	int cardNumber = 13;
	// switch expression - can get you the cardName as per the cardNumber
	string cardName = cardNumber switch
	{
		13 => "King",
		12 => "Queen",
		11 => "Jack",
		_ => "Pip Card" // equivalent to 'default'
	};
	Console.WriteLine(cardName);
	
	string suit = "spades";
	string cardName2 = (cardNumber, suit) switch
	{
		(13, "spades") => "king of spades",
		_ => "Pip Card"
	};
	Console.WriteLine(cardName2);
}
*/

// Iteration statements - while, do-while, for, foreach
// foreach - will only work for enumerable objects (IEnumerable interface)

// Jump statements - break, continue, goto, return, <throw>
// continue
/*void Main()
{
	for(int i=0; i< 10;i++)
	{
		if((i%2) == 0)
			continue;
		
		Console.WriteLine(i);
	}
}*/





