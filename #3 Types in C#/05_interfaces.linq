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
	public void ABC() {}
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
//
//void Main()
//{
//	//IEnumerator e = new IEnumerator();
//	Countdown3 c = new Countdown3();
//	c.ABC();
//	IEnumerator e = new Countdown3();
//	e.ABC();
//	Countdown c1 = new Countdown();
//	Countdown2 c2 = new Countdown2();
//	Countdown3 c3 = new Countdown3();
//	while(c3.MoveNext()) // e.MoveNext() -> c.MoveNext()
//	{ 
//		Console.WriteLine(GetData(c3)); // Implicit upcasting to IEnumerator
//	}
//}

// -- Extending an Interface --

// This is a valid syntax - interface can derive other interfaces
//public interface IUndoable { void Undo(); }
//public interface IRedoable: IUndoable { void Redo(); }

// We need to implement both methods - Undo() and Redo()
//public class RedoType: IRedoable
//{
//  public void Redo() {}  
//  public void Undo() {}
//}

// -- Explicit Interface Implementation --

public interface I1 { void Foo(); }
public interface I2 { int Foo(); }

// This is multiple inheritance which is only possible with interfaces
public class Widget: I1, I2
{
   public void Foo() {
   		Console.WriteLine("I1.Foo()");
   }
   
   int I2.Foo() {
   		Console.WriteLine("I2.Foo()");
   		return 0;
   }
}

//void Main()
//{
//	Widget w = new Widget();
//	w.Foo(); // Widget's implementation of I1.Foo
//	//I2 i2 = w;
//	//i2.Foo();
//	((I2)w).Foo(); // This will call widget's I2.Foo implementation
//}

// -- Implementing Interface Members Virtually --

public interface IUndoable { void Undo(); }

public class TextBox: IUndoable
{
	public virtual void Undo() => Console.WriteLine("TextBox.Undo");
}

public class RichTextBox: TextBox
{
	public void A() {}
	public override void Undo() => Console.WriteLine("RichTextBox.Undo");
}

// practical example of Upcasting concept - Inheritance
// IUndoable obj = r (this will happen at runtime)
public void Display(IUndoable obj)
{
	//obj.Undo() -> r.Undo();
}

void Main()
{
	RichTextBox r = new RichTextBox();
	r.Undo(); // RichTextBox -> Undo
	
	// making r -> TextBox
	TextBox t = r;
	t.Undo(); //  RichTextBox -> Undo
	((TextBox)r).Undo();
	
	// making r -> IUndoable
	//IUndoable i = r;  // this is same as ((IUndoable)r)
	//i.Undo();
	IUndoable i = r;
	i.Undo();
	((IUndoable)r).Undo(); 
	// This is not possible because IUndoable is having no A() method -> even though Richtextbox has
	//i.A();
	//((IUndoable)r).A();
	
	// Will be implicitly casted to IUndoable object
	// IUndoable obj = r;
	Display(r);
}

// 1 Utility -> !! Dependency Injection !! - microservices !!


