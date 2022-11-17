public class Coordenador
{
    public int n { get; set; }
    public double a { get; set; }
    public double b { get; set; }
    public string Name { get; set; }
    public Coordenador (
        string name,
        double a,
        double b,
        int n
    )
    {
        this.Name = name;
        this.a = a;
        this.b = b;
        this.n = n;
    }

    public void Run()
    {
        double start = this.a, end = this.b;
        int number = this.n / 4;


        for (int i = 1; i < 5; i++)
        {
            double x = start / 4 * i;
            double y = end / 4 * i;

            Thread t = new Thread (
                new ThreadStart (
                    new Calculador (
                        x,
                        y,
                        number
                    ).calc
                )
            );

            t.Start();
            Thread.Sleep(1000);
        }
    }
}