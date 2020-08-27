using System;
using CustomListClass;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestCustomList
{
    [TestClass]
    public class UnitTest1
    {
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
            // arrange
            CustomList<int> testList = new CustomList<int>();
            int expected = 2;
            int actual;

            // act
            testList.Add(1);
            testList.Add(2);
            testList.Add(3);
            testList.Add(4);
            testList.Add(5);
            actual = testList[1];

            // assert
            Assert.AreEqual(expected, actual);
        }
        //Remove Method//
        [TestMethod]
        public void Remove_RemovingOneValue_RemovingAddedValueAtIndexOne()
        {
            // arrange
            CustomList<int> testList = new CustomList<int>();
            int itemToRemove = 2;
            int expected = 3;
            int actual;

            // act
            testList.Add(1);
            testList.Add(2);
            testList.Add(3);
            testList.Remove(itemToRemove);
            actual = testList[1];

            // assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Remove_RemovingFirstValue_CountOfCustomListDecrements()
        {
            // arrange
            CustomList<int> testList = new CustomList<int>();
            int itemToRemove = 1;
            int expected = 2;
            int actual;

            // act
            testList.Add(1);
            testList.Add(2);
            testList.Add(3);
            testList.Remove(itemToRemove);
            actual = testList.Count;

            // assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Remove_RemovingFirstValue_CheckForNextListItem()
        {
            // arrange
            CustomList<int> testList = new CustomList<int>();
            int itemToRemove = 1;
            int expected = 2;
            int actual;

            // act
            testList.Add(1);
            testList.Add(2);
            testList.Add(3);
            testList.Add(4);
            testList.Remove(itemToRemove);
            actual = testList[0];

            // assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Remove_RemovingLastValue_CountOfCustomListDecrements()
        {
            // arrange
            CustomList<int> testList = new CustomList<int>();
            int itemToRemove = 5;
            int expected = 4;
            int actual;

            // act
            testList.Add(1);
            testList.Add(2);
            testList.Add(3);
            testList.Add(4);
            testList.Add(5);
            testList.Remove(itemToRemove);
            actual = testList.Count;

            // assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Remove_RemovingLastValue_RemovingNonExistingValue()
        {
            // arrange
            CustomList<int> testList = new CustomList<int>();
            int itemToRemove = 6;
            bool expected = false;
            bool actual;

            // act
            testList.Add(1);
            testList.Add(2);
            testList.Add(3);
            testList.Add(4);
            testList.Add(5);
            testList.Remove(itemToRemove);
            actual = false;

            // assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Add_AddingTwoInstancesOfTheCustomListClass_OverLoadingPlusOperator()
        {
            // arrange
            CustomList<int> testList1 = new CustomList<int>();
            CustomList<int> testList2 = new CustomList<int>();
            CustomList<int> addOperator = new CustomList<int>();
            string expected = "135246";
            string actual;

            // act
            testList1.Add(1);
            testList1.Add(3);
            testList1.Add(5);
            testList2.Add(2);
            testList2.Add(4);
            testList2.Add(6);
            addOperator = testList1 + testList2;
            actual = addOperator.ToString();

            // assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Add_AddingTwoInstancesWithUnevenCustomListClass_OverLoadingPlusOperator()
        {
            // arrange
            CustomList<int> testList1 = new CustomList<int>();
            CustomList<int> testList2 = new CustomList<int>();
            CustomList<int> addOperator = new CustomList<int>();
            string expected = "13524";
            string actual;

            // act
            testList1.Add(1);
            testList1.Add(3);
            testList1.Add(5);
            testList2.Add(2);
            testList2.Add(4);
            addOperator = testList1 + testList2;
            actual = addOperator.ToString();

            // assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Subract_SubtractingTwoInstancesOfTheCustomListClass_OverLoadingMinusOperator()
        {
            //arrange
            CustomList<int> testList1 = new CustomList<int>();
            CustomList<int> testList2 = new CustomList<int>();
            CustomList<int> minusOperator = new CustomList<int>();
            testList1.Add(1);
            testList1.Add(3);
            testList1.Add(5);
            testList2.Add(2);
            testList2.Add(1);
            testList2.Add(6);
            string expected = "35";

            // act
            minusOperator = testList1 - testList2;
            string actual = minusOperator.ToString();

            // assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Subract_SubtractingTwoInstancesOfTheCustomListClassHavingDuplicateValueInSameList_OverLoadingMinusOperator()
        {
            // arrange
            CustomList<int> testList1 = new CustomList<int>();
            CustomList<int> testList2 = new CustomList<int>();
            CustomList<int> minusOperator = new CustomList<int>();
            testList1.Add(1);
            testList1.Add(1);//subtracting 1 1 
            testList1.Add(5);
            testList2.Add(2);
            testList2.Add(1);
            testList2.Add(6);
            string expected = "15";

            // act
            minusOperator = testList1 - testList2;
            string actual = minusOperator.ToString();

            // assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Subract_SubtractingOneInstancesFromAnEmptyCustomListClass_OverLoadingMinusOperator()
        {
            // arrange
            CustomList<int> testList1 = new CustomList<int>();
            CustomList<int> testList2 = new CustomList<int>();
            CustomList<int> minusOperator = new CustomList<int>();
            testList1.Add(1);
            testList1.Add(3);
            testList1.Add(5);
            //subtracting an empty list
            string expected = "135";

            // act
            minusOperator = testList1 - testList2;
            string actual = minusOperator.ToString();

            // assert
            Assert.AreEqual(expected, actual);
        }

    }
}
