using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace VanDerBrinckesBakfietsenVerdieping.Models
{
    public class AccessoireModel
    {
        public string Name { get; set; }
        public double Price { get; set; }

        public AccessoireModel(string name, int price)
        {
            Name = name;
            Price = price;
        }

        public override string ToString()
        {
            return $"{Name} € {Price}";
        }
    }
}

