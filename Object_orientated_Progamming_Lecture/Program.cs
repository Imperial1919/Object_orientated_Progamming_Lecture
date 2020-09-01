using classiccar;
using System;

namespace Object_orientated_Progamming_Lecture
{
    class Program
    {
        static void Main(string[] args)
        {
            classic_car Cadillac_S62 = new classic_car();
            {

                Cadillac_S62.make = "Cadillac Motor Company";
                Cadillac_S62.model = "Series 62 Convertible";
                Cadillac_S62.year = 1947;
                Console.WriteLine($"Car Model Series: {Cadillac_S62.model}");
                
                Console.WriteLine($"Make: {Cadillac_S62.make}");

                Console.WriteLine($"Year Built: {Cadillac_S62.year}");
            }
        }
    }
}


