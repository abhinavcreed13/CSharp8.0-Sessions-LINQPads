<Query Kind="Program" />

// -- Interfaces --
// Interface is similar to a class, but only specifies **behavior** and does not hold state(data)
// - Interface can define only functions and not fields
// - Interface members are implicity abstract -> enforces you to override/implement them
// - Class/struct can implement multiple interfaces !!
// - !! Dependency Injection !!

// Application of Interface - implicit upcasting for code reusability
internal class Countdown: IEnumerator
{
	int count = 11;
	public bool MoveNext() => count-- > 0;
	public object Current => count;
	public void Reset() { throw new NotSupportedException(); }
}

internal class Countdown2: IEnumerator
{
	int count = 20;
	public bool MoveNext() => count-- > 0;
	public object Current => count;
	public void Reset() { throw new NotSupportedException(); }
}

internal class Countdown3: IEnumerator
{
	int count = 30;
	public bool MoveNext() => count-- > 0;
	public object Current => count;
	public void Reset() { throw new NotSupportedException(); }
}

//object GetData(Countdown c){
//	return c.Current;
//}
//
//object GetData(Countdown2 c){
//	return c.Current;
//}
//
//object GetData(Countdown3 c){
//	return c.Current;
//}

object GetData(IEnumerator e){
	return e.Current;
}

void Main()
{
	//IEnumerator e = new IEnumerator();
	//IEnumerator e = new Countdown();
	Countdown c1 = new Countdown();
	Countdown2 c2 = new Countdown2();
	Countdown3 c3 = new Countdown3();
	while(c3.MoveNext()) // e.MoveNext() -> c.MoveNext()
	{ 
		Console.WriteLine(GetData(c3)); // Implicit upcasting to IEnumerator
	}
}

