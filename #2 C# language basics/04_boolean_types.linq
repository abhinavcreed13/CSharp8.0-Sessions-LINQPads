<Query Kind="Program" />

// reference type
/*
public class Dude
{
	public string Name;
	public Dude(string n)
	{
		Name = n;
	}
}

void Main()
{
	//C# - bool type - predefined type
	// 2 values - true and false
	
	Dude d1 = new Dude("John");
	Dude d2 = new Dude("John");
	
	Console.WriteLine(d1 == d2); //False
	
	Dude d3 = d1; //Copy via reference
	Console.WriteLine(d1 == d3);
	Console.WriteLine((d1 == d3).GetType()); //True
}
*/

// -- Conditional Operators (No binary numbers) --
// anything which returns (bool) by using operators
// Only conditions
// && - and operator
// || - or operator
// == - equality operator

// short-circuit evaluation
static bool UseUmbrella(bool rainy, bool sunny, bool windy)
{
	// True && True -> True
	//bool newWindy = !windy;
	//Console.WriteLine(!windy);
	
	/*if(!windy) {
		Console.WriteLine("Windy = FALSE");
	}*/
	//return !windy ? "Not windy" : "Windy";
	return !windy && (rainy || sunny);
}

void Main()
{
	//Console.WriteLine(UseUmbrella(true, false, true));
	// as soon as windy is false, then it doesn't check for rainy or sunny
	
	Console.WriteLine(UseUmbrella(true, false, false));
	// even if windy is true, it has to check rainy or sunny statement
}


// ternary operator

//static int Max(int a, int b)
//{
//	// if a > b, then return a (true) otherwise b (false)
//	return (a > b) ? a: b;
//	/*
//	if (a > b){
//		return a;
//	}
//	else{
//		return b;
//	}
//	*/
//}

/*
if(dataset.where( --- ).select( --- ).Any()) {
		// do this
}
else {

}
*/


// Define other methods, classes and namespaces here
