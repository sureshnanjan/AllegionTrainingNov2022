using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyAllegionUtility;

namespace TestAllegionUtility
{
    /// <summary>
    /// Class <c>TestArray</c> models a tests cases for Binary search function.
    /// </summary>
    [TestClass]
    public class TestArray
    {
        /// <summary>
        /// Method <c>BinarySearchCorrectlyReturningExistingItemMiddle</c> models a method where it checks whether it returns correct index value of the array for the middle search item
        /// <example>
        /// For example:
        /// <code>
        ///  actual = ArrayClass.BinarySearch({1,2,3},1)
        /// </code>
        /// results in <c>actual</c> having the value 0
        /// </example>
        /// </summary>
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
        /// <summary>
        /// Method <c>BinarySearcheCorrectlyReturnExistingItemBegin</c> models a method where it checks whether it returns correct index value of the array for the middle search item
        /// <example>
        /// For example:
        /// <code>
        ///  actual = ArrayClass.BinarySearch({1,2,3},1)
        /// </code>
        /// results in <c>actual</c> having the value 1
        /// </example>
        /// </summary>
        [TestMethod]
        public void BinarySearcheCorrectlyReturnExistingItemBegin()
        {
            MyArray sut = new MyArray();
            int[] inputs = { 1, 2, 3 };
            int searchItem = 1;
            // ACT
            int actual = sut.BinarySearch(inputs, searchItem);
            /// 
            // Assert

            Assert.AreEqual(0, actual);

        }
        /// <summary>
        /// Method <c>BinarySearcheCorrectlyReturnExistingItemEnd</c> models a method where it checks whether it returns correct index value of the array for the middle search item
        /// <example>
        /// For example:
        /// <code>
        ///  actual = ArrayClass.BinarySearch({1,2,3},3)
        /// </code>
        /// results in <c>actual</c> having the value 2
        /// </example>
        /// </summary>
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
