using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomListClass;

namespace CustomListTest
{
    [TestClass]
    public class CustomListClassTest
    {
        [TestMethod]
        public void AddInt()
        {
            //Arrange
            CustomList<int> testList = new CustomList<int>();
            int value = 10;
            //Act
            testList.Add(value);
            int result = testList.contents[0];
            //Assert
            Assert.AreEqual(value, result);
        }
        [TestMethod]
        public void AddDouble()
        {
            //Arrange
            CustomList<double> testList = new CustomList<double>();
            double value = 1000;
            //Act
            testList.Add(value);
            double result = testList.contents[0];
            //Assert
            Assert.AreEqual(value, result);
        }
        [TestMethod]
        public void AddDecimal()
        {
            //Arrange
            CustomList<decimal> testList = new CustomList<decimal>();
            decimal value = 11.17m;
            //Act
            testList.Add(value);
            decimal result = testList.contents[0];
            //Assert
            Assert.AreEqual(value, result);
        }
        [TestMethod]
        public void AddString()
        {
            //Arrange
            CustomList<string> testList = new CustomList<string>();
            string animal = "horse";
            //Act
            testList.Add(animal);
            string result = testList.contents[0];
            //Assert
            Assert.AreEqual(animal, result);
        }
        [TestMethod]
        public void RemoveInt()
        {
            //Arrange
            CustomList<int> testList = new CustomList<int>();
            int value = 5;
            int value2 = 7;
            testList.Add(value);
            testList.Add(value2);
            int values = testList.contents[0];
            //Act
            testList.Remove(value);
            int result = testList.contents[0];
            //Assert
            Assert.AreNotEqual(result, values);
        }
        [TestMethod]
        public void RemoveDouble()
        {
            //Arrange
            CustomList<double> mylist = new CustomList<double>();
            double value = 10.10;
            double value2 = 11.11;
            mylist.Add(value);
            mylist.Add(value2);
            double list = mylist.contents[0];
            //Act
            mylist.Remove(value);
            double result = mylist.contents[0];
            //Assert
            Assert.AreNotEqual(result, list);
        }
        [TestMethod]
        public void RemoveDecimal()
        {
            //Arrange
            CustomList<decimal> testList = new CustomList<decimal>();
            decimal value = 12.34m;
            decimal value2 = 35.67m;
            testList.Add(value);
            testList.Add(value2);
            decimal list = testList.contents[0];
            //Act
            testList.Remove(value);
            decimal result = testList.contents[0];
            //Assert
            Assert.AreNotEqual(result, list);
        }
        [TestMethod]
        public void RemoveString()
        {
            //Arrange
            CustomList<string> testList = new CustomList<string>();
            string animal = "chicken";
            string noise = "buc";
            testList.Add(animal);
            testList.Add(noise);
            string list = testList.contents[0];
            //Act
            testList.Remove(animal);
            string result = testList.contents[0];
            //Assert
            Assert.AreNotEqual(result, list);
        }
        [TestMethod]
        public void DisplayString()
        {
            //Arrange
            CustomList<string> testList = new CustomList<string>();
            string animal = "bird";
            string noise = "chirp";
            testList.Add(animal);
            testList.Add(noise);
            string list = testList.contents[0];
            //Act
            testList.Display();
            string result = testList.contents[0];
            //Assert
            Assert.AreEqual(list, result);
        }
        [TestMethod]
        public void DisplayInt()
        {
            //Arrange
            CustomList<int> testList = new CustomList<int>();
            int value = 10;
            int value2 = 17;
            testList.Add(value);
            testList.Add(value2);
            int list = testList.contents[0];
            //Act
            testList.Display();
            int result = testList.contents[0];
            //Assert
            Assert.AreEqual(list, result);
        }
        [TestMethod]
        public void CountString()
        {
            CustomList<string> testList = new CustomList<string>();
            //Arrange
            string animal = "dog";
            string noise = "woof";
            testList.Add(animal);
            testList.Add(noise);
            string list = testList.contents[0];
            //Act
            int result = testList.Count;
            Assert.AreEqual(result, 2);
        }
        [TestMethod]
        public void CountInt()
        {
            CustomList<int> testList = new CustomList<int>();
            //Arrange
            int value = 1;
            int value2 = 2;
            testList.Add(value);
            testList.Add(value2);
            int list = testList.contents[0];
            //Act
            int result = testList.Count;
            Assert.AreEqual(result, 2);
        }
    }
}
