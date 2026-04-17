// See https://aka.ms/new-console-template for more information

using GeometryExample.Exercise1;
using GeometryExample.Exercise2;
namespace GeometryExample;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("=== Exercise 1 ===");

        Console.Write("Enter radius: ");
        double r = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter height: ");
        double h = Convert.ToDouble(Console.ReadLine());

        Cylinder c = new Cylinder(r, h);
        c.Process();
        Console.WriteLine(c.Result());

        Console.WriteLine();

        Console.WriteLine("=== Exercise 2 ===");

        Lion lion = new Lion(190.5, "Simba");
        Tiger tiger = new Tiger(210.3, "Sheru");

        lion.Show();
        Console.WriteLine();
        tiger.Show();
    }
}
