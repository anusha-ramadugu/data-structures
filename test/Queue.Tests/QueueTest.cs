using System;
using Xunit;

namespace Queue.Tests;

public class QueueTest
{
    [Fact]
    public void Enqueue()
    {
        var queue = new Queue<int>();
        queue.Enqueue(10);
        queue.Enqueue(100);
        queue.Enqueue(500);
        
        Assert.False(queue.IsEmpty());
        Assert.Equal(3, queue.Count);
    }

    [Fact]
    public void ThrowErrorIfNegativeNumbersPassed()
    {
        Assert.Throws<ArgumentOutOfRangeException>(() => new Queue<int>(-10));
    }
    
    [Fact]
    public void Dequeue()
    {
        var queue = new Queue<int>();
        queue.Enqueue(1000);
        queue.Enqueue(2000);
        
        Assert.Equal(1000, queue.Dequeue());
        Assert.Equal(2000, queue.Dequeue());
        Assert.True(queue.IsEmpty());
    }
    
    [Fact]
    public void DequeueUnderflow()
    {
        var queue = new Queue<int>();
        queue.Dequeue();
        //should throw queue underflow error
        Assert.Throws<Exception>(() => queue.Dequeue());
    }
}