using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ordermanagement
{
    class Program
    {  static void Main(string[] args)
        {
           // public List<Order>list {get; set;}
          List<Order> list = new List<Order>();
            OrderService orderService = new OrderService();
           
            bool falg = true;
            //Console.WriteLine("0:Exist 1:AddOrder 2:DeleteOrder 3:ChangeOrder 4:Searchby_OrderID 5:Searchby_Customername 6:Searchby_date 7.Searchby_Goodsname7.Sortlist");
            while (falg)
            {
                Console.WriteLine("------------------------------------------------------------------------------------------------");
                Console.WriteLine("[0:Exist 1:AddOrder 2:DeleteOrder 3:ChangeOrder 4:Searchby_OrderID \n 5:Searchby_Customername 6:Searchby_date 7.Searchby_Goodsname 8.Sortlist 9.Export 10.Import]");
                string value = Console.ReadLine();
                Order order = new Order(1, "null", "null", 0);
                order.orderDetail = new OrderDetails(0, 0, "null");
                int select = 0;
                try
                {
                    select = int.Parse(value);
                }
                catch (Exception)
                {
                    Console.WriteLine("Input error,please input again");
                    continue;
                }
                switch (select) {
                    case 0:
                        falg = false;
                        Console.ReadKey();
                        break;
                    case 1:
                       list= orderService.AddOrder(list,order);
                        break;
                    case 2:
                    orderService.DeleteOrder(list);
                        break;
                    case 3:
                        orderService.ChangeOrder(list);
                        break;
                    case 4:
                        orderService.Searchby_OrderID(list);
                        break;
                    case 5:
                        orderService.Searchby_Customername(list);
                        break;
                    case 6:
                        orderService.Searchby_date(list);
                        break;
                    case 7:
                        orderService.Searchby_Goodsname(list);
                        break;
                    case 8:
                        orderService.Sort_list(list);
                        break;
                   case 9:
                        orderService.Export(list, "orders.xml");
                        break;
                    case 10:
                        orderService.Import("orders.xml");
                        break;
                    default:
                        Console.WriteLine("input error");
                        break;
                }
            }
        }
    }
}
