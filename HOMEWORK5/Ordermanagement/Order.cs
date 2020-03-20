using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ordermanagement
{
 public   class Order
    {
        public OrderDetails orderDetail;

        private int  order_ID;
        public int Order_ID
        {
            get
            { return order_ID;}
            set
            { if (value <= 0)
                {
                    Console.WriteLine("invalid ID! Set it as  default value:1");
                    order_ID = 1;
                }
                else order_ID = value;
            }
        }//订单号

        public string Customer_name {get;set;}   //顾客名
        public string Goods_name { get; set; }   //商品名
        
        private double total_price;
        public double Total_price
        {
            get { return total_price; }
            set { if (value < 0)
                {
                    Console.WriteLine("invalid price! Set it as default value:0");
                    total_price = 0;
                }
                else total_price = value;
            }
        }   //总金额
        public Order(int order_ID,string goods_name,string customer_name,double total_price)
        {
            this.Order_ID = order_ID;
            this.Goods_name = goods_name;
            this.Customer_name = customer_name;
            this.Total_price = total_price;
        }
        public override string ToString()
        {
            return "[Order_ID]:" + Order_ID + "  [Goods_name]:" + Goods_name + "  [Customer_name]:" + Customer_name + "  [Total_price]:¥" + total_price+"\n";
        }
        public override bool Equals(object obj)
        {
            Order m = obj as Order;
            return m.Order_ID == Order_ID ;
        }
        public override int GetHashCode()
        {
            return Order_ID;
        }
    }
}
