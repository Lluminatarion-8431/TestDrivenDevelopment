using System;
using CustomListClass;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestCustomList
{
    [TestClass]
    public class UnitTest1
    {
        //Add() Test Methods/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        [TestMethod]
        public void Add_AddTwoValues_CountOf2()
        {
            //arrange
            CustomList<int> customList = new CustomList<int>();
            int value1 = 1;
            int value2 = 2;
            int expected = 2;
            int actual;

            //act
            customList.Add(value1);
            customList.Add(value2);
            actual = customList.Count;

            //assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Add_AddTwoValues_CapacityOf4()
        {
            //arrange
            CustomList<int> customList = new CustomList<int>();
            int value1 = 1;
            int value2 = 2;
            int expected = 4;
            int actual;

            //act
            customList.Add(value1);
            customList.Add(value2);
            actual = customList.Capacity;

            //assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Add_AddFivevalues_capacityof8()
        {
            //arrange
            CustomList<int> customList = new CustomList<int>();
            int value1 = 1;
            int value2 = 2;
            int value3 = 3;
            int value4 = 4;
            int value5 = 5;
            int expected = 8;
            int actual;

            //act
            customList.Add(value1);
            customList.Add(value2);
            customList.Add(value3);
            customList.Add(value4);
            customList.Add(value5);
            actual = customList.Capacity;

            //assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Add_AddingOneValue_AddedValueGoesToIndexZero()
        {
            //arrange
            CustomList<int> testList = new CustomList<int>();
            int itemToAdd = 1;
            int expected = 1;
            int actual;

            //act
            testList.Add(itemToAdd);
            actual = testList[0];

            //assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Add_AddingOneValue_AddedValueGoesToIndexThree()
        {
            //arrange
            CustomList<int> testList = new CustomList<int>();
            int expected = 4;
            int actual;

            //act
            testList.Add(1);
            testList.Add(2);
            testList.Add(3);
            testList.Add(4);
            actual = testList[3];

            //assert
            Assert.AreEqual(expected, actual);

        }
        [TestMethod]
        public void Add_AddingValueToCustomList_ValuesStayAtSameIndex()
        {
            //arrange
            CustomList<int> testList = new CustomList<int>();
            int expected = 2;
            int actual;

            //act
            testList.Add(1);
            testList.Add(2);
            testList.Add(3);
            testList.Add(4);
            testList.Add(5);
            actual = testList[1];

            //assert
            Assert.AreEqual(expected, actual);
        }
        //Remove() Test Methods//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        [TestMethod]
        public void Remove_RemovingOneValue_RemovingAddedValueAtIndexOne()
        {
            //arrange
            CustomList<int> testList = new CustomList<int>();
            int itemToRemove = 2;
            int expected = 3;
            int actual;

            //act
            testList.Add(1);
            testList.Add(2);
            testList.Add(3);
            testList.Remove(itemToRemove);
            actual = testList[1];

            //assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Remove_RemovingFirstValue_CountOfCustomListDecrements()
        {
            //arrange
            CustomList<int> testList = new CustomList<int>();
            int itemToRemove = 1;
            int expected = 2;
            int actual;

            //act
            testList.Add(1);
            testList.Add(2);
            testList.Add(3);
            testList.Remove(itemToRemove);
            actual = testList.Count;

            //assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Remove_RemovingFirstValue_CheckForNextListItem()
        {
            //arrange
            CustomList<int> testList = new CustomList<int>();
            int itemToRemove = 1;
            int expected = 2;
            int actual;

            //act
            testList.Add(1);
            testList.Add(2);
            testList.Add(3);
            testList.Add(4);
            testList.Remove(itemToRemove);
            actual = testList[0];

            //assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Remove_RemovingLastValue_CountOfCustomListDecrements()
        {
            //arrange
            CustomList<int> testList = new CustomList<int>();
            int itemToRemove = 5;
            int expected = 4;
            int actual;

            //act
            testList.Add(1);
            testList.Add(2);
            testList.Add(3);
            testList.Add(4);
            testList.Add(5);
            testList.Remove(itemToRemove);
            actual = testList.Count;

            //assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Remove_RemovingLastValue_RemovingNonExistingValue()
        {
            //arrange
            CustomList<int> testList = new CustomList<int>();
            int itemToRemove = 6;
            bool expected = false;
            bool actual;

            //act
            testList.Add(1);
            testList.Add(2);
            testList.Add(3);
            testList.Add(4);
            testList.Add(5);
            testList.Remove(itemToRemove);
            actual = false;

            //assert
            Assert.AreEqual(expected, actual);
        }
        //Overloading +Operator//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        [TestMethod]
        public void Add_AddingTwoInstancesOfTheCustomListClass_OverLoadingPlusOperator()
        {
            //arrange
            CustomList<int> testList1 = new CustomList<int>();
            CustomList<int> testList2 = new CustomList<int>();
            CustomList<int> addOperator = new CustomList<int>();
            string expected = "135246";
            string actual;

            //act
            testList1.Add(1);
            testList1.Add(3);
            testList1.Add(5);
            testList2.Add(2);
            testList2.Add(4);
            testList2.Add(6);
            addOperator = testList1 + testList2;
            actual = addOperator.ToString();

            //assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Add_AddingTwoInstancesWithUnevenCustomListClass_OverLoadingPlusOperator()
        {
            //arrange
            CustomList<int> testList1 = new CustomList<int>();
            CustomList<int> testList2 = new CustomList<int>();
            CustomList<int> addOperator = new CustomList<int>();
            string expected = "13524";
            string actual;

            //act
            testList1.Add(1);
            testList1.Add(3);
            testList1.Add(5);
            testList2.Add(2);
            testList2.Add(4);
            addOperator = testList1 + testList2;
            actual = addOperator.ToString();

            //assert
            Assert.AreEqual(expected, actual);
        }
        //Overloading -Operator//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        [TestMethod]
        public void Subract_SubtractingTwoInstancesOfTheCustomListClass_OverLoadingMinusOperator()
        {
            //arrange
            CustomList<int> testList1 = new CustomList<int>();
            CustomList<int> testList2 = new CustomList<int>();
            CustomList<int> minusOperator = new CustomList<int>();
            string expected = "35";
            string actual;

            //act
            testList1.Add(1);
            testList1.Add(3);
            testList1.Add(5);
            testList2.Add(2);
            testList2.Add(1);
            testList2.Add(6);
            minusOperator = testList1 - testList2;
            actual = minusOperator.ToString();

            //assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Subract_SubtractingTwoInstancesOfTheCustomListClassHavingDuplicateValueInSameList_OverLoadingMinusOperator()
        {
            //arrange
            CustomList<int> testList1 = new CustomList<int>();
            CustomList<int> testList2 = new CustomList<int>();
            CustomList<int> minusOperator = new CustomList<int>();
            string expected = "15";
            string actual;

            //act
            testList1.Add(1);
            testList1.Add(1);//subtracting 1 1 
            testList1.Add(5);
            testList2.Add(2);
            testList2.Add(1);
            testList2.Add(6);
            minusOperator = testList1 - testList2;
            actual = minusOperator.ToString();

            //assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Subract_SubtractingOneInstancesFromAnEmptyCustomListClass_OverLoadingMinusOperator()
        {
            //arrange
            CustomList<int> testList1 = new CustomList<int>();
            CustomList<int> testList2 = new CustomList<int>();
            CustomList<int> minusOperator = new CustomList<int>();
            string expected = "135";
            string actual;

            //act
            testList1.Add(1);
            testList1.Add(3);
            testList1.Add(5);
            //subtracting an empty list
            minusOperator = testList1 - testList2;
            actual = minusOperator.ToString();

            //assert
            Assert.AreEqual(expected, actual);
        }
        //Overriding ToString////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        [TestMethod]
        public void Override_OverridingToStringMethod_ConvertingCustomListToString()
        {
            //arrange
            CustomList<int> testList = new CustomList<int>();
            int value1 = 1;
            int value2 = 3;
            int value3 = 5;
            int value4 = 2;
            int value5 = 4;
            int value6 = 6;
            string expected = "135246";
            string actual;

            //act
            testList.Add(value1);
            testList.Add(value2);
            testList.Add(value3);
            testList.Add(value4);
            testList.Add(value5);
            testList.Add(value6);
            actual = testList.ToString();

            //assert
            Assert.AreEqual(expected, actual);

        }
        [TestMethod]
        public void Override_OverridingToStringMethod_AddingSeveralStringsCustomListToString()
        {
            //arrange
            CustomList<string> testList = new CustomList<string>();
            string value1 = "He";
            string value2 = "llo";
            string value3 = "Wo";
            string value4 = "rld";
            string expected = "Hello World";
            string actual;

            //act
            testList.Add(value1);
            testList.Add(value2);
            testList.Add(value3);
            testList.Add(value4);
            actual = testList.ToString();

            //assert
            Assert.AreEqual(expected, actual);

        }
        //Adding Two Instances To A Zipper///////////////////////////////////////////////////////////////////////////////////////////////////////////////
        [TestMethod]
        public void Zip_ZippingTwoInstancesTogether_OddAndEvenZipper()
        {
            //arrange
            CustomList<int> odd = new CustomList<int>();
            CustomList<int> even = new CustomList<int>();
            CustomList<int> zipList;
            string expected = "123456";

            // act
            odd.Add(1);
            odd.Add(3);
            odd.Add(5);
            even.Add(2);
            even.Add(4);
            even.Add(6);
            zipList = CustomList<int>.Zip(odd, even);

            // assert
            Assert.AreEqual(expected, zipList.ToString());
        }
        [TestMethod]
        public void Zip_ZippingTwoUnevenInstancesTogether_OddAndEvenZipper()
        {
            //arrange
            CustomList<int> odd = new CustomList<int>();
            CustomList<int> even = new CustomList<int>();
            CustomList<int> zipList;
            string expected = "12345";

            // act
            odd.Add(1);
            odd.Add(3);
            odd.Add(5);
            even.Add(2);
            even.Add(4);
            zipList = CustomList<int>.Zip(odd, even);

            // assert
            Assert.AreEqual(expected, zipList.ToString());
        }
    }
}
