using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ordermanagement
{
    [Serializable]
    public class OrderDetails
    {

        private double unit_price;
        public double Unit_price
        {
            get
            { return unit_price; }
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("invalid price! Set it as  default value:0");
                    unit_price = 0;
                }
                else
                    unit_price = value;
            }
        }   //商品单价 

        public int goods_amount;
        public int Goods_amount
        {
            get { return goods_amount; }
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("invalid number! Set it as default value:0");
                    goods_amount = 0;
                }
                else
                    goods_amount = value;
            }
        }   //商品数量

        public string date { get; set; }    //出货日期
        public OrderDetails(double unit_price, int goods_amount, string date)
        {

            this.Unit_price = unit_price;
            this.Goods_amount = goods_amount;
            this.date = date;
        }
        public override string ToString()
        {
            return "[Unit_price]:¥" + Unit_price + "  [Goods_amount]:" + Goods_amount + "  [date]:" + date;
        }
        public OrderDetails(){ }
}

}
