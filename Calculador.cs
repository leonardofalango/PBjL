public class Calculador
{
    public double a { get; private set; }
    public double b { get; private set; }
    public int n { get; private set; }
    public double function(double x) => 2 * Math.Sin(x) + Math.Cos(x) / 3 + 3;
    public void calc()
    {
        if (n <= 0)
            throw new Exception();
        
        double areaTotal = 0;
        double x = a;
        double h = (b-a) / n;
        double  y1 = function(x);
        int i = 0;
        while (i<n)
        {
            x += h;
            double y2 = function(x);
            double areaTrapezio = ((y1 + y2) / 2) * h;
            areaTotal += areaTrapezio;
            y1 = y2;
            i++;
        }

        Console.WriteLine($"Resultado da integral: {areaTotal}");
    }
    
    public Calculador(double a, double b, int n)
    {
        this.a = a;
        this.b = b;
        this.n = n;
    }
}