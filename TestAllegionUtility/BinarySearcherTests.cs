using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using MyAllegionUtility;

namespace TestAllegionUtility
{
    [TestClass]
    public class MyArrayTests
    {
        [TestMethod]
        public void ArrayContainingElementReturnsIndex()
        {
            // Arrange , ACT, ASSERT
            int[] inputArray = { 1, 2, 3, 4, 5 }; // Arrang
            int elementToSearch = 3; // Arrange
            int returnValue = MyArray.BinarySearch(inputArray, elementToSearch); //ACT
            Assert.AreEqual(2,returnValue); // Assert

        }

        [TestMethod]
        public void ArrayNotContainingElementReturnsNegative()
        {
            int[] inputArray = { 1, 2, 3, 4, 5 };
            int elementToSearch = 10;
            int returnValue = MyArray.BinarySearch(inputArray, elementToSearch);
            //Assert.AreEqual(2, returnValue);
            Assert.IsTrue(returnValue < 0);

        }

        /// <summary>
        /// If value is not found and value is less than one or more elements in array, 
        /// the negative number returned is the bitwise complement of the index of the first element 
        /// that is larger than value. 
        /// </summary>
        [TestMethod]
        public void ArrayNotContainingElementLessThanAnyArrayMember()
        {
            int[] inputArray = { 1, 2, 3, 4, 5 };
            int elementToSearch = 0;
            int returnValue = MyArray.BinarySearch(inputArray, elementToSearch);
            Assert.AreEqual(~0, returnValue);
            //Assert.IsTrue(returnValue < 0);

        }

        [TestMethod]
        public void ArrayNotContainingElementLessThanAnyArrayMember1()
        {
            int[] inputArray = { 2, 4, 6, 8, 10 };
            int elementToSearch = 7;
            int returnValue = MyArray.BinarySearch(inputArray, elementToSearch);
            Assert.AreEqual(~3, returnValue);
            //Assert.IsTrue(returnValue < 0);

        }

        /// <summary>
        /// If value is not found and value is greater than all elements in array, the negative number 
        /// returned is the bitwise complement of (the index of the last element plus 1). 
        /// </summary>

        [TestMethod]
        public void ArrayNotHavingEkeme() {
                        
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void TestForExceptionsArgumentNull() {
            int[] inputArray = null;
            int element = 10;
            MyArray.BinarySearch(inputArray, element);
        }

        [TestMethod]
        [ExpectedException(typeof(RankException))]
        public void TestForExceptionsRankException()
        {
            int[,] inputMultiarray = new int[4, 2];
            int element = 10;
            MyArray.BinarySearch(inputMultiarray, element);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestForExceptionsArgumentException()
        {
            int[] inputMultiArray =  {1,2,3,4,5};
            //string element = "Suresh";
            System.IO.DirectoryInfo di = new System.IO.DirectoryInfo("");
            MyArray.BinarySearch(inputMultiArray, di);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void TestForExceptionsInvalidArgumentException()
        {
            SimpleClass[] siArray = { new SimpleClass(), new SimpleClass(),new SimpleClass() };
            //string element = "Suresh";
            //System.IO.DirectoryInfo di = new System.IO.DirectoryInfo("");
            SimpleClass element = new SimpleClass();
            MyArray.BinarySearch(siArray, element);
        }

        [TestMethod]
        [DataRow(1,2,3)]
        [DataRow(5, 7, 12)]
        [DataRow(100, 12, 111)]
        public void ReadInputsandAssertOutput(int param1, int param2, int expectedResult)
        {
            int result = callMyImplementation(param1, param2);
            Assert.AreEqual(expectedResult, result);
        }

        private int callMyImplementation(int param1, int param2)
        {
            return param1 + param2;
        }
    }
}
