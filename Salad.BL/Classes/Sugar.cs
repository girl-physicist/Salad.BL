using Salad.BL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salad.BL.Classes
{
    class Sugar : WeightedComponent, ICalorityable

    {
        public double CaloriesPerUnit
        {
            get;
            protected set;
        }
        public Sugar(string name, double weight, double calorityPerUnit):base (name:name, weight:weight)
        {
            CaloriesPerUnit = calorityPerUnit;
        }
    }
}
