using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using Electronics_Store.classes;

namespace Electronics_Store.classes
{
    public class extrafunctions
    {
        public static void SaveProductsToFile(BindingList<Product> products)
        {

            BinaryFormatter binaryFormatter = new BinaryFormatter();
            FileInfo fi = new System.IO.FileInfo("Products.bin");
            using (var binaryFile = fi.Create())
            {
                binaryFormatter.Serialize(binaryFile, products);
                binaryFile.Flush();
            }
        }

        public static BindingList<Product> LoadProductsFromFile()
        {
            BindingList<Product> products;
            try
            {
                BinaryFormatter binaryFormatter = new BinaryFormatter();
                FileInfo fi = new System.IO.FileInfo("Products.bin");
                using (var binaryFile = fi.OpenRead())
                {
                    products = (BindingList<Product>)binaryFormatter.Deserialize(binaryFile);
                }
            }
            catch (Exception ex)
            {
                products = new BindingList<Product>();
            }
            return products;
        }
    }
}