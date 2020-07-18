using System;
using Xunit;
using StacksAndQueues;


namespace XUnitTestProject1
{
   public class QueueTests
    {
        [Fact]
        public void canEnqueueQueue()
        {

            Queue<string> que = new Queue<string>();

            que.Enqueue("Josie Cat");

            Assert.Equal("Josie Cat", que.Peek());
        }

        [Fact]
        public void InstantiateMultipleEnqueue()
        {
            Queue<string> que = new Queue<string>();

            que.Enqueue("Josie Cat");
            que.Enqueue("Belle Kitty");

            Assert.Equal("Josie Cat", que.Peek());
        }

        [Fact]
        public void Dequeue()
        {
            Queue<string> queue = new Queue<string>();

            string expected = "Josie Cat";

            queue.Enqueue("Josie Cat");
            queue.Enqueue("Belle Kitty");
            queue.Enqueue("chubbs");
            Node<string> returnNewMethod = queue.Dequeue();

            Assert.Equal(expected, returnNewMethod.Value);
        }

        [Fact]
        public void PeekOnQueue()
        {
            Queue<string> queue = new Queue<string>();
            string expected = "Josie Cat";

            queue.Enqueue("Josie Cat");
            queue.Enqueue("Belle Kitty");
            queue.Enqueue("chubbs");
            string retunNewMethod = queue.Peek();

            Assert.Equal(expected, retunNewMethod);
        }
        [Fact]

        public void EmptyTheQueAfterDequeue()
        {
            Queue<string> queue = new Queue<string>();

            queue.Enqueue("Josie Cat");
            queue.Enqueue("Belle Kitty");
            queue.Enqueue("chubbs");
            queue.Dequeue();
            queue.Dequeue();
            queue.Dequeue();

            Exception e = Assert.Throws<System.Exception>(() => queue.Peek());
            string errorMessage = "queue stack empty";
            Assert.Equal(errorMessage, e.Message);
        }

        [Fact]
        public void InstantiateEmptyQue()
        {
            Queue<string> queue = new Queue<string>();
            Exception e = Assert.Throws<System.Exception>(() => queue.Peek());
            string errorMessage = "queue stack empty";

            Assert.Equal(errorMessage, e.Message);
        }


        [Fact]
        public void DequeueDequeueException()
        {
            Queue<string> queue = new Queue<string>();

            Exception e = Assert.Throws<System.Exception>(() => queue.Dequeue());
            string errorMessage = "Empty queue";
            Assert.Equal(errorMessage, e.Message);
        }
    }
}
