using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    internal abstract class Goods
    {
        private string name;
        private int code;
        private string description;
        private int price;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public int Code
        {
            get { return code; }
            set { code = value; }
        }
        public string Description
        {
            get { return description; }
            set { description = value; }
        }
        public int Price
        {
            get { return price; }
            set { price = value; }
        }
        public Goods(string name, int code, string description, int price)
        {
            this.name = name;
            this.code = code;
            this.description = description;
            this.price = price;
        }
        public abstract void ShowInfo();
       
    }
}
