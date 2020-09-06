<Query Kind="Program">
  <Namespace>System.Threading.Tasks</Namespace>
</Query>

// ---- Threading ----

// thread: execution path that can proceed independently of others

// single-threaded program: main()
// multi-threaded program: main() -> internal threads (multiple threads in a single process)

// create a thread
/*
void WriteY()
{
	for(int i=0;i<1000;i++)
	{
		Console.Write("y");
	}
}

void Main()
{
	Thread t = new Thread(WriteY);
	t.Start();
	
	for(int i=0;i<1000;i++)
	{
		Console.Write("x");
	}
}
*/

// Join and Sleep
/*
void Go()
{
	for(int i=0;i<1000;i++)
	{
		Console.Write("y");
	}
}
void Main()
{
	Thread t = new Thread(Go);
	t.Start();
	Thread t2 = new Thread(Go);
	t2.Start();
	Thread t3 = new Thread(Go);
	t3.Start();
	t.Join();  // stop my main thread until t is completed
	t2.Join();
	t3.Join();
	Console.WriteLine("Thread t has ended!");
}
*/

// Local vs shared state
// Local state: CLR assigns each thread its own memory stack so that local variables are kept seperate
/*
void Go()
{
	for(int cycles=0; cycles<5; cycles++)
	{
		Console.WriteLine('?');
	}
}

void Main()
{	
	new Thread(Go).Start(); // cycles
	Go();  // cycles
}
*/

// shared state
/*
class ThreadTest
{
	bool _done; //field - default false
	
	public static void Main()
	{
		ThreadTest tt = new ThreadTest();
		new Thread(tt.Go).Start(); // called GO
		tt.Go(); // called Go in the main thread
	}
	
	
	void Go()
	{
		if(!_done) 
		{	
			_done = true;
			Console.WriteLine("Done");
		}
	}
}

void Main()
{
	ThreadTest.Main();
}
*/

// --- Exception Handling ----
/*
void Go()
{
	try
	{
		throw null;
	}
	catch(Exception ex)
	{
		// logging in a file
		// !!800!! -- disaster
	}
}

void Main()
{
	try
	{
		new Thread(Go).Start();
	}
	catch(Exception ex)
	{
		// I will never reach here!!
		Console.WriteLine("Exception!");
	}
}
*/
// --- Thread Pool ---
// whenever you start a thread, a few hundred microseconds are spend organizing such things as fresh local variables stack
// Solved -> !! thread pool cuts this overhead by having a pool of pre-created recyclable threads !!

// ThreadPool.QueueUserWorkItem(Go) -> this will pick thread from thread pool

void Go()
{
	Console.WriteLine("Hello from the thread pool");
}

void Main()
{
	// Thread t = new Thread(Go);
	// t.Start();
	Task.Run(Go);
}

// Oversubscription -> condition of placing more active thread than CPU cores (time slicing in CPU/OS)
// performance overhead - normal threading classes
// Task class -> adjusting the workload stuff
