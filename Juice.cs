using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartCop_Code_Sample_WinForm
{
    class Juice : Drink
    {
        protected string _fruit;
        public override string Description
        {
            get
            {
                return _name + (_carbonated ? ", carbonated" : ", not carbonated") + $", Made of {_fruit}.";
            }
        }
        public Juice(string Name, bool Carb, string Fruit) : base(Name, Carb)
        {
            _fruit = Fruit;
        }
    }
}
