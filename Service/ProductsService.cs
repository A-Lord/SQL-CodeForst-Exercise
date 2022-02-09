
using DAL;
using Microsoft.EntityFrameworkCore;
using Store.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Service
{
    public class ProductsService
    {
        private static ProductsService _instance;
        public static ProductsService Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new ProductsService();
                }
                return _instance;
            }
        }
        private ProductsService() { }

        public List<Products> ListAllProducts()
        {
            using (var context = new StoreContext())
            {
                return context.Products.ToList();
            }
        }

        public List<Products> ProductList(string department,int count)
        {
            var result = new List<Products>();
            using (var context = new StoreContext())
            {

                
                var departments = context.Departments.SingleOrDefault(x => x.Name == department);
                if (departments != null)
                {
                    var products = departments.products.ToList();
                    foreach (var item in products)
                    {
                        if (item.stock <= count)
                        {
                            result.Add(item);
                        }
                    }
                }

            }
            return result;
        }
        public void UpdateStock(int ArticleNumber,int NewCount)
        {
            using (var context = new StoreContext())
            {
                var Product = context.Products.First(p => p.ArticleNumber == ArticleNumber);
                Product.stock = NewCount;
                context.SaveChanges();
            }
        }
        public string UpdateStatus(int Stock)
        {


            if (Stock > 3)
            {
                return "OK";
            }
            else if (Stock >= 1 && Stock <= 3)
            {
                return "Snart Slut";
            }
            else
            {
                return  "slut";
            }
        }

    }
}
