<Query Kind="Program" />

// variable + parameters

// -- variables --
// stack 
// stack - logically grows and shrinks as a <method or function> is entered and exited

/*void Main()
{
	static int Factorial(int x)
	{
		if(x==0) return 1;
		return x * Factorial(x-1); // !! Recursion !!
	}
}*/

// Stack - LIFO manner - last-in-first-out

// called -> Factorial(5) -> final answer
// Factorial(4) ->
// Factorial(3) ->
// Factorial(2) ->
// Factorial(1) -> then this returns
// Factorial(0) -> returns (removed from stack - pop)

// heap
// heap - memory in which objects (reference-type instances) - reside or live
// whenever a new object is created - it is allocated on the heap - and !!then reference of that object is returned!!
// whenever your work is done with that object -> GC - garbage collector - managed by CLR - cleans that allocated space on heap
// value types are never allocated on heap - they return real address values (! struct !)

// Default values
// All reference types - null
// All numeric + enum types - 0
// char type - '\0' (struct)
// bool type - false

// -- Parameters --

// parameter modifiers - none, ref, in, out

// None version
// value types - copy via value
// !! Functions - <arguments by default are passed by value> !!
/*static void Foo(int p)
{
   p = p + 1;
   Console.WriteLine(p);
}

static void Foo2(StringBuilder fooSb)
{
	fooSb.Append("test");
	fooSb = null;  // fooSb = null
}

void Main()
{
	int x = 8;
	//Foo(x);				// p = x
	//Console.WriteLine(x);
	
	StringBuilder sb = new StringBuilder(); // reference type - allocated on heap
	Foo2(sb);		// sb = fooSb
	Console.WriteLine(sb.ToString());
}
*/


// ref version
// override function default behaviour -> copy via reference
/*static void Foo(ref int p)
{
   p = p + 1;
   Console.WriteLine(p);
}

static void Foo2(ref StringBuilder fooSb)
{
	fooSb.Append("test");
	fooSb = null;  // fooSb = null
}

void Main()
{
	int x = 8;
	//Foo(ref x);				// p = x
	//Console.WriteLine(x);
	
	StringBuilder sb = new StringBuilder(); // reference type - allocated on heap
	Foo2(ref sb);		// sb = fooSb
	Console.WriteLine(sb.ToString());
}
*/

// -- out modifier --
// "this is like a ref" argument except:
	// 1. it need not be assigned before going into the function
	// 2. It must be assigned before it comes out of the function
/*	
static void Split(string name, out string firstNames, out string lastName)
{
	int i = name.LastIndexOf(' ');
	firstNames = name.Substring(0, i);	// 2. It must be assigned before it comes out of the function
	lastName = name.Substring(i+1);		// 2. It must be assigned before it comes out of the function
}

void Main()
{
	string a,b;  // 1. it need not be assigned before going into the function
	Split("Stevie Ray Vaughan", out a, out b);
	Console.WriteLine(a);
	Console.WriteLine(b);
}
*/

// discards -> underscore
// previous function, what if I just want firstnames?
/*
static void Split(string name, out string firstNames, out string lastName)
{
	int i = name.LastIndexOf(' ');
	firstNames = name.Substring(0, i);	// 2. It must be assigned before it comes out of the function
	lastName = name.Substring(i+1);		// 2. It must be assigned before it comes out of the function
}

void Main()
{
	// string _ = "a"; -> allowed
	string a;  // 1. it need not be assigned before going into the function
	Split("Stevie Ray Vaughan", out a, out _);
	Console.WriteLine(a);
	Console.WriteLine(b);
	
	// after C# 7 >
	// SomeBigMethod(out _, out _, out _, out getthis, out _, out _, out _)
}
*/

// -- in modifier --
// "in parameter is similar to ref" except:
	// argument's value cannot be modified by the method
	// read-only parameters
	
// void Foo( SomeBigStruct a) // call by value
// void Foo(in SomeBigStruct a) // call by reference except it can't be modified

// -- params modifier --
// method accepts any number of arguments of a <particular type>
// must be declared as an array - value types !!
// can't use ref here
// this is call by value - default!!
/*static int Sum(params int[] ints)
{
	int sum = 0;
	for(int i=0; i< ints.Length;i++){
		sum += ints[i];
	}
	return sum;
}

void Main()
{
	int total = Sum(1,2,3,4,5,6,7,8,9);
	Console.WriteLine(total);
}*/

// Optional parameters
// they are always placed at the end
/*
static void Foo(int y, int x = 8)
{
	x = x + 1;
}

void Main()
{
	int y = 2;
	Foo(y);
}
*/

// Named parameters
/*
static void Foo(int y, int z)
{
	y = xy + 1;
}

void Main()
{
	int y = 2, z = 3;
	Foo(y,z); // first way
	Foo(y:2, z:3);  // named parameters way of calling
	Foo(z:3, y:2);
	Foo(z:3, y); // not allowed
}
*/

// C# 7 > - ref locals + ref returns
// ref local
/*void Main()
{
	int [] numbers = {0,1,2,3,4};
	ref int numRef = ref numbers[2];
	numRef = 3; // change here -> it will impact numbers at 2nd index
}*/

// ref returns
/*
static string x = "Old Value";
static ref string GetX()
{
	return ref x;
}

void Main()
{
	ref string xy = ref GetX();
	xy = "New Value";
	Console.WriteLine(x);
}
*/

// var - implicitly typed local variables
// var is always known at compile time
// dynamic is always known at runtime
/*
void Main()
{
	var x = "Hello";
	// usecase
	//System.Text.StringBuilder y = new System.Text.StringBuilder();
	//var y = new System.Text.StringBuilder();
}
*/


