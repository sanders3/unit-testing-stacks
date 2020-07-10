using System;
using Xunit;
using Stacks.Library;

namespace Stacks.Tests
{
    public class StacksTests
    {
        [Fact]
        public void PopDoesNotFailOnEmptyStack()
        {
            var stack = new MyStack(100);
            Assert.Null(stack.Pop());
        }

        [Fact]
        public void CanPopOffItem()
        {
            var stack = new MyStack(100);
            stack.Push("foo");
            Assert.Equal("foo", stack.Pop());
        }

        [Fact]
        public void CanPopOffMultipleItems()
        {
            var stack = new MyStack(100);
            stack.Push("foo");
            stack.Push("bar");
            Assert.Equal("bar", stack.Pop());
            Assert.Equal("foo", stack.Pop());
        }
        [Fact]
        public void CannotPushNull()
        {
            var stack = new MyStack(100);
            Assert.Throws<Exception>(() => {
                stack.Push(null);
            }); 
        }
    }
}
