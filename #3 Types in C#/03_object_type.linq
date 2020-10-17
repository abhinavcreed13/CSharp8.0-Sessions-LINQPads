<Query Kind="Program" />

// -------------- The Object Type ---------------

// object (System.Object) - ultimate base class for all types
// Any type can be upcast to object

// LIFO data structure
public class Stack
{
	int position;
	object[] data = new object[10];
	public void Push(object obj)
	{
		// if position = 0 -> data[0] and then position = 1
		data[position++] = obj;
	}
	public object Pop()
	{
		// if position = 1 -> position = 0 and then data[0]
		// position = 3 -> position = 2 then data[2] -> sausage 3
		return data[--position];
	}
}

//void Main()
//{
//	Stack stack = new Stack();
//	stack.Push("sausage");					//implicit upcast: string to object
//	stack.Push("sausage 2");
//	stack.Push("sausage 3");
//	stack.Push(12);
//	stack.Push(12.5667);
//	object s = stack.Pop();					//explicit downcast: Object to string
//	//string s = (string) stack.Pop();
//	Console.WriteLine(s);
//}

// -- Boxing and Unboxing ~ Upcast and Downcast

//void Main()
//{
//	int x = 9;
//	object obj = x;			// Box the int ~ Upcast because object is the base class of int
//	
//	int y = (int)obj;		// Unbox the int ~ Downcast
//	
//	object obj2 = 9;
//	long z = (long)obj2;	// Unboxing -> object(int) -> long
//}

// -- GetType Method and typeof Operator
// GetType -> evaluated at runtime
// typeof -> evaluated statically at compile time
// Always returns System.Type class object

// -- MVC --
// [Required]
// public string Name;

// [AllowAnonymous]
// public void Call() { }

public class Point { public int X,Y; }

//void Main()
//{
//	Point p = new Point();
//	Console.WriteLine(p.GetType().Name);				// Point ~ <Reflection> -> class name of the object p
//	Console.WriteLine(typeof(Point).Name);				// typeof(Point) ~ Type object -> Name property
//	Console.WriteLine(p.GetType() == typeof(Point));	// True
//	Console.WriteLine(p.X.GetType().Name);				// What are you X?
//	Console.WriteLine(p.Y.GetType().FullName);			// What are you Y?
//}

public class Panda
{
	public string Name;
	public string LastName;
	public override string ToString() => Name + " " + LastName;
}

void Main()
{
	Panda p = new Panda { Name = "Mark", LastName = "222" };
	Console.WriteLine(p.ToString());
}

