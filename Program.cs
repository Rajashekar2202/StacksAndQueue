namespace StacksAndQueue
{
    class Program
    {
        public static void Main(String[] args)
        {
            LinkListStack stack = new LinkListStack();

            stack.Push(56);
            stack.Push(30);
            stack.Push(70);
            stack.Display();
        }
    }
}
