using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Electronics_Store.classes
{
    [Serializable]
    public class Phone : SmartProduct
    {
        public string _RearCameraQuality { get; set; }
        public Phone(int Id, string Name, int Price, int Memory, string RearCameraQuality)
            : base(Id, Name, Price, Memory)
        {
            _RearCameraQuality = RearCameraQuality ;
        }
        public override int getPrice()
        {
            return _Price;

        }
    }
}
