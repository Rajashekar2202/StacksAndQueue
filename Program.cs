namespace StacksAndQueue
{
    class Program
    {
        public static void Main(String[] args)
        {
            QueueLinklist queue = new QueueLinklist();
            queue.Enqueue(56);
            queue.Enqueue(30);
            queue.Enqueue(70);
            queue.Display();

        }
    }
}
