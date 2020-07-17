using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using StacksAndQueues;


namespace XUnitTestProject1
{
   public class QueueTests
    {

        public void canEnqueueQueue()
        {

            Queue que = new Queue();

            que.Enqueue("Josie Cat");
            que.Enqueue("Belle Cat");

            Assert.Equal("Josie Vat", que.Front.Value);
        }
    }
}
