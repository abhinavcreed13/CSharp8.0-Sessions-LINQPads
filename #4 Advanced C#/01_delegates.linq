<Query Kind="Program" />

// --- Delegates ---

// delegate is an *object* that knows how to call a method
// -- informal: pointer to a real function --

// -- exclusive to javascript --
// var fn = function(){
// 	 console.log("I am clicked");
// };
// fn -> working as delegate
// $("#id").click(fn);

// -- A delegate *type* defines the kind of method that delegate instances can call --

// This below delegate can call any method/ This below delegate can store pointer of any method
// if it's return type is `int` and it takes a parameter of `int`

// example delegate
delegate int Transformer(int x);

// methods
static int Square(int x) { return x * x; }

static void Name(int x) { x = x + 1; }

void Main()
{
	// Storing
	// same thing
	Transformer t1 = new Transformer(Square);
	// Transformer t1 = Square;		// better
	
	// Transformer t2 = Name;
	
	// same syntax
	Console.WriteLine(t1(2));  // better
	Console.WriteLine(t1.Invoke(2));
}


