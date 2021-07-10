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
        //USECASE 8- Insert data 40 after 30
        [TestMethod]
        public void Usecase_8()
        {
            obj.InsertAtFirst(70);
            obj.InsertAtFirst(30);
            obj.InsertAtFirst(56);
            int actualValue = obj.InsertAtSpecificPosition(30, 40);
            int expectedValue = 40;
            Assert.AreEqual(expectedValue, actualValue);
        }
        //USECASE 9- Search and Delete data 40 from Linked List
        [TestMethod]
        public void Usecase_9()
        {
            obj.InsertAtFirst(70);
            obj.InsertAtFirst(40);
            obj.InsertAtFirst(30);
            obj.InsertAtFirst(56);
            int actualValue = obj.DeleteInBetween(40);
            int expectedValue = 3;
            Assert.AreEqual(expectedValue, actualValue);
        }
    }
}
