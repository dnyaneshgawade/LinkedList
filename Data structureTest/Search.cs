using Data_structure;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Data_structureTest
{
    [TestClass]
    public class Search
    {
        LinkedList list = new LinkedList();
        [TestMethod]
        public void TestCaseForSearch()
        {
            
            list.Add(50);
            list.Add(30);
            int result = list.Search(30);
            Assert.AreEqual(1, result);
        }
        [TestMethod]
        public void TestCaseForInsertAtPerticularPosition()
        {

            list.Add(50);
            list.Add(30);
            list.Add(70);
            int result = list.Search(30);
            Assert.AreEqual(1, result);
            list.InsertAtParticularPosition(result+1, 40);
            int addResult = list.Search(40);
            Assert.AreEqual(3, addResult);

        }
    }
}
