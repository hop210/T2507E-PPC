namespace GeometryExample.Exercise2;

public class Lion : Animal
{
    public Lion(double w, string n)
    {
        SetMe(w, n); // gọi method base
    }

    public override void Show()
    {
        Console.WriteLine("Lion:");
        base.Show();
    }
}