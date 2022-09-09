namespace Day10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Empbuilder Dmart = new Empbuilder("Dmart", 20, 2, 10);
            Empbuilder Reliance = new Empbuilder("Reliance", 10, 4, 20);
            Dmart.ComputeWage();
            Console.WriteLine(Dmart.ToString());
            Reliance.ComputeWage();
            Console.WriteLine(Reliance.ToString());
        }
    }
    
}