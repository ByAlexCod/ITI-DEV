using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ITI.bottle;

namespace ITI.bottle
{
    class Program
    {
        static void Main(string[] args)
        {
            Bottle b = new Bottle(986, "Bière");
            Console.WriteLine("Veuillez entrer le volume actuel : (max " + b.Capacity + ").");
            int reqvol = Convert.ToInt32(Console.ReadLine());

            b.Volume = reqvol;

            Console.WriteLine(b.Capacity);
            Console.WriteLine(b.Volume);
            Console.WriteLine(b.calcul);
            Console.WriteLine(b.name);

            Console.WriteLine("Il y a actuellement dans la bouteille " + b.Volume + "ml de " + b.name + ". Il reste donc " + b.calcul + "mL de bière.");


            Console.ReadLine();
        }
    }
}
