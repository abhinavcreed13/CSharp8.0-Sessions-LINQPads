<Query Kind="Program" />

//void Main()
//{
//	// Arrays - represents a fixed number of variables(elements) of a particular type
//	char [] vowels = new char[5]; //Declare an array of 5 characters
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
	//char[] vowels = new char[]{'a', 'e', 'i', 'o', 'u'}; //char of 5 elements
	
	// char[] vowels = {'a', 'e', 'i', 'o', 'u'};
	
	// default element initilization
//	List<int> a1 = new List<int>();
//
//	int[] a2 = new int[1000];  // -> stack
	//Console.WriteLine(a[123]); // default - 0
	
	
	
//}

// value type -> directly have access to the address space -> there is no null
public struct Point { public int X,Y; }

// reference type -> doesn't have direct access to the address space -> new allocation
public class Point2 { public int X,Y; }
	
void Main()
{
	// Value types vs reference types
	Point[] a = new Point[1000]; // collection of value types
	int x1 = a[500].X;
	
	Console.WriteLine(x1);
	
	Point2[] b = new Point2[1000]; // collection of reference types
	//Point2[] c = b;
	//int x2 = b[500].X;			// RunTime Error - NullReferenceException (NullPointerException)
	
	for(int i=0; i < b.Length; i++)
	{
		b[i] = new Point2();
	}
	//
	int x2 = b[500].X;
	
	Console.WriteLine(x2);
}


// Multidimensional array
// Rectangular and jagged

// Rectangular arrays
/*void Main()
{
	// 3 x 3 matrix - 2D array
	int[,] matrix = new int[3,3];
	//Console.WriteLine(matrix[0,1]);
	// row loop
	for(int i=0; i < matrix.GetLength(0); i++)
	{
		//Console.WriteLine(i);
		// column loop
		for(int j=0; j< matrix.GetLength(1); j++)
		{
			//Console.WriteLine(j);
			matrix[i,j] = i * 3 + j;
		}
	}
	//Console.WriteLine(matrix[2,2]);
}*/

// Jagged arrays
void Main()
{
	// 3 x ? matrix - 2D array
	/*
	int[][] matrix = new int[3][];
	for(int i=0; i< matrix.Length; i++)
	{
		matrix[i] = new int[3]; // create inner array
		for(int j=0; j< matrix[i].Length; j++){
			matrix[i][j] = i * 3 + j;
		}
	}
	*/
	// matrix init syntax - default values
	// array of arrays
	int[][] matrix = new int[][]
	{
		new int[] {0,1,2},
		new int[] {3,4,5},
		new int[] {6,7,8,9,10}
	}
}

// Define other methods, classes and namespaces here
