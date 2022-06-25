namespace Stack;

public class Stack<T> : IStack<T>
{
    private T[] _items;
    private int _size = 0;

    public Stack(int initialCapacity = 10)
    {
        if (initialCapacity <= 0)
        {
            throw new ArgumentOutOfRangeException(nameof(initialCapacity), initialCapacity, "value must be > 0");
        }
        _items = new T[initialCapacity];
        _size = 0;
    }

    public int Count => _size;

    public bool IsEmpty() => _size == 0;

    public void Push(T element)
    {
        if (_size == _items.Length)
        {
            var newArray = new T[2 * _items.Length];
            Array.Copy(_items, newArray, _size);
            _items = newArray;
        }
        _items[_size++] = element;
    }

    public T Pop()
    {
        if (_size == 0)
        {
            throw new Exception("stack underflow exception");
        }
        var lastElementToBePopped = _items[--_size];
        return lastElementToBePopped;
    }
}