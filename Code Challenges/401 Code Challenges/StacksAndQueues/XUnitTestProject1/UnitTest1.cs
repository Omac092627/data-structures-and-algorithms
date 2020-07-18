using System;
using Xunit;
using StacksAndQueues;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            //Arrange
            Stack stack = new Stack();

            //Act
            stack.Push("candy cane");

            //Assert
            Assert.Equal("candy cane", stack.Top.Value);
            Assert.NotNull(stack.Top.Value);

        }


        [Fact]
        public void CanPushMultipleNodesOnTheStack()
        {
            //Arrange

            Stack stack = new Stack();
            string expected = "peanut";

            //Act
            stack.Push("candy cane");
            stack.Push("peanut");

            //Assert
            string returnFromMethod = $"{stack.Peek()}";

            Assert.Equal(expected, returnFromMethod);
            Assert.NotNull(stack.Peek());
        }

        [Fact]
        public void CanPopNodeOffStack()
        {
            Stack stack = new Stack();
            string expected = "peanut";

            stack.Push("candy cane");
            stack.Push("peanut");
            Node returnFromMethod = stack.Pop();
            Assert.Equal(expected, returnFromMethod.Value);
        }


        [Fact]
        public void CanEmptyStackByPoppin()
        {
            Stack stack = new Stack();
            stack.Push("candy cane");
            stack.Push("peanut");
            stack.Pop();
            stack.Pop();

            Exception e = Assert.Throws<System.Exception>(() => stack.Peek());
            string error = "Empty stack";

            Assert.Equal(error, e.Message);
        }
        [Fact]
        public void PeekReturnTopValue()
        {
            Stack stack = new Stack();

            stack.Push("candy cane");
            stack.Push("peanut");
            string returnFromMethod = stack.Peek();
            Assert.Equal("peanut", returnFromMethod);
        }
    }
}
