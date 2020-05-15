using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_prog_avancee
{
    class Program
    {
        static void Main(string[] args)
        {
            Simulation S = new Simulation(5);
            S.LancementApplication();

            Console.ReadLine();
        }
    }
}
