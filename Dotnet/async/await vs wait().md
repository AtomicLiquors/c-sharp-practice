await Task.Delay(3000) and Task.Delay(3000).Wait() both introduce a 3-second delay, but they behave very differently in terms of threading, asynchrony, and deadlock potential.
✅ await Task.Delay(3000)
What it does:
Asynchronously waits for 3 seconds.
Does not block the thread.
Control is returned to the calling context during the delay.
Ideal in async methods.
Example:
```C#
public async Task DoSomethingAsync()
{
    await Task.Delay(3000); // Non-blocking delay
    Console.WriteLine("Done after 3 seconds");
}
```
Pros:
Keeps the thread free to do other work.
Preferred in UI and web apps to avoid freezing.
Avoids deadlocks in async environments.
```C#
⚠️ Task.Delay(3000).Wait()
```
What it does:
Synchronously blocks the thread for 3 seconds.
Executes like a traditional blocking call.
Can cause deadlocks, especially in UI or ASP.NET environments.

Example:
```
public void DoSomething()
{
    Task.Delay(3000).Wait(); // Blocking delay
    Console.WriteLine("Done after 3 seconds");
}
```
Cons:
Freezes the current thread, e.g. UI thread or thread pool.
Can cause deadlocks if used in contexts that have a synchronization context (like ASP.NET or WPF).
Not recommended in async code.
⚠️ Deadlock Scenario
```C#
public string GetData()
{
    return GetDataAsync().Result; // Or .Wait()
}

public async Task<string> GetDataAsync()
{
    await Task.Delay(3000); // This may deadlock!
    return "Hello";
}
```
Why it deadlocks:
Result blocks the thread.
await tries to resume on the same synchronization context (e.g. UI), which is blocked → deadlock.
