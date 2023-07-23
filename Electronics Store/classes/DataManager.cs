using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


using Electronics_Store.classes ;


namespace Electronics_Store.classes
{
    public class DataManager
    {
        private static BindingList<Product> products ;
        static DataManager()
        {
            products = extrafunctions.LoadProductsFromFile();
        }
        public static void saveProd(object sender, FormClosingEventArgs e)
        {
            extrafunctions.SaveProductsToFile(products);
        }
        public static BindingList<Product> GetProducts()
        {
            return products;
        }
        public static void AddProduct(Product prod)
        {
            products.Add(prod);
            extrafunctions.SaveProductsToFile(products); // Save the updated list of products
        }
        public static void RemoveProduct(Product prod)
        {
            products.Remove(prod);
            extrafunctions.SaveProductsToFile(products); // Save the updated list of products
        }
        public static BindingList<T> GetSpecificProduct<T>() where T : Product
        {
            BindingList<T> specificProduct = new BindingList<T>();
            foreach (Product prod in products)
            {
                if (prod is T)
                {
                    specificProduct.Add(prod as T);
                }
            }
            return specificProduct;
        }
        public static BindingList<Product> getAllProd()
        {
            BindingList<Product> prod = new BindingList<Product>();
            foreach (Product product in products)
            {
                prod.Add(product);
            }
            return prod;
        }
        
        public static T getProduct<T>(Product prod) where T : Product
        {
            foreach (Product product in products)
            {
                if (product == prod)
                {
                    return (product as T);
                }
            }
            return null;

        }

        public static Product getById(int num)
        {
            foreach (Product product in products)
            {
                if (product._Id == num)
                {
                    return (product);
                }
            }
            return null;

        }
    }
}