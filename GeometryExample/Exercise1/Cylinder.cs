namespace GeometryExample.Exercise1;

public class Cylinder
{
    private double Radius;
    private double Height;

    private double BaseArea;
    private double LateralArea;
    private double TotalArea;
    private double Volume;

    // Constructor
    public Cylinder(double radius, double height)
    {
        Radius = radius;
        Height = height;
    }

    // Method tính toán
    public void Process()
    {
        BaseArea = Math.PI * Radius * Radius;
        LateralArea = 2 * Math.PI * Radius * Height;
        TotalArea = 2 * Math.PI * Radius * (Height + Radius);
        Volume = Math.PI * Radius * Radius * Height;
    }

    // Method trả kết quả
    public string Result()
    {
        return $"Base Area: {BaseArea:F2}\n" +
               $"Lateral Area: {LateralArea:F2}\n" +
               $"Total Area: {TotalArea:F2}\n" +
               $"Volume: {Volume:F2}";
    }
}