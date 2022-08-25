namespace StacksAndQueue
{
    class Program
    {
        public static void Main(String[] args)
        {
         
            PeakAndPopStack peakAndPopStack = new PeakAndPopStack();
            peakAndPopStack.Push(56);
            peakAndPopStack.Push(30);
            peakAndPopStack.Push(70);
            peakAndPopStack.Display();
            while (!peakAndPopStack.IsEmpty())
            {
                peakAndPopStack.Peek();
                peakAndPopStack.Pop();
            }
        }
    }
}
