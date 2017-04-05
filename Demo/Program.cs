using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Salad.BL.Interfaces;
using Salad.BL.Classes;
namespace Demo
{
    class Program
    {
        static void Main()
        {
            Tomato t = new Tomato("Cherry", 100, 15);
            Tomato t2 = new Tomato("Tomato", 200, 18 * 2);
            GeneralSalad salad = new GeneralSalad("Greek", new List<ISaladItem>());
            salad.Items.Add(t);
            salad.Items.Add(t2);

            Console.WriteLine("Salad " + salad);
            Console.ReadKey();
        }
    }
}
