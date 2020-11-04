using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartCop_Code_Sample_WinForm
{
    class Drink
    {
        protected string _name;
        protected bool _carbonated;
        public virtual string Description
        {
            get
            {
                return _name + " " + _carbonated;
            }
        }
        public Drink(string Name, bool Carbonated)
        {
            _name = Name;
            _carbonated = Carbonated;
        }
    }
}
