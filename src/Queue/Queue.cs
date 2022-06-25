namespace Queue;

public class Queue<T> : IQueue<T>
{
    private T[] _items;

    private int _size;

    private int _front = 0;

    private int _rear = 0;
    
    public int Count  => _size;

    public Queue(int initialCapacity = 10)
    {
        if (initialCapacity <= 0)
        {
            throw new ArgumentOutOfRangeException(nameof(initialCapacity), "value must be greater than 0.");
        }
        _items = new T[initialCapacity];
        _size = 0;
    }
    
    public void Enqueue(T item)
    {
        if (_rear == _items.Length)
        {
            var newArray = new T[2 * _items.Length];
            Array.Copy(_items, newArray, _size);
            _items = newArray;
        }

        _items[_rear] = item;
        _size++;
        _rear++;
    }
    
    public T Dequeue()
    {
        if (_size == 0)
        {
            throw new Exception("Queue is empty can not delete item");
        }

        var item = _items[_front];
        _front++;
        _size--;
        return item;
    }
    
    public bool IsEmpty() => Count == 0;
}