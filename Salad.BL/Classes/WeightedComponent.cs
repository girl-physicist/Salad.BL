using Salad.BL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salad.BL.Classes
{
   public class WeightedComponent : ISaladItem

    {
        public string Name
        {
            get;
            protected set;
        }

        public double Weight
        {
            get;
            protected set;
        }
        // конструктор
        public WeightedComponent (string name, double weight)
        {
            Name = name;
            Weight = weight;
        }
    }
}
