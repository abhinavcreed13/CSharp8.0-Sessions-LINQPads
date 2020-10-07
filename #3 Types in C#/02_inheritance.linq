<Query Kind="Program" />

// ----------------- Inheritance ------------------

// Most important concept of OOPS

// Using inheritance, you can create <loosly-coupled modules>

// Interface - kind of functions(memo) - No constructor (No memory initilization)
// abstract class - no constructor
public interface IAsset
{
	public void Display();
}

public class Stock2: IAsset
{
	public string Name; // field
	
	public void Display()
	{
		Console.WriteLine("HEllo");
	}
}

// parent class
// had a constructor - memory allocation
//public class Asset
//{
//	public string Name; // field
//}
//
//// child class
//public class Stock : Asset // inherits from Asset
//{
//	public long SharesOwned;
//}
//
//// child class
//public class House: Asset
//{
//	public decimal Mortgage;
//}


//void Main()
//{
//	// Object initilization syntax
//	// first: It fires the default constructor of Asset, then Stock
//	Stock msft = new Stock { SharesOwned = 1000, Name = "MFST" };
//	
//	Console.WriteLine(msft.Name);
//	Console.WriteLine(msft.SharesOwned);
//	
//	House mansion = new House { Name = "Mansion", Mortgage = 250000 };
//	Console.WriteLine(mansion.Name);
//	Console.WriteLine(mansion.Mortgage);
//	//Console.WriteLine(mansion.SharesOwned) // won't work
//}

// ---------- Polymorphism ----------
// --> Compile-time polymorphism - compiler knows about what you are doing with function - function overloading
// --> Run-time polymorphism - complier doesn't know what's happening at compile time - function overridding (virtual/override)

// !! References are polymorphic !!
// References can change forms - default nature
//public static void Display(Asset asset)
//{
//	Console.WriteLine(asset.Name);
//}

// -- Function overloading
// Same function name with different parameters
//public static void Display(Stock asset)
//{
//	Console.WriteLine(asset.Name);
//}
//
//public static void Display(House asset)
//{
//	Console.WriteLine(asset.Name);
//}

//void Main()
//{
//	Stock msft = new Stock { SharesOwned = 1000, Name = "MFST" };
//	House mansion = new House { Name = "Mansion", Mortgage = 250000 };
//	Display(msft);		// Asset asset = msft
//	Display(mansion);
//}

// ---- Casting & Reference Conversions ----
// - Implicitly upcast to a base class reference
// - Explicitly downcast to a subclass reference

// Upcasting
//void Main()
//{
//	Stock msft = new Stock();
//	Asset a = msft;						// Upcast - implicitly (short-circuit)
//	Console.WriteLine(a == msft);
//	//Console.WriteLine(a.Name);			// call -> msft.Name
//	//Console.WriteLine(a.SharesOwned);		// not possible
//	//
//	//Stock2 msft2 = new Stock2();
//	//Console.WriteLine(msft2.Name);		// allowed
//	//
//	//IAsset i = new IAsset();			// because there is no constructor (memory allocation)
//	//
//	//IAsset a2 = msft2;					//Upcast - implicitly
//	//a2.Display(); 						// call -> msft2.Display();
//	//Console.WriteLine(a2.Name);			// not possible
//}

// Downcasting
//void Main()
//{
//	// ref: AXG6678
//	Stock msft = new Stock {SharesOwned = 100};
//	// I played with references
//	// a = AXG6678
//	Asset a = msft;						// Upcast
//	// s = AXG6678
//	Stock s = (Stock)a;					// Downcast - explicit
//	Console.WriteLine(s.SharesOwned);
//	Console.WriteLine(s == a);
//	Console.WriteLine(s == msft);
//}

// Upcasting - only references are affected - not the underlying object
// downcast - potential of failing at runtime

//void Main()
//{
//	House h = new House();
//	Asset a = h;				// upcasted to Asset
//	Stock s = (Stock)a;			// downcasted to stock? - InvalidCastException
//}

// -- as operator
// If casting can happen -> then do it otherwise assign null
//void Main()
//{
//	Asset a = new Asset();
//	//Stock s1 = (Stock)a;
//	Stock s2 = a as Stock; // s2 is null (downcasting)
//}

// -- is operator
// tests whether a variable matches a pattern
//void Main()
//{
//	//Asset a = new Asset();
//	Stock msft = new Stock { SharesOwned = 100};
//	Asset a = msft;
//	//if(a is Stock)
//	//{
//	//	Console.WriteLine((a as Stock).SharesOwned);
//	//}
//	// -- Introduced a pattern variable -- (C# 7+)
//	if(a is Stock s)
//	{
//		Console.WriteLine(s.SharesOwned);
//	}
//	if(a is Stock s1 && s1.SharesOwned > 100)
//	{
//		Console.WriteLine("Wealthy");
//	}
//}

