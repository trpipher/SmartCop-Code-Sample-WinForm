using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartCop_Code_Sample_WinForm
{
    class Beer : Drink
    {
        protected int _alcohol;

        public override string Description
        {
            get
            {
                return _name + (_carbonated ? ", carbonated" : ", not carbonated") + $", {_alcohol}%.";
            }
        }
        public Beer(string Name, bool Carbonated, int alcohol) : base(Name, Carbonated)
        {
            _alcohol = alcohol;
        }
    }
}
