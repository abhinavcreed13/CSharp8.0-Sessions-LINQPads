<Query Kind="Program" />

// ---- Generics ----
// C# -> 2 seperate mechanisms for writing code that is reusable across different types -> Inheritance + Generics

// Generics -> increase type safety + reduce casting and boxing

// -- Generic Types --
// A generic type declares type parameters - placeholder types to be filled in by the consumer of the generic type

// Generic class
// T -> can be of any custom name -> as long as you declare on top of class/function name
public class Stack<T, T2>
{
	int position;
	
	T[] data = new T[100];
	T2[] data2 = new T2[100];
	
	public void Push(T obj) => data[position++] = obj;
	
	public T Pop() => data[--position];
}

// This is clearly not type safe
// data.push(10);
// data.push("Abc");

class myworld {
}

//void Main()
//{
//	//List<int> list = new List<int>();
//	var stack = new Stack<int>();	
//	stack.Push(5);
//	//stack.Push(10.5);
//	
//	var stack2 = new Stack<string>();
//	stack2.Push("abc");
//	
//	var stack3 = new Stack<myworld>();
//	
//	//var stack4 = new Stack<T>();
//}

// -- Generic methods --
// for making a function generic or take T -> mark it with <T> after function name
static void Swap<T>(ref T a, ref T b){
	T temp = a;
	a = b;
	b = temp;
}

//void Main()
//{
//	int x = 5;
//	int y = 10;
//	Swap(ref x, ref y);
//	
//	// primitive type -> value type
//	string x1 = "abc"; // derives from class -> value type
//	string x2 = "bcd"; // derives from class -> value type
//	Swap(ref x1, ref x2);
//	
//	Console.WriteLine(x);   // 5
//	Console.WriteLine(y);   // 10
//	
//	Console.WriteLine(x1);   
//	Console.WriteLine(x2);   
//}

// Generic supports -> multiple parameters
// public class Dictionary<TKey, TValue>
//void Main()
//{
//	Dictionary<string, int> dict = new Dictionary<string, int>();
//	dict.Add("abhinav",750000);
//	Console.WriteLine(dict["abhinav"]);
//}

// -- Generic constraints --
// Possible constraints:
// 1. where T: base-class //base-class constraint
// 2. where T: interface
// 3. where T: class
// 4. where T: class? 
// 5. where T: struct
// 6. where T: unmanaged
// 7. where T: new()   // parameterless constructor
// 8. where T: notnull	// Non-nullable value types


// syntax
// public class Dictionary<TKey, TValue> where TKey : notnull
// since TKey can take any type and having key as null doesn't make sense, so notnull constraint
class SomeClass {}
interface Interface1 {}

class GenericClass<T,U> where T: SomeClass, Interface1
						where U: new()
{
	
}



