using Salad.BL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salad.BL.Classes
{
   public class GeneralSalad : ISalad

    {
        public ICollection<ISaladItem> items
        {
            get;
           protected set;
        }

        public string Name
        {
            get;
            protected set;
        }

        
             public double Sugar
        {
            get { throw new NotImplementedException(); }
        }
    
        public double Weight
        {
            get
            {
                if (items != null)
                { return items.Sum(x => x.Weight); }
                else
                { throw new InvalidOperationException("Conteiner in Salad cannot be null"); }
            }
            
        }
        public ICollection<ISaladItem>Items
        {
            get;
            protected set;
        }
        public GeneralSalad (string name, ICollection<ISaladItem>items)
        {
            Name = name;
            Items = items;
        }
    }
}
