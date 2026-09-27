using Async_Await_C__STEP;

//Task task1 = Methods.ProcessOrderAsync(1);
//Task task2 = Methods.ProcessOrderAsync(2);
//Task task3 = Methods.ProcessOrderAsync(3);

//await Task.WhenAll(task1, task2, task3);

Task t1 = Task.Run(Methods.CounterIncrement);
Task t2 = Task.Run(Methods.CounterIncrement);
Task t3 = Task.Run(Methods.CounterIncrement);
Task t4 = Task.Run(Methods.CounterIncrement);
Task t5 = Task.Run(Methods.CounterIncrement);

await Task.WhenAll(t1, t2, t3, t4, t5);

Console.WriteLine(Methods.counter); // без interlocked возвращались рандомные числа из за race condition