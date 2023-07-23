using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Electronics_Store.classes
{
    [Serializable]
    public abstract class SmartProduct : Product
    {
        public int _Memory { get; set; }
        public SmartProduct(int Id, string Name, int Price, int Memory)
            : base(Id, Name, Price)
        {
            _Memory = Memory;
        }

        public abstract override int getPrice();
    }
}
