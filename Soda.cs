using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartCop_Code_Sample_WinForm
{
    class Soda : Drink
    {
        public override string Description
        {
            get
            {
                return _name + (_carbonated ? ", carbonated." : ", not carbonated.");
            }
        }

        public Soda(string Name, bool Carbonated) : base(Name, Carbonated)
        { }

    }
}
