using System;
using Xunit;
using Queue_With_Stacks;

namespace QueueTesting
{
    public class UnitTest1
    {
        [Fact]
        public void canEnqueueQueue()
        {
           int[] input = new int[4] { 5, 0, 0, 0 };
           int[] input2 = new int[4] { 10, 15, 20, 0 };

            PseudoQueue<int> que = new PseudoQueue<int>();

            PseudoQueue<int[]> pseudoQueue = que.Enqueue(input, input2);

            Assert.Equal(input, );
        }
    }
}
