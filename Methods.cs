namespace Async_Await_C__STEP
{
    public class Methods
    {
        public static async Task ProcessOrderAsync(int orderId)
        {
            Console.WriteLine($"Started Execution order with ID - {orderId}...");
            await Task.Delay(2000);
            Console.WriteLine($"Execution Completed! Order ID: {orderId}");
        }


        public static int counter = 0;
        public static async Task CounterIncrement()
        {
            for (int i = 0; i < 1000; i++)
            {
                Interlocked.Increment(ref counter); // я знаю что можно было бы воспользоваться lock однако мне такой метод показался проще
                                                    // и я смогу объяснить вам как это работает
            }
        }
    }
}
