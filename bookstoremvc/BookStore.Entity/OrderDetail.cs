using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Entity
{
    public class OrderDetail
    {
        public int Id { get; set; }
        public int Bookid { get; set; }
        public string Bookname { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public Decimal TotalAmount { get; set; }
        public int UserId { get; set; }
        public DateTime OrderDate { get; set; }
    }
}
