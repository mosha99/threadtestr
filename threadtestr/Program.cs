using System.Collections.Concurrent;
public class Program
{
    /*public static async Task Main(String[] args)
    {

        Console.WriteLine("main 1 id- " + Thread.CurrentThread.ManagedThreadId);


        cw w = new cw();
        Thread t = new Thread(() => w.work());
        t.Start();

        Task.Delay(TimeSpan.FromSeconds(5)).Wait();
        //Thread.Sleep(TimeSpan.FromSeconds(5));

        list.stack.ToList().ForEach(x =>
        {
            Console.WriteLine($"WorkId {x.Key} invoked in Thread {x.Value}");
        });

        Console.WriteLine($"main 3 id-{Thread.CurrentThread.ManagedThreadId} and int = {list.intiger}");

        Console.ReadLine();


    }*/

    public static async Task Main(String[] args)
    {

        Console.WriteLine($"Thread Id - {Thread.CurrentThread.ManagedThreadId} | Thread Name - {Thread.CurrentThread.Name} | ThreadState - {Thread.CurrentThread.ThreadState}");
        await Task.Delay(1000);
        Console.WriteLine($"Thread Id - {Thread.CurrentThread.ManagedThreadId} | Thread Name - {Thread.CurrentThread.Name} | ThreadState - {Thread.CurrentThread.ThreadState}");
        await Task.Delay(1000);
        Console.WriteLine($"Thread Id - {Thread.CurrentThread.ManagedThreadId} | Thread Name - {Thread.CurrentThread.Name} | ThreadState - {Thread.CurrentThread.ThreadState}");
        await Task.Delay(1000);
        Console.WriteLine($"Thread Id - {Thread.CurrentThread.ManagedThreadId} | Thread Name - {Thread.CurrentThread.Name} | ThreadState - {Thread.CurrentThread.ThreadState}");
        await Task.Delay(1000);
        Console.WriteLine($"Thread Id - {Thread.CurrentThread.ManagedThreadId} | Thread Name - {Thread.CurrentThread.Name} | ThreadState - {Thread.CurrentThread.ThreadState}");

    }
}
public class cw
{
    public async Task work()
    {
        Console.WriteLine($"t 1 id- " + Thread.CurrentThread.ManagedThreadId);

        for (int i = 0; i < 20; i++)
        {
            var x = DoSomethingAsync(i, TimeSpan.FromSeconds(4)).ConfigureAwait(false);
            //DoSomethingAsync(i, TimeSpan.FromSeconds(4)).ConfigureAwait(false);
        }
    }

    public async Task<int> DoSomethingAsync(int number, TimeSpan wait)
    {
        await Task.Delay(wait);
        list.stack.Push(new KeyValuePair<int, int>(number, Thread.CurrentThread.ManagedThreadId));
        return number * 2;
    }
}
public class list
{
    public static ConcurrentStack<KeyValuePair<int, int>> stack = new ConcurrentStack<KeyValuePair<int, int>>();
}


