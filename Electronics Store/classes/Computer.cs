using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Electronics_Store.classes
{
    [Serializable]
    public class Computer : SmartProduct
    {
        public bool _HasDiskSpace { get; set; }
        public Computer(int Id, string Name, int Price, int Memory,bool HasDiskSpace )
            : base(Id,Name,Price,Memory)
        {
            _HasDiskSpace = HasDiskSpace ;
        }
        public override int getPrice()
        {
            return _Price;

        }
    }
}
