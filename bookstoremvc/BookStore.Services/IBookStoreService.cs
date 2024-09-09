using BookStore.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Formats.Asn1.AsnWriter;


namespace BookStore.Services
{
    public interface IBookStoreService
    {
        public List<Book> GetListOfBooks();
        public List<Category> GetListCategoryByBookId(int bookId);
        public OrderDetail GetOrderDetails(string query);
        public Cart GetCartDetails(string query);
        public List<Cart> GetListOfCart(string query);
        public List<OrderDetail> GetListOfOrder(string query);
        public int InsertMultipleRecords(Book book, List<CategoryBook> categories);
        public Store GetStoreById(string query);
        public List<Store> GetListOfStores(string query);
        public Book GetBookById(int bookId);
        public int DMLTransaction(string query);
    }
}
