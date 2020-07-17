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
        public void TestPop()
        {
            //Arrange
            Stack stack = new Stack();

            //Act
            stack.Pop();

            //Assert
            Assert.Equal("candy cane", stack.Temp.Value);

        }
    }
}
