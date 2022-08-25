namespace StacksAndQueue
{
    class Program
    {
        public static void Main(String[] args)
        {
            DequeueElementsQueue dequeue = new DequeueElementsQueue();
            dequeue.Enqueue(56);
            dequeue.Enqueue(30);
            dequeue.Enqueue(70);
            dequeue.Display();
            while (!dequeue.IsEmpty())
            {
                dequeue.Dequeue();
            }
        }
    }
}
