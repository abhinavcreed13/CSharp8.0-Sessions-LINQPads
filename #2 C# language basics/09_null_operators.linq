<Query Kind="Program" />

// Null operators

// C# 3 null operators -> 
	// 1. null-coalescing operator
	// 2. null-coalescing assignment operator
	// 3. null-conditional operator
	
// Null-coalescing operator
// ??
// If the operand to the right is non-null, give it to me;
// otherwise, give me another value - which you specify after ??

//void Main()
//{
//	string s1 = null;
//	//string s2 = null;
//	
//	// copy data from s1 if s1 is having some data
//	//if (s1 == null) {
//	//	s2 = "nothing";
//	//}
//	//else { 
//	//	s2 = s1;
//	//}
//	
//	string s2 = s1 ?? "nothing"; // s2 evaluates to "nothing" here
//	//Console.WriteLine(s2);
//	
//	Object o1 = null;
//	
//	Object o2 = o1 ?? new People()
//	
//	o2.AddPeople()
//}


// null-coalescing assignment operator (C# 8+)
// ??=

//void Main()
//{
//	string s1 = null;
//	
//	if (s1 == null) s1 = "something";
//	
//	s1 ??= "something";
//	
//	// if resturantObj is null, assign new Restaurant()
//	Restaurant restaurantObj;
//	restaurant ??= new Restaurant();
//}

// ??, ??=, ?.

// ?? -> Null coalescing operator
// ? -> conditional/nullable type

// Null-conditional operator
// ?. - elvis operator

//void Main()
//{
//	StringBuilder sb = null; // I have no way to reach main memory or address space
//	string s = sb.ToString(); //Object reference not set to an instance of an object.
//	
//	string s1 = sb?.ToString(); // returns back null if sb is null
//	Console.WriteLine(s1); // null
//	
//	string s2 = sb?.ToString().ToUpper();
//	Console.WriteLine(s2);
//	
//	int s3 = sb?.ToString().Length; // can't store null inside int (value-type)
//	int? s4 = sb?.ToString().Length; // (nullable Value Types)
//	Console.WriteLine(s3);
//}

// Python .py -> interpreter -> .pyc -> C
// FORTRAN/PASCAL -> C [public static void Main(string **args)] -> OOPS -> C++ (pointers) -> gcc 