// --- Virtual Function Members ---
// Runtime polymorphism
// function overridding

// virtual: methods, properties, indexers, events

// virtual properties
//public class Asset
//{
//	public string Name; // field
//	public virtual decimal Liability => 0;		// expression-bodied property
//}
//
//// child class
//public class Stock : Asset // inherits from Asset
//{
//	public long SharesOwned;
//}
//
//// child class
//public class House: Asset
//{
//	public decimal Mortgage;
//	public override decimal Liability => Mortgage;
//}

//void Main()
//{
//	Asset b = new Asset();
//	Console.WriteLine(b.Liability);	
//	
//	House mansion = new House { Name = "McMansion", Mortgage = 25000 };
//	Asset a = mansion;						// upcast - connected references
//	Console.WriteLine(mansion.Liability);	// 25000
//	Console.WriteLine(a.Liability);			// 25000 (it can't be 0) calling -> mansion.Liability
//}

// --- Abstract Classes & Abstract Members ---
// Abstract class - no constructor - cannot be instantiated
// using this abstract class - I can create concrete subclasses
// Abstract class - !! define abstract members !!

//public abstract class Asset
//{
//	// not possible with interface
//	public abstract decimal NetValue {get; }
//}
//
//public class Stock: Asset
//{
//	public long SharesOwned;
//	public decimal CurrentPrice;
//	
//	public override decimal NetValue => SharesOwned * CurrentPrice;
//}

//void Main()
//{
//	//Asset a = new Asset(); 				// Not possible
//	Stock msft = new Stock { SharesOwned = 100, CurrentPrice = 50 };
//	Console.WriteLine(msft.NetValue);
//	Asset a = msft;  					// upcast - connecting references (Asset is abstract and object can't be created)
//	Console.WriteLine(a.NetValue);		// called -> msft.NetValue
//}

// --- Hiding Inherited Members ---
//public class A
//{
//	public int Counter = 1;
//}
//
//public class B: A
//{
//	// I am hiding inherited member
//	// public int Counter = 2;
//		
//	// new modifier -> does nothing more than suppress the compiler warning
//	public new int Counter = 2;
//}

//void Main()
//{
//	B b = new B();
//	Console.WriteLine(b.Counter);
//}

// new vs override
//public class BaseClass
//{
//	public virtual void Foo() { Console.WriteLine("BaseClass.Foo"); }
//}
//
//public class Overrider: BaseClass
//{
//	public override void Foo() { Console.WriteLine("Overrider.Foo"); }
//}
//
//public class Hider: BaseClass
//{
//	public new void Foo() { Console.WriteLine("Hider.Foo"); }
//}

//void Main()
//{
//	Overrider over = new Overrider();
//	BaseClass b1 = over;				// upcast - connecting references
//	over.Foo();							// Overrider.Foo
//	b1.Foo();							// called -> over.Foo() -> Overrider.Foo
//	
//	Hider h = new Hider();
//	BaseClass b2 = h;					// upcast - connecting references
//	h.Foo();							// Hider.Foo
//	b2.Foo();							// called -> b2.Foo() -> BaseClass.Foo
//}

// -- base keyword
public class Asset
{
	public string Name; // field
	public virtual decimal Liability => 20;		// expression-bodied property
	
	public virtual int D()
	{
		// kind of logic
		return 20;
	}
}

// child class
public class Stock : Asset // inherits from Asset
{
	public long SharesOwned;
}

// child class
public class House: Asset
{
	public decimal Mortgage;
	public override decimal Liability => base.Liability + Mortgage;
	
	public override int D()
	{
		int a = base.D();
		return a + 30;
	}
}

//void Main()
//{
//	House h = new House();
//	Console.WriteLine(h.D());
//}

// -- Constructors + Inheritance --

// Constructor chaining
public class Baseclass
{
	public int X;
	public Baseclass() {
		Console.WriteLine("Base default called");
	}
	public Baseclass(int x) 
	{ 
		Console.WriteLine("Base parameterized called");
		this.X = x; 
	}
}

public class Subclass: Baseclass {
	public int Y;
	public Subclass() {
		Console.WriteLine("Subclass default called");
	}
	
	public Subclass(int y): base(y)
	{
		Console.WriteLine("Subclass parameterized called");
		this.Y = y;
		Console.WriteLine(this.X);
	}
}

// Outside world
void Main()
{
	// 	Subclass s = new Subclass();
	
	Subclass s2 = new Subclass(20);
}

// Destructors -> order is from calling destructor of derived class to the base class
// Constructors -> order is from calling constructor of base class to the derived class



