namespace GeometryExample.Exercise2;

public class Lion : Animal
{
    public Lion(double w, string n)
    {
        SetMe(w, n); 
    }

    public override void Show()
    {
        Console.WriteLine("Lion:");
        base.Show();
    }
}