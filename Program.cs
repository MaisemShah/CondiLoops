using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CondiLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] huh = { "huh", "nooo", "llll" };
            Console.WriteLine(huh[1]); 

            foreach (string item in huh)
            {
                Console.WriteLine(huh);
            }

            float[] octopus = { 52f,652f,332f};
            Console.WriteLine(octopus[1]);

            foreach (float i in octopus)
                if (i == 4f)
                        
            {
                var num = i * 10;
                Console.WriteLine(5);
            }

            else
            {
                Console.WriteLine("do it");
            }

            Console.ReadKey();
        }
    }
}
