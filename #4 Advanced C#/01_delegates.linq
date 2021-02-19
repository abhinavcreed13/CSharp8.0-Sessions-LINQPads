<Query Kind="Program" />

// --- Delegates ---

// delegate is an *object* that knows how to call a method
// -- informal: pointer to a real function --

// -- exclusive to javascript --
// var fn = function(){
// 	 console.log("I am clicked");
// };
// fn -> working as delegate
// $("#id").click(fn);

// -- A delegate *type* defines the kind of method that delegate instances can call --

// This below delegate can call any method/ This below delegate can store pointer of any method
// if it's return type is `int` and it takes a parameter of `int`

// example delegate
//delegate int Transformer(int x);
//
//// methods
//static int Square(int x) { return x * x; }
//
//static void Name(int x) { x = x + 1; }
//
//void Main()
//{
//	// Storing
//	// same thing
//	Transformer t1 = new Transformer(Square);
//	// Transformer t1 = Square;		// better
//	
//	// Transformer t2 = Name;
//	
//	// same syntax
//	Console.WriteLine(t1(2));  // better
//	Console.WriteLine(t1.Invoke(2));
//}

// --- Writing Plug-in Methods with Delegates ---

//public delegate int Transformer(int x);
//
//class Util 
//{
//	// Idea -> This function will perform transformation on some values, but the logic is plugged from outside
//	public static void Transform(int[] values, Transformer t)
//	{
//		for(int i=0; i < values.Length; i++)
//		{
//			values[i] = t(values[i]); //MyTransform(values[i]);
//		}
//	}
//}
//
//// logic ?
//static int MyTransform(int x) => x * x * x;
//
//void Main()
//{
//	int[] values = { 1, 2, 3 };
//	Util.Transform(values, MyTransform);
//	foreach(int i in values)
//	{
//		Console.Write(i+ " ");
//	}
//}


// ---- Multicast Delegates ----

// All delegate instances have multicast capability

// SomeDelegate d = SomeMethod1;
// d() -> call SomeMethod1
// d += SomeMethod2;
// d() -> call SomeMethod1, then SomeMethod2

// d -= SomeMethod2; // remove that method

//public delegate void ProgressReporter(int percentComplete);
//
//class Util
//{
//	public static void HardWork(ProgressReporter p)
//	{
//		for(int i=0;i<10;i++)
//		{
//			p(i * 10);								// Invoke delegate
//			// Imagine something is happening here that takes 100ms
//			System.Threading.Thread.Sleep(100);		// Simulating Hardwork
//		}
//	}
//}
//
//// Logic
//static void WriteProgressToConsole(int percentComplete) => Console.WriteLine(percentComplete);
//
//static void WriteProgressToFile(int percentComplete) 
//{
//  Console.WriteLine("writing progress.txt");
//  System.IO.File.WriteAllText("progress.txt", percentComplete.ToString());
//}
//
//void Main()
//{
//	ProgressReporter p = WriteProgressToConsole;
//	// p = p + WriteProgressToFile;
//	p += WriteProgressToFile;
//	// Pass multi-casted delegate
//	Util.HardWork(p);
//	
//	// p = p - WriteProgressToFile;
//	p -= WriteProgressToFile;
//	Util.HardWork(p);
//}

// --- Generic Delegate Types ---

//public delegate T Transformer<T>(T x);
//
////public delegate T Transformer<T>(T arg);
//
//class Util 
//{
//	// Idea -> This function will perform transformation on some values, but the logic is plugged from outside
//	public static void Transform<T>(T[] values, Transformer<T> t)
//	{
//		for(int i=0; i < values.Length; i++)
//		{
//			values[i] = t(values[i]); //MyTransform(values[i]);
//		}
//	}
//}
//
//// logic ?
//static int MyTransform(int x) => x * x * x;
//
//void Main()
//{
//	int[] values = { 1, 2, 3 };
//	Util.Transform(values, MyTransform);
//	foreach(int i in values)
//	{
//		Console.Write(i+ " ");
//	}
//}

// ---- Func & Action Delegates ----

// Func delegate -> can point to any function with no or more than 1 parameter and returning any type
//public delegate TResult Func<out TResult>();
//public delegate TResult Func<in T1, out TResult>(T1 arg);

// Action delegate -> can point to any function with no or more than 1 parameter and *does not return anything*
//public delegate void Action();
//public delegate void Action<in T1>();

// -- Example --
// Func<int,int> transformer -> supports -> int Logic(int x);
// Func<int, float> transformer -> supports -> float Logic(int x);
// Func<string> transformer -> supports -> string Logic();

// Action<string> transformer -> supports -> void Logic(string x);

// -- Non-generic
//class Util 
//{
//	// Idea -> This function will perform transformation on some values, but the logic is plugged from outside
//	public static void Transform(int[] values, Func<int,int> transformer)
//	{
//		for(int i=0; i < values.Length; i++)
//		{
//			values[i] = transformer(values[i]); //MyTransform(values[i]);
//		}
//	}
//}

// -- Generic
class Util 
{
	// Idea -> This function will perform transformation on some values, but the logic is plugged from outside
	public static void Transform<T>(T[] values, Func<T,T> transformer)
	{
		for(int i=0; i < values.Length; i++)
		{
			values[i] = transformer(values[i]); //MyTransform(values[i]);
		}
	}
}

// logic ?
static int MyTransform(int x) => x * x * x; // -> Func<int,int>

void Main()
{
	int[] values = { 1, 2, 3 };
	Util.Transform(values, MyTransform);
	foreach(int i in values)
	{
		Console.Write(i+ " ");
	}
}



