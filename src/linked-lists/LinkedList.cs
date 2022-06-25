namespace linked_lists;

public class LinkedList
{
    public Node Head { get; set; }

    public void AddEelementAtEnd(Node newNode)
    {
        var head = Head;
        if (head == null)
        {
            head = newNode;
        }
        var current = head;
        if (current.Pointer != null)
        {
            current = current.Pointer;
        }
        current.Pointer = newNode;
    }

    public void PrintElements()
    {
        var current = Head;
        while (current != null)
        {
            Console.WriteLine($"elements in list {current.Value}");
            current = current.Pointer;
        }
    }
}

public class Node
{
    public Node(int value)
    {
        Value = value;
        Pointer = null;
    }

    public int Value { get; set; }
    public Node Pointer { get; set; }
}

// v|addr
//A|30 -- B|40 -- C|null
// 20      30     40 --addr