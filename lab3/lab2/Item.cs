using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    public class Item
    {
        public string name { get; set; }

        public int weigth { get; set; }

        public int price { get; set; }

        public float unitPrice { get; set; }

        public Item(string _name, int _weigth, int _price)
        {
            name = _name;
            weigth = _weigth;
            price = _price;
            unitPrice = (float) price / weigth;
        }
        
    }
}
