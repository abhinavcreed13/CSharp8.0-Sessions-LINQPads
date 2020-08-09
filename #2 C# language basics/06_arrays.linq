<Query Kind="Program" />

//void Main()
//{
	// Arrays - represents a fixed number of variables(elements) of a particular type
	//char [] vowels = new char[5]; //Declare an array of 5 characters
	//
	//vowels[0] = 'a';
	//vowels[1] = 'e';
	//vowels[2] = 'i';
	//vowels[3] = 'o';
	//vowels[4] = 'u';
	//Console.WriteLine(vowels[1]);
	
	//Tuples - immutable lists (read-only lists)
	
	// Deal with data + indexes
	///for(int i=0; i<vowels.Length; i++)
	//{
	//	Console.WriteLine(vowels[i]);
	//}
	//
	//// Dealing with data - do not care about indexes
	//foreach(char c in vowels)
	//{
	//	Console.WriteLine(c);
	//}
	
	// array initialization expression
	// char[] vowels = new char[]{'a', 'e', 'i', 'o', 'u'}; //char of 5 elements
	
	// char[] vowels = {'a', 'e', 'i', 'o', 'u'};
	
	// default element initilization
	//int[] a = new int[1000];
	//Console.WriteLine(a[123]); // default - 0
//}

/*
public struct Point { public int X,Y; }
	
public class Point2 { public int X,Y; }
	
void Main()
{
	// Value types vs reference types
	Point[] a = new Point[1000]; // collection of value types
	int x1 = a[500].X;
	
	Console.WriteLine(x1);
	
	Point2[] b = new Point2[1000]; // collection of reference types
	//int x2 = b[500].X;			// RunTime Error - NullReferenceException
	
	for(int i=0; i < b.Length; i++)
	{
		b[i] = new Point2();
	}
	
	int x2 = b[500].X;
	
	Console.WriteLine(x2);
}
*/



// Define other methods, classes and namespaces here
