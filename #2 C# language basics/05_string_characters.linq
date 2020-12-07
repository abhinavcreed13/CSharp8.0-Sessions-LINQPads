<Query Kind="Program" />

/*
// Characters
void Main()
{
	char c = 'A'; //Simple character
	Console.WriteLine(c);
	
	//char newLine = '\n'; //newline
	//char backSlash = '\\'; //backlash
	
	char copyrightSymbol = '\u00A9'; //Unicode character 
	char omegaSymbol = '\u03A9';		//Unicode character
	Console.WriteLine(copyrightSymbol);
	Console.WriteLine(omegaSymbol);
}
*/

// String Type

// String type - immutable (unmodifiable) <sequence of unicode characters> (UTF-8 format)

void Main()
{
	//// sequence of unicode characters
	string a = "ta"; // -> "aa"
	Console.WriteLine(a[0]);
	/*
	var l = a.Split("");
	l[0] = "T";
	a = String.Join(l.ToArray());
	Console.WriteLine(a[0]);
	*/
	//foreach(char c in a) //For this foreach to work, we need IEnumerable interface (enumerating ability)
	//{
	//	Console.WriteLine(c);
	//}
	//Console.WriteLine(a[0]);
	//
	////immutable?
	//// a[0] = 'y'; // unmodifiable
	//
	//// possible
	////a = "test2";
	//
	//// String - reference type
	//string b = "test";
	//// String c = b; // address concept is important
	// public static bool operator ==(String? a, String? b) - operator overloading
	// Console.WriteLine(a == b); // True
	
	// ! verbatim strings !
	// \\server\fileshare\helloworld.cs
	
	string a1 = "\\\\server\\fileshare\\helloworld.cs";
	
	string a2 = @"\\server\fileshare\helloworld.cs"; // verbatim string
	
	string escaped = "First Line\r\nSecond Line";
	
	string verb = @"First Line\r\nSecond Line"; // verbatim - view those escape sequences
	
	Console.WriteLine(verb);
	
	string xml = @"<customer id=""123""></customer>"; // verbatim - can't escape double quotes
	
	Console.WriteLine(xml);
	
	
	// -- String concatenation
	// private static string operator +(Object? a, Object? b) - operator overloading
	/*
	string s = "a" + "b";
	Console.WriteLine(s);
	
	string s1 = "a" + 5; //Implicit conversion
	
	Console.WriteLine(s1);
	*/
	
	// -- String interpolation --
	// string preceded with the $ character - interpolated string
	//int x = 4;
	//string color = "red";
	//Console.WriteLine("A square has" + x + "sides, " + color + " color");
	//
	//Console.WriteLine(string.Format("A square has {0} sides, {1} color", x, color));
	//
	//Console.WriteLine($"A square has {x} sides, {color} color");
	
	//string s = $"255 in hex is {byte.MaxValue:X2}"; // 2-digit hexadecimal (formatting)
	//Console.WriteLine(s);
	
	// String does not support < and > operators !! (C#) - compareTo (#6)
	// Strangely - Python supports this
}

// Define other methods, classes and namespaces here
