using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Linq_Avto
{
    class Automobile : IEnumerable
    {

        public string MarkName { get; set; }
        public int Price { get; set; }
        public int Power { get; set; }

        public Automobile(string Mark, int _price, int _power )
        {
            MarkName = Mark;
            Price = _price;
            Power = _power;
        }

        //public IEnumerator GetEnumerator() => Power.GetEnumerator();
        public override string ToString()
        {
            //string form = "";
           return $"Mark - {MarkName.PadRight(13)}  Price - {Price},    Power = {Power}";
        }

        public IEnumerator GetEnumerator()
        {
            //throw new NotImplementedException();
            return this.GetEnumerator();
        }
    }
}
