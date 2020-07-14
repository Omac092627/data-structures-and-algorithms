using System;
using Xunit;
using LLLibrary;

namespace LinkedListTests
{
    public class UnitTest1
    {
        [Fact]
        public void CanInstantiateEmptyLinkedList()
        {
            LinkedList1 list = new LinkedList1();
            Assert.Null(list.Head);
        }

        [Fact]
        public void CanInsertIntoLinkedList()
        {
            // insert means add to the front
            //Arrange
            LinkedList1 list = new LinkedList1();
            list.Insert(4);
            Assert.Equal(4, list.Head.Value);
        }

        [Fact]
        public void CanInsertMultipleNodesInLinkedList()
        {
            LinkedList1 list = new LinkedList1();
            list.Insert(4);
            list.Insert(8);
            list.Insert(15);
            list.Insert(16);
            list.Insert(23);
            list.Insert(42);

            Assert.Equal(42, list.Head.Value);

        }

        [Fact]
        public void CanFindValueInList()
        {
            // arrange
            LinkedList1 list = new LinkedList1();

            list.Insert(4);
            list.Insert(8);
            list.Insert(15);
            list.Insert(16);
            list.Insert(23);
            list.Insert(42);

            // Act 
            int searchForValue = 15;
          bool exists = list.Includes(searchForValue);

            // Assert
            Assert.True(exists);

        }

        [Fact]
        public void CannotFindValueInLinkedList()
        {
            // arrange
            LinkedList1 list = new LinkedList1();

            list.Insert(4);
            list.Insert(8);
            list.Insert(15);
            list.Insert(16);
            list.Insert(23);
            list.Insert(42);

            // Act 
            int searchForValue = 100;
            bool exists = list.Includes(searchForValue);

            // Assert
            Assert.False(exists);

        }

        [Fact]
        public void CanReturnAllValuesInLinkedList()
        {
            // Arrange
            LinkedList1 list = new LinkedList1();
            list.Insert(4);
            list.Insert(8);
            list.Insert(15);
            list.Insert(16);
            list.Insert(23);
            list.Insert(42);

            // Act
            string value = list.ToString();

            string expected = "42 -> 23 -> 16 -> 15 -> 8 -> 4 -> Null";
            // Assert
            Assert.Equal(expected, value);

        }



        [Fact]
        public void CannotFindValueInList()
        {
            LinkedList1 list = new LinkedList1();
            list.Insert(4);
            list.Insert(8);
            list.Insert(12);
            list.Insert(15);
            list.Insert(23);
            list.Insert(42);

            int searchForvalue = 16;
            bool exists = list.Includes(searchForvalue);

            Assert.False(exists);
        }

        [Fact]
        public void CanReturnValuesInLinkedLists()
        {
            LinkedList1 list = new LinkedList1();
            list.Insert(4);
            list.Insert(8);
            list.Insert(12);
            list.Insert(15);
            list.Insert(23);
            list.Insert(42);

            string outputFromMethod = list.ToString();

            string expected = "42 -> 23 -> 15 -> 12 -> 8 -> 4 -> Null";
            Assert.Equal(expected, outputFromMethod);
        }

        [Fact]
        public void CanReturnValuesInLinkedListsAfterUsingAppend()
        {
            LinkedList1 list = new LinkedList1();
            list.Insert(2);
            list.Insert(3);
            list.Insert(1);
            list.Append(5);
            string outputFromMethod = list.ToString();
            string expected = "1 -> 3 -> 2 -> 5 -> Null";
            Assert.Equal(expected, outputFromMethod);
        }
        [Fact]
        public void CanAppendIfListIsEmpty()
        {
            LinkedList1 list = new LinkedList1();
            list.Append(1);
            string outputFromMethod = list.ToString();
            string expected = "1 -> Null";
            Assert.Equal(expected, outputFromMethod);
        }
        [Fact]
        public void CanAddBefore1()
        {
            LinkedList1 list = new LinkedList1();
            list.Insert(2);
            list.Insert(3);
            list.Insert(1);
            list.InsertBefore(3, 5);
            string outputFromMethod = list.ToString();
            string expected = "1 -> 5 -> 3 -> 2 -> Null";
            Assert.Equal(expected, outputFromMethod);
        }
        [Fact]
        public void CanAddBefore2()
        {
            LinkedList1 list = new LinkedList1();
            list.Insert(2);
            list.Insert(3);
            list.Insert(1);
            list.InsertBefore(1, 5);
            string outputFromMethod = list.ToString();
            string expected = "5 -> 1 -> 3 -> 2 -> Null";
            Assert.Equal(expected, outputFromMethod);
        }
        [Fact]
        public void CanAddBefore3()
        {
            LinkedList1 list = new LinkedList1();
            list.Insert(2);
            list.Insert(2);
            list.Insert(1);
            list.InsertBefore(2, 5);
            string outputFromMethod = list.ToString();
            string expected = "1 -> 5 -> 2 -> 2 -> Null";
            Assert.Equal(expected, outputFromMethod);
        }
        [Fact]
        public void CanAddBefore4()
        {
            LinkedList1 list = new LinkedList1();
            list.Insert(2);
            list.Insert(3);
            list.Insert(1);
            Exception e = Assert.Throws<System.Exception>(() => list.InsertBefore(4, 5));
            string errorMessage = "That value does not exist.";

            Assert.Equal(errorMessage, e.Message);
        }

        [Fact]
        public void CanAddAfter1()
        {
            LinkedList1 list = new LinkedList1();

            list.Insert(2);
            list.Insert(3);
            list.Insert(1);

            list.InsertAfter(3, 5);

            string outputFromMethod = list.ToString();

            string expected = "1 -> 3 -> 5 -> 2 -> Null";
            Assert.Equal(expected, outputFromMethod);
        }

        [Fact]
        public void CanAddAfter2()
        {
            LinkedList1 list = new LinkedList1();

            list.Insert(2);
            list.Insert(3);
            list.Insert(1);

            list.InsertAfter(2, 5);

            string outputFromMethod = list.ToString();

            string expected = "1 -> 3 -> 2 -> 5 -> Null";
            Assert.Equal(expected, outputFromMethod);
        }

        [Fact]
        public void CanAddAfter3()
        {
            LinkedList1 list = new LinkedList1();

            list.Insert(2);
            list.Insert(2);
            list.Insert(1);

            list.InsertAfter(2, 5);

            string outputFromMethod = list.ToString();

            string expected = "1 -> 2 -> 5 -> 2 -> Null";
            Assert.Equal(expected, outputFromMethod);
        }

        [Fact]
        public void CanAddAfter4()
        {
            LinkedList1 list = new LinkedList1();

            list.Insert(2);
            list.Insert(3);
            list.Insert(1);

            Exception e = Assert.Throws<System.Exception>(() => list.InsertBefore(4, 5));
            string errorMessage = "That value does not exist.";

            Assert.Equal(errorMessage, e.Message);
        }
    }
}
