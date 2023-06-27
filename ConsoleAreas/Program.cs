using System;
using FiguresAreasLibrary;

namespace ConsoleAreas
{
    class Program
    {

        
        static void Main(string[] args)
        {
            double r;
            try
            {
                r = double.Parse(Console.ReadLine());

                Circle circle = new Circle(r);
                Console.WriteLine(circle.CalculateArea());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            
        }
    }
}
