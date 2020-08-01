<Query Kind="Statements" />

// Introduction to C# and .NET

// ---- C#: general-purpose + type-safe + object-oriented ----

// general-purpose: cross-platform + several applications (Windows/Web/Progressive/Gaming)

// type-safe: type-driven (string, int, float, custom types)
// type-safe: compiler knows everything about your type at !!compile time!! (dynamic)
// dynamic a = 10;

// - object-oriented: OOPS - !(encapsulation + inheritance + polymorphism)!
// !TypeScript! = Javascript + Type (open-source)
// .ts -> .js

// 1 - *Unified* type sytem:
	// C# - ultimately they will all share the same type (Object)
	// .NET Framework - C#/F#/VB/....
	// VB Integer, C# int -> (Object)
	
// 2 - Classes + Interfaces
	// Interface - structure for a class
	
// 3 - Properties + Methods + Events

// !!! Type-Safety !!! (C#, Java, Python 3.5+ (typing), JS ES6+ :( )

	/*int a = 10;
	a = "boy";
	
	int GetItem(string val){
		return 10;
	}
	
	GetItem(10);
	*/

// !!! Memory Management !!!

// C# relies on CLR (Common Language Runtime) to do this !automatic! memory management.
// CLR - garbage collector

	// Common? - CLR (.NET Framework/Core - C#/F#/VB...)
	
	// C#(.cs) -> C# compiler -> IL (Intermediate Language)/ Assembly(.dll) -> CLR(execution)
	// F#(.fs) -> F# compiler -> MSIL/IL(.dll) -> CLR
	// .vb -> VB compiler -> IL(.dll) -> CLR
	
	// compiler - read codes line-by-line -> Machine language

// !!! Platform Support !!!

	// .NET CORE - cross platform development(windows/macOS/linux) for apps
	// Xamarin - mobile apps for ios + android
	// Blazor - compiles C# to web assembly - chrome/safari
	
// Windows platform:
	// UWP - Universal windows platform (.NET CORE + C#)
	// Win32(Windows 7) - WinRT(Windows 8/8.1) - (UWP - Windows 10/8.1/8)
	
	
// !!! CLR (Common Language Runtime) !!!

// CLR -> Automatic memory management + Exception handling

// C# - (managed language)
	// C# code - compiles to a 'managed code' (IL/MSIL)(.dll)
	// CLR converts the IL code into a 'native code' (x86, x64) - [Just-In-Time(JIT) compilation]
	// Native code - machine level(windows/macos) executable/which taken into memory
	
	// Windows console application
	// [C#(.cs)] -> C# compiler -> [Managed code(MSIL/IL)[.dll]] -> CLR -> native code(.exe) (JIT)
	// Deassembler ([dotpeek/MS]) - (.dll -> .cs files)
	
// !! Framework architecture !!
	// image
	 
// Legacy Frameworks
	// Windows Runtime(WinRT) for windows 8/8.1 -> now UWP (Windows 10/8/8.1)
	// Microsoft XNA for game development -> now UWP
	// .NET Core 1.x and 2.x (old - things are not updated!!)
	
// Windows Runtime (WinRT) -> !Windows 10!

// Win32 - object-oriented to Windows 7

// -- What are the new things C# 8.0 --
/*
// --- Indices

char[] vowels = new char[] {'a','e','i','o','u'};

// ^ searches for last element
char lastElement = vowels[^1];

char secondLastElement = vowels[^2];

lastElement.Dump();

secondLastElement.Dump();

// --- range (slicing)

char[] firstTwo = vowels[..2];

char[] lastThree = vowels[2..];

char[] middleOne = vowels[2..3];

char[] lastTwo = vowels[^2..];

firstTwo.Dump();

lastThree.Dump();

lastTwo.Dump();
*/

// Null-coalescing assignment (C# 8.0)

/*
string s = null;
if (s == null) s = "Hello World";

s ??= "Hello World";

s.Dump();
*/

// readonly members

/*struct Point {
	public int X,Y;
	public readonly void ResetX(int a, int b) => X = 0; //Error!
}*/







	
	





	
