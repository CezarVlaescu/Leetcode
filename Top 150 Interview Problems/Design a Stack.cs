class CustomStack
{
    private Stack<int> MyCustomStack;
    private readonly int _maxSize;
    
    public CustomStack(int maxSize)
    {
        MyCustomStack = new Stack<int>();
        _maxSize = maxSize;
    }

    public void Push(int value)
    {
        if (MyCustomStack.Count < _maxSize) MyCustomStack.Push(value);
        else throw new Exception("Stack is full sized");
    }

    public int Pop()
    {
        if (MyCustomStack.Count == 0) return -1;
        return MyCustomStack.Pop();
    }

    public void Increment(int k, int val)
    {
        StackHelper(MyCustomStack, val, Math.Min(k, MyCustomStack.Count));
    }

    private static void StackHelper(Stack<int> stack, int value, int start)
    {
        // Stocăm temporar elementele într-o listă pentru a nu altera ordinea stivei
        List<int> tempList = new List<int>();

        // Scoatem elementele din stivă și le stocăm temporar
        while (stack.Count > 0)
        {
            tempList.Add(stack.Pop());
        }

        // Incrementăm primele k elemente (de la baza stivei)
        for (int i = tempList.Count - 1; i >= tempList.Count - start && i >= 0; i--)
        {
            tempList[i] += value;
        }

        // Reintroducem elementele în stivă în ordinea corectă
        for (int i = tempList.Count - 1; i >= 0; i--)
        {
            stack.Push(tempList[i]);
        }
    }
}
