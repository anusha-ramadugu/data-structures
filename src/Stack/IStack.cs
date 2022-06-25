namespace Stack;

public interface IStack<T>
{
    void Push(T element);
    
    T Pop();
    
    int Count { get; }
    
    bool IsEmpty();

}