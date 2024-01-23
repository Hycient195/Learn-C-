using System.Collections;

public class MyStack
{
    private ArrayList _internalMemory = new ArrayList();

    public void Push(object arg)
    {
        if (arg != null)
            _internalMemory.Add(arg);
        else
            throw new InvalidOperationException("Unable to add null value to stack");
    }

    public object Pop()
    {
        if (_internalMemory.Count != 0)
        {
            var returnValue = _internalMemory[_internalMemory.Count - 1];
            _internalMemory.RemoveAt(_internalMemory.Count - 1);

            return returnValue;
        }
        else
        {
            throw new InvalidOperationException("Unable to item from an empty stack");
        }
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

