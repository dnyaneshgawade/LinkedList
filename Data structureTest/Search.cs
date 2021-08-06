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
        public void GivenIntegerPosition_WhenFind_ShouldReturnTrue()
        {
            list.Add(50);
            list.Add(30);
            bool result = list.Search(30);
            Assert.AreEqual(true, result);
        }
    }
}
