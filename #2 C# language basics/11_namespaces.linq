<Query Kind="Program">
  <Namespace>static System.Console</Namespace>
</Query>

// Namespaces
// A namespace is a domain for type names
// Types are typically organized into <hierarchical namespaces>

// -- create custom hierarchical namespace --
/*
// 1st way
// using directive
namespace Outer.Middle.Inner
{
	class Class1 {}
	class Class2 {}
}

// 2nd way
namespace Outer
{
	class Class3 {}   // using Outer;
	namespace Middle
	{
		class Class6 {} // using Outer.Middle;
		namespace Inner
		{
			class Class1 {}  // using Outer.Middle.Inner;
			class Class2 {}	 // using Outer.Middle.Inner;
		}
	}
	
	namespace Middle2 
	{
		class Class4 {} // using Outer.Middle2;
	}
	
	// ..
	namespace Middle100 
	{
		class Class5 {} // using Outer.Middle100;
	}
}
*/

// using static directive
// ctrl + shift + m -> open directive space (linqpad)
// using static System.Console;
// imports all accessible static members of the type -> including fields, properties, nested types
/*
void Main()
{
	Console.WriteLine("Hello");
}
*/

// -- Rules within a namespace --

// -- Name scoping -> !! STRONGEST RULE !!
namespace Outer
{
	class Class1{}  // using Outer;
	
	namespace Inner
	{
		class Class2: Class1{} // Inheritance -> allowed!! 
	}
}

// using Outer.Inner -> Class2 is provided to me for usage!! 
// using Outer -> Class1 is provided

namespace MyTradingCompany.Common 
{
	
}

namespace MyTradingCompany.ManagementReporting
{

}

namespace MyTradingCompany
{
	namespace Common
	{
		class ReportBase {}
	}
	
	namespace ManagementReporting
	{
		class SalesReport: Common.ReportBase {}
	}
}

namespace ManagementReporting2
{
	using MyTradingCompany.Common;
	class SalesReport: ReportBase {}
}

// -- Name hiding --

namespace Outer
{
	class Foo { }
	
	namespace Inner
	{
		class Foo { }
		
		class Test
		{
			Foo f1;   		// = Outer.Inner.Foo
			Outer.Foo f2; 	// = Outer.Foo
		}
	}
}

// -- Repeated Namespaces --
// System.Collections.Generic -> List, Dictionary
namespace Outer.Middle.Inner
{
	class Class1 {}
}

namespace Outer.Middle.Inner
{
	class Class2 {}
}

// Namespace alias qualifiers
// global keyword + :: - alias qualification operator
// !! you will see this in autogenerated code to avoid name conflicts !!
// global::A is looking for namespace A outside of the current namespace (N)
namespace N
{
	class A
	{
		static void Main()
		{
			new A.B();      	// Instantiate Class B
			new global::A.B(); 	// global space and use namespace A and class B
		}
		// property
		public class B {};		// Nested type
		//public static int C;
	}
}

namespace A
{
	class B {}			// global::A.B();
}
