using BookStore.Entity;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Services
{
    public class BookStoreService : IBookStoreService
    {
        private string connectionString=string.Empty;
        public BookStoreService(/*IConfiguration configuration*/)
        {
            //////connectionString = configuration["ConnectionStrings:DefaultConnection"];
            connectionString = "Server=DESKTOP-U93N4D3;Database=MyBookStore;Trusted_Connection=true;MultipleActiveResultSets=true";

        }

        public int DMLTransaction(string query)
        {
            throw new NotImplementedException();
        }

        public Book GetBookById(int bookId)
        {
            throw new NotImplementedException();
        }

        public Cart GetCartDetails(string query)
        {
            throw new NotImplementedException();
        }

        public List<Category> GetListCategoryByBookId(int bookId)
        {
            throw new NotImplementedException();
        }

        public List<Book> GetListOfBooks()
        {
           List<Book> books = new List<Book>();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string sql = "Select * from [Book]";
                SqlCommand command= new SqlCommand(sql, connection);
                using(SqlDataReader reader = command.ExecuteReader())
                {
                    while(reader.Read())
                    {
                        books.Add(new Book
                        {
                            Id= Convert.ToInt32(reader["Id"]),
                            Name = reader["Name"].ToString(),
                            Description = reader["Description"].ToString(),
                            ISBNNumber = reader["ISBNNumber"].ToString(),
                            Price = Convert.ToDecimal(reader["Price"]),
                            PictureUri = reader["PictureUri"].ToString(),
                            BookAuthorId = Convert.ToInt32(reader["BookAuthorId"]),
                            BookStoreId = Convert.ToInt32(reader["BookStoreId"])  


                        });
                    }
                }
                connection.Close();
            }
            return books;
        }

        public List<Cart> GetListOfCart(string query)
        {
            throw new NotImplementedException();
        }

        public List<OrderDetail> GetListOfOrder(string query)
        {
            throw new NotImplementedException();
        }

        public List<Store> GetListOfStores(string query)
        {
            throw new NotImplementedException();
        }

        public OrderDetail GetOrderDetails(string query)
        {
            throw new NotImplementedException();
        }

        public Store GetStoreById(string query)
        {
            throw new NotImplementedException();
        }

        public int InsertMultipleRecords(Book book, List<CategoryBook> categories)
        {
            throw new NotImplementedException();
        }
    }
}
