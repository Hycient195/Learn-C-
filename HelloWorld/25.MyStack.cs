using System.Collections;

public class MyStack
{
    private readonly ArrayList _internalMemory = new ArrayList();

    public void Push(object arg)
    {
        if (arg == null)
            throw new InvalidOperationException("Unable to add null value to stack");

        _internalMemory.Add(arg); 
    }

    public object Pop()
    {
        if (_internalMemory.Count == 0)
            throw new InvalidOperationException("Unable to item from an empty stack");

        var returnValue = _internalMemory[_internalMemory.Count - 1];
        _internalMemory.RemoveAt(_internalMemory.Count - 1);
        return returnValue;
    }

    public void Clear() 
    {
        _internalMemory.Clear();
    }

    public void GetItems()
    {
        foreach (var item in _internalMemory)
            Console.WriteLine("item is: " + item);
    }
}

