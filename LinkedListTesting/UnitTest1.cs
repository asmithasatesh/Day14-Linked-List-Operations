using Microsoft.VisualStudio.TestTools.UnitTesting;
using LinkedListOperations;

namespace LinkedListTesting
{
    [TestClass]
    public class UnitTest1
    {
        OperationsOnLinkedList obj;
        [TestInitialize]
        public void SetUp()
        {
            obj = new OperationsOnLinkedList();
        }
        //USECASE 7- If data present in List
        [TestMethod]
        public void Usecase_7_1()
        {
            obj.InsertAtFirst(70);
            obj.InsertAtFirst(30);
            obj.InsertAtFirst(56);
            int actualValue = obj.SearchData(30);
            int expectedValue = 30;
            Assert.AreEqual(expectedValue, actualValue);
        }
        //USECASE 7- If data not present in list
        [TestMethod]
        public void Usecase_7_2()
        {
            int actualValue = obj.SearchData(78);
            int expectedValue = 0;
            Assert.AreEqual(expectedValue, actualValue);
        }
    }
}
