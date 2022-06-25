using System;
using Queue.CustomExceptions;
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
        var ex = Assert.Throws<ArgumentOutOfRangeException>(() => new Queue<int>(-10));
       // Assert.Equal("value must be greater than 0.", ex.Message);
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
        
        var err = Assert.Throws<QueueUnderFlowException>(() => queue.Dequeue());
        Assert.Equal("Queue is empty can not delete item.", err.Message);
    }
}