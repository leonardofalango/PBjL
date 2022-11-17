public class Coordenador
{
    public int n { get; set; }
    public double a { get; set; }
    public double b { get; set; }
    public Calculador[] calculadores { get; private set; }
    public Coordenador (
        Calculador c1,
        Calculador c2,
        Calculador c3,
        Calculador c4,
        double a,
        double b,
        int n
    )
    {
        this.calculadores = new Calculador[] {
            c1,
            c2,
            c3,
            c4
        };

    }
    public void Run()
    {
        int n = this.n;
        
    }
}