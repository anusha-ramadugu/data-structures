namespace Queue;

public interface IQueue<T>
{
    void Enqueue(T item);

    T Dequeue();

    int Count { get; }
    
    bool IsEmpty();
}