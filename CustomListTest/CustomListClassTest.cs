using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomListClass;

namespace CustomListTest
{
    [TestClass]
    public class CustomListClassTest
    {
        [TestMethod]
        public void TestAddMethod()
        {
            //Arrange
            CustomList<int> customList = new CustomList<int>();
            customList.Add(1);
            //Act
            //Assert
        }
    }
}
