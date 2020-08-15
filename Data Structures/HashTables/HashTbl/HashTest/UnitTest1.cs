using HashTable;
using System;
using Xunit;

namespace HashTest
{
    public class UnitTest1
    {
        [Fact]
        public void CanAddItemToHashTable()
        {
            HashTable<int> table = new HashTable<int>(16);

            table.Add("Josie", 9);
            Assert.NotNull(table);

        }

        [Fact]
        public void GetValue()
        {
            // arrange
            HashTable<int> table = new HashTable<int>(16);

            table.Add("Josie", 9);
            table.Add("Dog", 10);
            table.Add("Cupcake", 5);

            var result = table.Get("Dog");

            Assert.Equal(10, result);
        }

        [Fact]
        public void FindsContainedValue()
        {
            HashTable<int> table = new HashTable<int>(16);

            table.Add("Josie", 9);
            table.Add("Dog", 10);
            table.Add("Cupcake", 5);

            var contains = table.Contains("Cupcake");

            Assert.True(contains);

        }

        [Fact]
        public void CanReturnNullForAKeyThatDoesNotExsist()
        {
            HashTable<int> table = new HashTable<int>(100);

            table.Add("Lami", 38);
            table.Add("Katie", 41);
            table.Add("Becky", 40);

            var returnFromMethod = table.Get("Razzle");

            Assert.Null(returnFromMethod);
        }


        [Fact]
        public void CanHandleACollision()
        {

            HashTable<int> table = new HashTable<int>(100);

            table.Add("Lami", 38);
            table.Add("Dean", 41);
            table.Add("Dane", 40);

            var returnFromMethod1 = table.Contains("Dean");
            var returnFromMethod2 = table.Contains("Dnea");

            Assert.NotNull(table);
            Assert.True(returnFromMethod1);
            Assert.False(returnFromMethod2);
        }

        [Fact]
        public void CanRetrieveAValueFromACollison()
        {
            HashTable<int> table = new HashTable<int>(100);

            table.Add("Lami", 38);
            table.Add("Dean", 41);
            table.Add("Dane", 40);

            var returnFromMethod1 = table.Get("Dean");
            var returnFromMethod2 = table.Get("Dane");

            Assert.NotNull(table);
            Assert.Equal(41, returnFromMethod1);
            Assert.Equal(40, returnFromMethod2);
        }
    }
}