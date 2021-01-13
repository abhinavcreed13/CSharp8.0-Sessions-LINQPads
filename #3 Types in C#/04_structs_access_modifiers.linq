<Query Kind="Program" />

// Structs
// 1. A struct is a value type <-> class is a reference type
// 2. A struct does not support inheritance -> structs can't be used as base structs for others

public struct Point
{
	int x,y;
	// int x = 1;						// Illegal: field initializer
	// public Point() {} 				// Illegal: Parameterless constructor
	public Point(int x, int y) {
		this.x = x;
		this.y = y;
	}
	//public Point(int x) { 			   // Illegal: must assign field y
	//	this.x = x;
	//}
}

void Main()
{
	Point p1 = new Point();
	Point p2 = new Point(1,1);
}

// -- Access Modifiers --
// public - fully accessible -> enum/interface - implicitly public
// internal - accessible only within the containing assembly/namespace or friend assemblies
// private - accessible only within the containing type
// protected - accessible only within the containing type or subclasses (inheritance!!)
// protected internal - union of internal + protected
// private protected (C# 7.2+) - intersection of protected and internal accessibility





