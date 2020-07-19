using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CandyShop.Models
{
    public class OrderDetail
    {
        public int OrderDetailid { get; set; }
        public int Orderid { get; set; }
        public int CandyId { get; set; }
        public Candy Candy { get; set; }
        public int Amount { get; set; }
        public decimal Price { get; set; }
        public Order Order { get; set; }
    }
}
