<Query Kind="Program" />

/*void Main()
{
	int x = 127;
	long y = 0x7F;
	
	Console.WriteLine(x);
	Console.WriteLine(y);
	
	//C# 7 >
	
	// improve readability
	int million = 1_000_000_000;
	Console.WriteLine(million);
	
	//double d = 1.5;
	double million2 = 12E9; // 12 x 10^9 ~ (E = x 10^)
	Console.WriteLine(million2);
}*/

// Numerical literal type list
/*
void Main()
{
	Console.WriteLine( 1.0.GetType()); //System.Double
	Console.WriteLine( 1E06.GetType()); //System.Double
	Console.WriteLine( 1.GetType()); //Int32
	Console.WriteLine( 0xF0000000.GetType()); //UInt32
}
*/

// Numeric suffixes
//void Main()
//{
//	float f = 1.23F;	
//	double d = 1.23D;
//	decimal d2 = 1.23M;
//	
//	uint i = 1U;
//	
//	long j = 1L;
//	
//	ulong k = 1UL;
//}


// Numeric conversions !! - (truncation)
/*
void Main()
{
	int x = 12345;
	long y = x; //Implicit conversion
	short z = (short)x; //Explicit conversion - possible truncation
	
	int i = 1;
	float f = i; //Implicit conversion
	int i2 = (int)f; //Explicit conversion - truncation will happen (precision will be lost)
}
*/

// -- Arithmetic operators
// Increment, Decrement operators (++, --)
// cool interview coding round

//void Main()
//{
//	int x=0, y=0;
//	int c = x++; // 0 -> lazy evaluation
//	int d = ++x; // 2 -> normal evaluation
//	Console.WriteLine(x++);
//	Console.WriteLine(++x);
//	Console.WriteLine(++y);
//}


// Specialized Operations on Integral Types
//void Main()
//{
//	// Division
//	//int a = 4/3; // truncation
//	//Console.WriteLine(a);
//	
//	// Overflow
//	//int a = int.MinValue;
//	//a--;	// Overflow exception is avoided here
//	//Console.WriteLine(a == int.MaxValue); //True*/
//	
//	// Overflow check operators (checked)
//	
//	//int a = 1000000;
//	//int b = 1000000;
//	
//	//int c = checked (a * b);
//	
//	//checked 
//	//{
//	//	int d = a + b;
//	//	int e = a * b;
//	//}
//	//Console.WriteLine(c);
//	
//	
//	// unchecked
//	
//	//int x = int.MaxValue;
//	//int y = unchecked(x+1);
//	//
//	//Console.WriteLine(y);
//	
//}

// --- Bitwise Operators ---
// -- Binary numbers --
// ~ - complement
// & - And operator
// | - Or operator
// << , >> , ^ - logic gates operators


// Special float and double values
// Cheat sheet
/*
void Main()
{
	double maxValue = double.PositiveInfinity;
	Console.WriteLine(20 < maxValue);
	Console.WriteLine(1.0/-0.0);
	Console.WriteLine(double.NaN == 0.0/0.0);
}
*/

// double vs decimal
// cheat sheet

// Real-number rounding errors (exists)
//[BEMDAS]
/*
void Main()
{
	float tenth = 0.1f;		// 0.1
	float one = 1f;			// 1.0
	Console.WriteLine(one - tenth * 10f); //(1.0 -  0.1 * 10.0) = 0
	// -1.49000E-08
	
	decimal m = 1M/6M;
	Console.WriteLine(m);	//0.1666666666666666666666666667
	
	double d = 1.0/6.0;
	Console.WriteLine(d);	//0.16666666666666666
	
	decimal notQuiteWholeM = m+m+m+m+m+m; //1M
	Console.WriteLine(notQuiteWholeM);
}
*/









