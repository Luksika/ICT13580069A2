using System;
using System.Collections.Generic;
using ICT13580069A2.Models;
using SQLite;
namespace ICT13580069A2.Helpers
{
    public class Dbhelper
    {
        SQLiteConnection db;
        public Dbhelper(string dbPath)
        {
            db = new SQLiteConnection(dbPath);
            db.CreateTable<Product>();
        }
        public int AddProduct(Product product)
        {
            db.Insert(Product);
            return Product.Id;

        }
        public List<Product> GetProducts()

        {
            return db.Table<Product>().ToList();
    }
        public int UpdateProduct(Product product)
        {
            return db.Update(product);
        }
        public int DeleteProduct (Product product)
        {
            return db.Delete(product);
        }
}
}
