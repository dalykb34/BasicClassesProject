using System;
using System.Collections.Generic;
using System.Text;

namespace BasicClassesProject
{
    public class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }

        public string Nickname { get; set; }
        public string EngineNoise { get; set; }
        public string HonkNoise { get; set; }
        public string Upgrades { get; set; }

        public void MakeEngineNoise()
        {
            Console.WriteLine($"{EngineNoise}");
        }
        public void MakeHonkNoise()
        {
            Console.WriteLine(HonkNoise);
        }
    }
}
