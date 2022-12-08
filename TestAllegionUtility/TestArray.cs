using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyAllegionUtility;
using System;

namespace TestAllegionUtility
{

    /// <summary>
    /// Class <c>TestArray</c> Tests the given array using BinarySearch Method Where the index of 
    /// given search item if equal to the acutal index is equal then the test cases are satisfied.
    /// </summary>
    [TestClass]
    public class TestArray
    {
        /// <summary>
        /// Method <c>BinarySearchCorrectlyReturnExistingItemMiddle</c> Method is used to search the item and returns
        /// the index middle value of the given array.
        /// 
        /// <example>For example 
        /// <c>
        /// actual=Myarray.BinarySearch({1,2,3},2)
        /// Assert.AreEqual(1,actual);
        /// </c>
        /// returns in <c>actual</c>'s having the value 1
        /// 
        ///Checks the index value of the given search item and if the beginning search items index is equal
        ///to the actual value then the test case condition is satisfied.
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
            int actual = MyArray.BinarySearch(inputs, searchItem);
            /// 
            // Assert

            Assert.AreEqual(1, actual);

        }

        /// <summary>
        /// Method <c>BinarySearchCorrectlyReturnExistingItemBegin</c> Method is used to search the item and returns
        /// the index Beginning value of the given array.
        /// 
        /// <example>For example 
        /// <c>
        /// actual=Myarray.BinarySearch({1,2,3},1)
        /// Assert.AreEqual(0,actual);
        /// </c>
        /// returns in <c>actual</c>'s having the value 0
        /// 
        ///Checks the index value of the given search item and if the beginning search items index is equal
        ///to the actual value then the test case condition is satisfied.
        /// </example>
        /// </summary>

        [TestMethod]
        public void BinarySearcheCorrectlyReturnExistingItemBegin()
        {
            MyArray sut = new MyArray();
            int[] inputs = { 1, 2, 3 };
            int searchItem = 1;
            // ACT
            int actual = MyArray.BinarySearch(inputs, searchItem);
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
            int actual = Array.BinarySearch(inputs, searchItem);
            /// 
            // Assert

            Assert.AreEqual(2, actual);

        }
    }
    }

