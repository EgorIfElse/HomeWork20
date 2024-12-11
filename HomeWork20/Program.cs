internal class Program


{
    delegate double Mydelegate(double r);
    static void Main(string[] args)
    {
        var r = Convert.ToDouble(Console.ReadLine());
        



        double LineCircle(double r) => 2 * Math.PI * r;

        double SquareCircle(double r) => Math.PI * Math.Pow(r, 2);

        double VolumeCircle(double r) => (4 * Math.PI * Math.Pow(r, 3)) / 3;


        Get(LineCircle, r, "Длина окружности");
        Get(SquareCircle, r, "Площадь круга");
        Get(VolumeCircle, r, "Объем шара");
    }
            static void Get(Mydelegate del, double r, string message)

                   
                   { Console.WriteLine($"{message}, {del(r)}"); }
                   
}