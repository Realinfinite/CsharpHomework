using Microsoft.VisualStudio.TestTools.UnitTesting;
using Ordermanagement;
using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace Ordermanagement.Tests
{
    [TestClass()]
   
  
    public class OrderServiceTests
    {
        [TestMethod()]
        public void Order_existTest()
        {
            OrderService orderService = new OrderService();
            Order order1 = new Order(1, "Apple", "Li", 10);
            Order order2 = new Order(2, "Orange", "Mi", 20);
            List<Order> list = new List<Order>();
            list.Add(order1);
            list.Add(order2);
            int Order_ID = 3;
            Assert.IsFalse(orderService.Order_exist(list, Order_ID));
        }

        [TestMethod()]
        public void AddOrderTest()
        {
            OrderService orderService = new OrderService();
            List<Order> list1 = new List<Order>();
            List<Order> list2 = new List<Order>();
            Order order1 = new Order(1, "Apple", "Li", 10);
            Order order2 = new Order(2, "Orange", "Mi", 20);
            list1.Add(order2);
             list2  = orderService.AddOrder(list1, order1);
            CollectionAssert.Equals(list1, list2);    
        }

        [TestMethod()]
        public void DeleteOrderTest()
        {
            /*Order order1 = new Order(1, "Apple", "Li", 10);
            Order order2 = new Order(2, "Orange", "Mi", 20);
            List<Order> list = new List<Order>();
            list.Add(order1);
            list.Add(order2);*/

        }

        [TestMethod()]
        public void ChangeOrderTest()
        {
          //

        }

        [TestMethod()]
        public void Searchby_OrderIDTest()
        {
          //  Assert.Fail();
        }

        [TestMethod()]
        public void Searchby_CustomernameTest()
        {
           // Assert.Fail();
        }

        [TestMethod()]
        public void Searchby_GoodsnameTest()
        {
        //    Assert.Fail();
        }

        [TestMethod()]
        public void Searchby_dateTest()
        {
          //  Assert.Fail();
        }

        [TestMethod()]
        public void Sort_listTest()
        {
            Order order1 = new Order(1, "Apple", "Li", 10);
            Order order2 = new Order(2, "Orange", "Mi", 20);
            List<Order> list1 = new List<Order>();
            list1.Add(order2);
            list1.Add(order1);
            OrderService orderService = new OrderService();
            orderService.Sort_list(list1);
            List<Order> list2 = new List<Order>();
            list2.Add(order1);
            list2.Add(order2);
            CollectionAssert.Equals(list1, list2);
        }

        [TestMethod()]
        public void ExportTest()
        {
            OrderService orderService = new OrderService();
            List<Order> list1 = new List<Order>();
           orderService. Export(list1, "testorder.xml");
            Assert.IsTrue(File.Exists("testorder.xml"));
            List<String> expectLines = File.ReadLines("expectedOrders.xml").ToList();
            List<String> outputLines = File.ReadLines("testorder.xml").ToList();
            Assert.AreEqual(expectLines.Count, outputLines.Count);
            for (int i = 0; i < expectLines.Count; i++)
            {
                Assert.AreEqual(expectLines[i].Trim(), outputLines[i].Trim());
            }
        }

        [TestMethod()]
        public void ImportTest()
        {
         
            OrderService os = new OrderService();
            List<Order> list1 = os.Import("newOrders.Count");
            Assert.AreEqual(1, list1.Count);

            os.Import("./newOrders.xml");
            Assert.AreEqual(2, list1.Count);
        }
    }
}