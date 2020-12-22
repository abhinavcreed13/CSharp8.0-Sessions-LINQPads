<Query Kind="Program" />

// ~~~~~~~~~~ Classes ~~~~~~~~~~~~

// class - most common kind of reference type
// Preceding keywords - public, internal, abstract, sealed, static, unsafe, partial

// Field - is a variable that is a member of a class or struct (or attributes)
// --> variable should be inside the scope of the class

// If you create a field directly, it will never auto-generate any property
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

// return type should be same otherwise compile-time error
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
	
	public Wine(decimal price4)
	{
		_Price = price4;
	}
	
	public Wine(decimal price2, int year) : this(price2)   // overloaded constructor
	{
		//_Price = price; // this can be avoided
		Year = year;
	}
	
	// new Wine(10, 2004, 12)
	// order of this(price, year) is important to call right constructor with correct data
	public Wine(decimal price, int year, int val) : this(price, year)
	{
		
	}
}

//
//void Main()
//{
//	Wine w = new Wine(10, 2004);
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
	// function name has to match deconstruct (by convention)
	public void Deconstruct(out float width, out float height)
	{
		width = Width;
		height = Height;
	}	
}

//void Main()
//{
//	var rect = new Rectangle(3,4); // fire my constructor
//	(float width, float height) = rect;			// deconstruction
//	Console.WriteLine(width + " "+height);
//}

// --------- Object Initializers --------------
// introduced in C# 3.0
public class Bunny
{
	public string Name;	// field
	public bool LikesCarrots;
	public bool LikesHumans;
	
	public Bunny() {}
	public Bunny(string Name){ 
	this.Name = Name; 
	}
}
/*
void Main()
{
	// object initializers
	// will only work if fields are public
	// will only work with default constructor
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
	
	List<int> i = new List<int> { 1, 2, 3 };
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
		//Console.WriteLine(this.name);
		partner.Mate = this;   // this here is p1 because p1.Marry(p2);
	}
}

//void Main()
//{
//	Panda p1 = new Panda { Name = "p1" };
//	Panda p2 = new Panda { Name = "p2" }; // get reference - init
//	
//	p1.Marry(p2); // passed reference of p2
//	
//	//p2.Marry(p1);
//	
//	Console.WriteLine(p1.Mate.Name);
//	Console.WriteLine(p2.Mate.Name);
//}

// --------- Properties ----------
public class Stock
{	
	// GENERAL PATTERN
	decimal currentPrice, sharesOwned = 12; 		// private "backing" field
	
	public decimal CurrentPrice		// public property
	{
		get { return currentPrice; }
		set { currentPrice = value; }
	}
	
	public decimal NewCurrentPrice { get; set;}  // it is implicitly having backing field
	
	// read-only property
	//public decimal Worth
	//{
	//	get { return currentPrice * sharesOwned; }
	//}
	
	// --- expression-bodied properties ---
	//public decimal Worth => currentPrice * sharesOwned;
	
	public decimal Worth 
	{
		get => currentPrice * sharesOwned;
		set => sharesOwned = value/currentPrice;
	}
	
	// Automatic properties
	public decimal AutoCurrentPrice { get; set; }
	
	// Property initializers
	public decimal AutoCurrentPrice2 { get; set; } = 123;
	public int Maximum { get; } = 999;
	
	public void Add()
	{
		currentPrice = currentPrice + 1;	// private
		CurrentPrice = CurrentPrice + 1;	// public
		AutoCurrentPrice = 123;
	}
}

//void Main()
//{
//	Stock msft = new Stock();
//	msft.CurrentPrice = 30;	// fired set
//	msft.CurrentPrice -= 3;
//	Console.WriteLine(msft.CurrentPrice);	// fired get
//	Console.WriteLine(msft.Worth);
//	//msft.Worth = 10; // not allowed - read-only property
//}

// get + set accessibility
public class Foo
{
	private decimal x;
	public decimal Xprop
	{
		get => x;
		// can only be set inside the class
		private set { 
			// many lines logic
			//....
			x = Math.Round(value, 2); //123.12
		}
	}
	
	// constructor
	public Foo()
	{
		x = 123.12344M;
		Xprop = 123.123455M;  // This works - because I'm inside class
	}
}

//void Main()
//{
//	Foo f = new Foo();
//	Console.WriteLine(f.Xprop);
//	f.Xprop = 12.345M;
//}

// -------------- Indexers ----------------
class Sentence
{
	string[] words = new string[5];
	
	public Sentence(string s)
	{
		words = s.Split();
	}
	
	// pattern for indexer
	public string this[int wordNum]		// indexer
	{
		get { return words[wordNum]; }
		set { words[wordNum] = value; }
	}
	
	//public Person this[int index]
	//{
	//	get { return persons[index]; }
	//}
}

//void Main()
//{
//	string s = "hello there";
//	Console.WriteLine(s[0]);
//	Console.WriteLine(s[2]);
//	//s[0] = "t";
//	
//	// want to implement indexing for words?
//	Sentence s2 = new Sentence("The quick brown fox");
//	//List<person> people = new List<person>();
//	//People p = new People();
//	//p[0] -> person 1
//	//p[1] -> person 2
//	//Restaurants r = new Restuarnts();
//	//r[0] -> restaurant 1
//	Console.WriteLine(s2[0]); // The
//	Console.WriteLine(s2[1]); // quick
//	//s2[0] = "The2";
//	//s2[0] = "More";
//	//Console.WriteLine(s2[0]);
//	for(int i=0;i<3;i++){
//		Console.WriteLine(s2[i]);
//	}
//}

// -------------- Static Constructors -----------------
// created a class that is initilized only ONCE!!
class Test2
{
	public static string name;
	static Test2()
	{	
		name = "abc";
		Console.WriteLine("Type Initialized");
	}
}

class Foo2 
{
	//public static int Y = 3;
	//public static int X = Y;
	
	// static is assigned memory - line by line
	public static Foo2 Instance = new Foo2();
	public static int X = 3;
	public int Y {get;set;} = 23;
	
	public Foo2()
	{
		Console.WriteLine(X);  // 0
	}
}

void Main()
{
	Test2 t1 = new Test2();
	Test2 t2 = new Test2();
	Console.WriteLine(Test2.name);
	
	Console.WriteLine(Foo2.X); // 3
	
	Foo2 foo = new Foo2();
	//Console.WriteLine(Foo2.Y); // wont' work: because we need constructor/object to access it
	Console.WriteLine(foo.Y);
}

// ------ Partial Types & Methods ----------
// partial methods -> needs implementation signature in 1 class, then only you can implement it
partial class PaymentForm 
{
	partial void ValidatePayment(decimal amount);
}

partial class PaymentForm
{
	partial void ValidatePayment(decimal amount)
	{
		if(amount > 100){
			Console.WriteLine(amount);
		}
	}
}

// ------------ nameof -------------
// nameof operator returns the name of any symbol
// advantage: rather than specifying string, you can use variables -> compile-time safety
// extremely useful for: RedirectToAction -> takes name of the function
//void Main()
//{
//	int count = 123;
//	string name = nameof(count);
//	string name2 = nameof(StringBuilder.Length);
//	Console.WriteLine(name2);
//}








