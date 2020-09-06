<Query Kind="Program">
  <Namespace>System.Threading.Tasks</Namespace>
</Query>

// --- Tasks ---

// Task - it is a thread which is a low-level tool for creating concurrency

// Why Task?
// 1. Although it is easy to pass data into a thread that you start, there is no easy way to get a "return value" back
	// If you want a return data, you have to use shared state or field - which is very complicated
// 2. Exception handling is bad and tricky.
// 3. You can't know when the thread is finished, you have to do 'Join' to know that thread is finished.
// 4. Direct use of threads also has performance implications

// TASK class helps with ALL of these problems
// Introduced in Framework 4.0+

// This task was enhanced with 'awaiters' (4.5+)

// Starting a Task
/*
void Main()
{
	// new Thread(() => Console.WriteLine("Foo")).Start()
	Task.Run(() => Console.WriteLine("Foo")); // picks a thread from threadpool
}
*/

// Wait ~ equivalent Join
/*
void Main()
{
	Task task = Task.Run(() =>
	{
		Thread.Sleep(2000);
		Console.WriteLine("Foo");
	});
	Console.WriteLine(task.IsCompleted);
	task.Wait(); // exactly like Join
	Console.WriteLine(task.IsCompleted);
}
*/

// Returning Values
/*
void Main()
{
	// Task<TResult>
	Task<List<int>> task = Task.Run(() => 
	{
		// background thread
		Console.WriteLine("Foo");
		List<int> vals = new List<int> {1,2,3,4};
		return vals;
	});
	
	Console.WriteLine(task.Result);
}
*/

// -- Exception Handling --
/*
void Main()
{
	Task task = Task.Run(() => { throw null; });
	try
	{
		task.Wait();
	}
	catch(Exception ex)
	{
		Console.WriteLine("ERROR!");
	}
}
*/

// !! Continuations !! ->>>> AWAITERS
/*
void Main()
{
	Task<int> primeNumberTask = Task.Run(() =>
		Enumerable.Range(2, 3000000).Count(n =>
			Enumerable.Range(2, (int)Math.Sqrt(n)-1).All(i => n % i > 0)));
			
	Console.WriteLine("Task Running...");
	//Console.WriteLine("The answer is "+ primeNumberTask.Result);
	
	// awaiters
	var awaiter = primeNumberTask.GetAwaiter();
	// when my task is completed -> print result
	awaiter.OnCompleted(() =>
	{
		int result = awaiter.GetResult();
		Console.WriteLine(result);		// writes results
	});
}
*/

// Asynchrony
// Asynchronous operations - which do its work in background and then return back to caller

// Concurrency - it is way to created multi-threaded applications

// How can I achieve Asynchronous operations?
	// I need to start a thread in background, let it do its job and then come back with result -> concurrency concept
	
// Asynchronous programming
//	way of writing long-running functions asynchronously
//	!! I/O bound operations !!

Task<int> GetPrimesCountAsync(int start, int count)
{
	return Task.Run(() => 
		ParallelEnumerable.Range(start, count).Count(n=>
		Enumerable.Range(2, (int)Math.Sqrt(n)-1).All(i => n%i > 0)));
}

Task GoAsync()
{
	return Task.Run(() => Console.WriteLine("Foo"));
}

// async modifier instructs the compiler to treat await as a keyword rather than an identifier
// this is allowed -> int await = 10;
// DisplayPrimeCounts() is not running on a new thread
async void DisplayPrimeCounts()
{
	for(int i=0;i<10; i++)
	{
		/*
		var awaiter = GetPrimesCountAsync(i*100+2, 100000).GetAwaiter();
		// run this when completed
		awaiter.OnCompleted(() =>
			Console.WriteLine(awaiter.GetResult())
		);
		*/
		// Call GetPrimesCountAsync asynchonously but I will wait for your answer
		//int result = await GetPrimesCountAsync(i*100+2, 100000);
		await GoAsync();
		//Console.WriteLine(result);
	}
	Console.WriteLine("Done");
}

void Main()
{
	DisplayPrimeCounts();
}
	




