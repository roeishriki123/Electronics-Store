using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Electronics_Store.classes;

namespace Electronics_Store.classes
{
    [Serializable]
    public class Case : Product
    {
        public string _Material { get; set; }
        public Case(int Id, string Name, int Price, string Material)
            : base(Id, Name, Price)
        {
            _Material = Material;
        }

        public override int getPrice()
        {
            return _Price ;

        }
    }
}
