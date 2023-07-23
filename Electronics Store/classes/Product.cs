using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Electronics_Store.classes
{
    [Serializable]
    public abstract class Product
    {
        public int _Id { get; set; }
        public string _Name { get; set; }
        public int _Price { get; set; }

        public Product(int Id, string Name, int Price)
        {
            _Id = Id ;
            _Name = Name ;
            _Price = Price ;
        }
        public abstract int getPrice();
        
    }
}
