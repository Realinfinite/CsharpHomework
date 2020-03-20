using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ordermanagement
{
    class OrderService
    {
        public bool Order_exist (List<Order> list, int order_ID)
       {
            var m = list.Where(w => w.Order_ID == order_ID);
              List <Order> testlist = m.ToList();
            return testlist.Count() != 0  ;
          }


    //添加订单
   
    public List<Order> AddOrder(List<Order>list,Order order)
        {
         
            try
        {
            Console.WriteLine("input an Order_ID to add");
            int a = int.Parse(Console.ReadLine());
                if (!Order_exist(list, a))
                {
                    order.Order_ID = a;
                    Console.WriteLine("Customer_name:");
                    order.Customer_name = Console.ReadLine();
                    Console.WriteLine("Goods_name:");
                    order.Goods_name = Console.ReadLine();
                    Console.WriteLine("Total_price");
                    order.Total_price = double.Parse(Console.ReadLine());
                    Console.WriteLine("OrderDetail:Unit_price");
                    order.orderDetail.Unit_price = int.Parse(Console.ReadLine());
                    Console.WriteLine("OrderDetail:date");
                    order.orderDetail.date = Console.ReadLine();
                    Console.WriteLine("OrderDetail:Goods_amount");
                    order.orderDetail.Goods_amount = int.Parse(Console.ReadLine());
                    list.Add(order);
                }
                else
                {
                    Console.WriteLine("OrderID repeats!");
                }
        }
        catch (Exception)
        {
            Console.WriteLine(" Input error  ");
        }

        Console.WriteLine("Enter 1 to continue adding...");
        return list;
    }




        //删除订单
        public List<Order> DeleteOrder(List<Order> list)
        {
            Console.WriteLine("Enter an orderID to delete");
            string a = Console.ReadLine();
            if (list.Count()==0) Console.WriteLine("Please add some orders");
            else if (Order_exist(list, int.Parse(a)))
            {

                int b = list.FindIndex(w => w.Order_ID == int.Parse(a));
                list.RemoveAt(b);
            }

            else { Console.WriteLine("invalid Order_ID"); }
            
            Console.WriteLine("Enter 2 to continue deleting...");
            return list;
        }

        //修改订单
        public void ChangeOrder(List<Order> list)
        {
            Console.WriteLine("input the orderID to change");
            int a = int.Parse(Console.ReadLine());
            if (Order_exist(list, a))
            {
                int b = list.FindIndex(w => w.Order_ID == a);
                Console.WriteLine(" 1.Customer_name 2.goods_name 3.total_price 4.unit_price 5.date 6.goods_amount");
                switch (int.Parse(Console.ReadLine()))
                {
                    case 1:
                        Console.WriteLine("Enter the new Customer_name ");
                        list[b].Customer_name = Console.ReadLine();
                        break;
                    case 2:
                        Console.WriteLine("Enter the new Goods_name");
                        list[b].Goods_name = Console.ReadLine();
                        break;
                    case 3:
                        Console.WriteLine("Enter the new Total_price");
                        list[b].Total_price = double.Parse(Console.ReadLine());
                        break;
                    case 4:
                        Console.WriteLine("Enter the new Unit_price");
                        list[b].orderDetail.Unit_price = int.Parse(Console.ReadLine());
                        break;
                    case 5:
                        Console.WriteLine("Enter the new date ");
                        list[b].orderDetail.date = Console.ReadLine();
                        break;
                    case 6:
                        Console.WriteLine("Enter the new Goods_amount");
                        list[b].orderDetail.Goods_amount = int.Parse(Console.ReadLine());
                        break;
                    default:
                        break;
                }
            }
            else  { Console.WriteLine("invalid order_ID"); }
        }
     

        //按订单号查询
        public void Searchby_OrderID(List<Order>list)
        {
            Console.WriteLine("input OrderID to search");
                int a = int.Parse(Console.ReadLine());
                var order1 = list.Where(w => w.Order_ID == a);
                List<Order> list0 = order1.ToList();
            if (list0.Count()!=0)
            {
                list0.ForEach(w => Console.WriteLine("Order:" + w + "OrderDetail:" + w.orderDetail));
            }
            else
            {
                Console.WriteLine("invalid order_ID");
            }
                
        }

        //按顾客名查询
        public void Searchby_Customername(List<Order>list)
        {
            Console.WriteLine("input customername to search");
            string customer_name = Console.ReadLine();
            var orders = from w in list
                         where w.Customer_name == customer_name
                         orderby w.Total_price
                         select w;
            List<Order> list1 = orders.ToList();
            if (list1.Count()!=0)
            {
                list1.ForEach(w => Console.WriteLine(w));
            }
            else
            {
                Console.WriteLine("invalid customername");
            }
        }

        //按商品名查询
        public void Searchby_Goodsname(List<Order> list)
        {
            Console.WriteLine("input Goods_name to search");
            string goods_name = Console.ReadLine();
            var orders = from w in list
                         where w.Goods_name == goods_name
                         orderby w.Total_price
                         select w;
            List<Order> list2 = orders.ToList();
           
            if(list2.Count()==0)
            {
                Console.WriteLine("invalid goods_name");
            }
         else
            {
                list2.ForEach(w => Console.WriteLine(w));
            }
        }

        //按日期进行查询
        public void Searchby_date(List<Order> list)
        {
            Console.WriteLine("input date to search");
            string date = Console.ReadLine();
            var orders = from w in list
                         where w.orderDetail.date == date
                         orderby w.Total_price
                         select w;
            List<Order> list3 = orders.ToList();
            if (list3 .Count()!=0)
            {
                list3.ForEach(w => Console.WriteLine(w));
            }
            else
            {
                Console.WriteLine("invalid date");
            }
        }
        //排序
        public void Sort_list(List<Order> list)
        {
            list.Sort((order1, order2) => order1.Order_ID - order2.Order_ID);
            list.ForEach(w => Console.WriteLine(w));
        }
    } 
}


