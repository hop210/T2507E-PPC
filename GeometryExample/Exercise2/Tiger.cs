namespace GeometryExample.Exercise2;

public class Tiger : Animal
{
    public Tiger(double w, string n)
    {
        SetMe(w, n); // gọi method base
    }

    public override void Show()
    {
        Console.WriteLine("Tiger:");
        base.Show();
    }
}