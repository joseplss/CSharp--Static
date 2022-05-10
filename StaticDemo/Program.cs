using System;

namespace StaticDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var myHouse = new House();

            myHouse.PaintColor = "Green";
            myHouse.HasGarage = true;

            var my2ndHouse = new House();
            my2ndHouse.PaintColor = "Red";
            my2ndHouse.HasGarage = false;

            House.TurnOnLights();

            //using static home I can just use home isntead of creating an object BUT all variables will be assigned to the class. Not the specific object.
            Home.PaintColor2 = "Blue";
            Home.HasGarage = true;
        }
    }
}
