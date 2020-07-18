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
            Stack<string> stack = new Stack<string>();

            //Act
            stack.Push("candy cane");

            //Assert
            Assert.Equal("candy cane", stack.Peek());
            Assert.NotNull(stack.Peek());

        }


        [Fact]
        public void CanPushMultipleNodesOnTheStack()
        {
            //Arrange

            Stack<string> stack = new Stack<string>();
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
            Stack<string> stack = new Stack<string>();
            string expected = "peanut";

            stack.Push("candy cane");
            stack.Push("peanut");
            Node<string> returnFromMethod = stack.Pop();
            Assert.Equal(expected, returnFromMethod.Value);
        }


        [Fact]
        public void CanEmptyStackByPoppin()
        {
            Stack<string> stack = new Stack<string>();
            stack.Push("candy cane");
            stack.Push("peanut");
            stack.Pop();
            stack.Pop();

            Exception e = Assert.Throws<System.Exception>(() => stack.Peek());
            string error = "Empty Stack";

            Assert.Equal(error, e.Message);
        }
        [Fact]
        public void PeekReturnTopValue()
        {
            Stack<string> stack = new Stack<string>();

            stack.Push("candy cane");
            stack.Push("peanut");
            string returnFromMethod = stack.Peek();
            Assert.Equal("peanut", returnFromMethod);
        }



        [Fact]
        public void InstatiateEmptyStack()
        {
            Stack<string> stack = new Stack<string>();
            Exception e = Assert.Throws<System.Exception>(() => stack.Peek());
            string errorMessage = "Empty Stack";
            Assert.Equal(errorMessage, e.Message);
        }

        [Fact]
        public void PeekIfStackEmpty()
        {
            Stack<string> stack = new Stack<string>();
            Exception e = Assert.Throws<System.Exception>(() => stack.Peek());
            string errorMessage = "Empty Stack";
            Assert.Equal(errorMessage, e.Message);
        }

        [Fact]
        public void PopEmptyStackError()
        {
            Stack<string> stack = new Stack<string>();
            Exception e = Assert.Throws<System.Exception>(() => stack.Pop());
            string errorMessage = "The stack is empty";
            Assert.Equal(errorMessage, e.Message);
        }
    }
}
