<Query Kind="Program" />

// ~~~~~~~~~~ Classes ~~~~~~~~~~~~

// class - most common kind of reference type
// Preceding keywords - public, internal, abstract, sealed, static, unsafe, partial

// Field - is a variable that is a member of a class or struct (or attributes)
// --> variable should be inside the scope of the class
class Octopus
{
	string name; 			// field - by default private
	public int Age = 10; 	//field
	string name2 = "ABC";   // field
	
	public void callX()
	{
		string x = "abc";  // just a local variable
	}
}

// -------- Constants ----------
// const keyword - evaluated statically at compile time and the compiler literally substitutes its value whenever used
// differs from readonly field -> readonly field can be assigned inside constructor
public class Test
{
	public const string Message = "Hello World";  // Field initilization - allowed!!
	
	public const double PIE = 3.145678;
	
	public readonly double radius;   // this is not const, but read-only
	
	public Test(int radius)
	{
		//Message = "Hello World2";  // not allowed
		this.radius = radius;		// allowed
	}
	
	public void CallX()
	{
		//Message = "new message";   // not allowed
		// radius = 40; 			// not allowed
	}
}

// ------------ Methods -------------
// method performs an action in a series of statements
// !! method can recieve input data by parameters and have output data back !!
// method have a !!signature!! -> signature is name, parameters, function return type, access modifier

// Method modifiers:
// static modifier -> static
// access modifiers -> public, internal (assemblies/namespaces), private, protected
// inheritance modifiers -> new, virtual, abstract, override, sealed
	// virtual -> make function optional to implement
	// abstract -> make function mandatory to implement
// partial method modifiers -> partial
// unmanaged code (any code that is not running on .NET/CLR) modifiers -> unsafe, extern
// Asynchronous code modifier -> async


// Overloading Methods - Compile-Time polymorphism
	// - this is not same as "Overriding" methods - Run-Time polymorphism
// type can overload methods (have multiple methods with the same name) as long as the `signatures` are different
// rule -> return type should be same otherwise compile-time error
// order of parameters important for right function call
/*
void Foo(int x)
{

}

void Foo(double x)
{

}

void Foo(int x, float y)
{

}

float Foo(int x)
{

}
*/

// ---------- Instance Constructors ----------
// Constructors run <initilization code> on a class or struct
// Modifiers:
// Access modifiers: public, private(singleton design pattern), protected, internal
/*
public class Panda
{
	string name; 		// field
	
	public Panda(string n)		// define constructor
	{
		name = n;
	}
}
*/
// Overloading constructors + <properties>
public class Wine
{
	private decimal _Price;
	
	public int Year;
	
	// this is used to expose my private fields
	public decimal Price {
		get { return _Price; }
		set { _Price = value; }
	}
	
	public Wine(decimal price)
	{
		_Price = price;
	}
	
	public Wine(decimal price, int year) : this(price)   // overloaded constructor
	{
		//_Price = price; // this can be avoided
		Year = year;
	}
}

//void Main()
//{
//	Wine w = new Wine(10);
//	w.Price = 20;   // fire the Price set function
//	Console.WriteLine(w.Price); // fire the Price get function
//}

// ---------- Destructors ---------- 
// does the reverse and assigns fields back to a set of variables
class Rectangle
{
	public readonly float Width, Height;
	
	public Rectangle(float width, float height)
	{
		Width = width;
		Height = height;
	}
	
	// destructor
	public void Deconstruct(out float width, out float height)
	{
		width = Width;
		height = Height;
	}	
}

/*void Main()
{
	var rect = new Rectangle(3,4); // fire my constructor
	(float width, float height) = rect;			// deconstruction
	Console.WriteLine(width + " "+ height);
}*/

// --------- Object Initializers --------------
// introduced in C# 3.0
public class Bunny
{
	public string Name;	// field
	public bool LikesCarrots;
	public bool LikesHumans;
	
	public Bunny() {}
	public Bunny(string n){ Name = n; }
}

/*void Main()
{
	// object initializers
	// will only work if fields are public
	Bunny b1 = new Bunny {
		Name = "Bo",
		LikesCarrots = true,
		LikesHumans = false
	};
	
	Bunny b2 = new Bunny("bo");
	b2.LikesCarrots = true;
	
	List<Bunny> vals = new List<Bunny>();
	vals.Add(new Bunny("bo1"));
	vals.Add(new Bunny("bo2"));
	vals.Add(new Bunny("bo3"));
	
	// object initializer - list initializer syntax
	List<Bunny> vals2 = new List<Bunny> {
		new Bunny("bo1"),
		new Bunny("bo2"),
		new Bunny("bo3")
	};
}*/

// --------- The 'this' reference -----------
// 'this' reference refers to the instance itself
// this will be the one who is calling it or method
public class Panda
{
	public Panda Mate;
	
	public string Name;
	
	public void Marry(Panda partner)
	{
		Mate = partner; // save reference of p2 to Mate
		partner.Mate = this;   // this here is p1 because p1.Marry(p2);
	}
}

void Main()
{
	Panda p1 = new Panda { Name = "p1" };
	Panda p2 = new Panda { Name = "p2" }; // get reference - init
	
	p1.Marry(p2); // passed reference of p2
	
	Console.WriteLine(p1.Mate.Name);
	Console.WriteLine(p2.Mate.Name);
}

// --------- Properties ----------





