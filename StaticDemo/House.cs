using System;
using System.Collections.Generic;
using System.Text;

namespace StaticDemo
{
    public class House
    {
        public House()
        {
        }

        public string PaintColor { get; set; }
        public bool HasGarage { get; set; }
        public static void TurnOnLights()
        {
            Console.WriteLine("House lights are on");
        }
    }
    public static class Home
    {
        public static string PaintColor2 { get; set; }
        public static bool HasGarage { get; set; }
    }
    
}
