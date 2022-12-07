using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyAllegionUtility;
using System;

namespace TestAllegionUtility
{
    /// <summary>
    /// Class<c>TestArray</c> models a Class where it checks the BinarySearch function of ArrayClass with different conditions
    /// </summary>
    [TestClass]
    public class TestArray
    {
        /// <summary>
        /// Method <c>BinarySearchCorrectlyReturningExistingItemMiddle</c> models a method where it checks whether it returns correct index value of the array for the middle search item
        /// <example>
        /// For example:
        /// <code>
        ///  actual = ArrayClass.BinarySearch({1,2,3},1); 
        ///  Assert.AreEqual(0,actual);
        /// </code>
        /// results in <c>actual</c> having the value 0
        /// and the <c>AreEqual</c> having the value TRUE
        /// </example>
        /// 
        /// </summary>
        [TestMethod]
        public void BinarySearchCorrectlyReturningExistingItemMiddle()
        {
            //AAA Arrange, Act, Assert
            ArrayClass sut = new ArrayClass();
            int[] inputs = { 1, 2, 3 };
            int searchItem = 1;

            //ACT
            int actual = ArrayClass.BinarySearch(inputs, searchItem);

            ///ASERT
            Assert.AreEqual(0, actual);
        }

        /// <summary>
        /// Method <c>BinarySearchCorrectlyReturningExistingItemBegin</c> models a method where it checks whether it returns correct index value of the array for the middle search item
        /// <example>
        /// For example:
        /// <code>
        ///  actual = ArrayClass.BinarySearch({1,2,3},2) 
        ///  Assert.AreEqual(1,actual);
        /// </code>
        /// results in <c>actual</c> having the value 0
        /// and the <c>AreEqual</c> having the value FALSE
        /// </example>
        /// </summary>
        [TestMethod]
        public void BinarySearchCorrectlyReturnExistingItemBegin()
        {
            ArrayClass sut = new ArrayClass();
            int[] inputs = { 1, 2, 3 };
            int searchItem = 2;

            //ACT
            int actual = ArrayClass.BinarySearch(inputs, searchItem);

            //ASSERT
            Assert.AreEqual(1, actual);
        }

        /// <summary>
        /// Method <c>BinarySearchCorrectlyReturningExistingItemEnd</c> models a method where it checks whether it returns correct index value of the array for the middle search item
        /// <example>
        /// For example:
        /// <code>
        ///  actual = ArrayClass.BinarySearch({1,2,3},3) 
        ///  Assert.AreEqual(2,actual);
        /// </code>
        /// results in <c>actual</c> having the value 0
        /// and the <c>AreEqual</c> having the value FALSE
        /// </example>
        /// </summary>
        [TestMethod]
        public void BinarySearcheCorrectlyReturnExistingItemEnd()
        {
            ArrayClass sut = new ArrayClass();
            int[] inputs = { 1, 2, 3 };
            int searchItem = 3;
            // ACT
            int actual = ArrayClass.BinarySearch(inputs, searchItem);
            /// 
            // Assert

            Assert.AreEqual(2, actual);

        }
    }
}
