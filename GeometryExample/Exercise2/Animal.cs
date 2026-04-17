namespace GeometryExample.Exercise2;

public class Animal
{
    protected double weight;
    protected string name;

    public void SetMe(double w, string n)
    {
        weight = w;
        name = n;
    }

    public virtual void Show()
    {
        Console.WriteLine($"Name: {name}, Weight: {weight}");
    }
}