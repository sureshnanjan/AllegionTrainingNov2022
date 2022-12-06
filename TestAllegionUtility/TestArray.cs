using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyAllegionUtility;

namespace TestAllegionUtility
{
    [TestClass]
    public class TestArray
    {
        [TestMethod]
        public void BinarySearcheCorrectlyReturnExistingItemMiddle()
        {
            // AAA Arrange , Act , Assert
            /// Arrange
            MyArray sut = new MyArray();
            int[] inputs = { 1, 2, 3 };
            int searchItem = 2;
            // ACT
            int actual = sut.BinarySearch(inputs,searchItem);
            /// 
            // Assert

            Assert.AreEqual(1, actual);

        }
        [TestMethod]
        public void BinarySearcheCorrectlyReturnExistingItemBegin()
        {
            MyArray sut = new MyArray();
            int[] inputs = { 1, 2, 3 };
            int searchItem = 2;
            // ACT
            int actual = sut.BinarySearch(inputs, searchItem);
            /// 
            // Assert

            Assert.AreEqual(0, actual);

        }
        [TestMethod]
        public void BinarySearcheCorrectlyReturnExistingItemEnd()
        {
            MyArray sut = new MyArray();
            int[] inputs = { 1, 2, 3 };
            int searchItem = 3;
            // ACT
            int actual = sut.BinarySearch(inputs, searchItem);
            /// 
            // Assert

            Assert.AreEqual(2, actual);

        }
    }
}
