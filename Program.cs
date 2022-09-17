namespace _2_Info
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Contenitore c = new Contenitore();
            while (true)
            {
                Console.Write("Inserisci numero: ");
                c.InserimentoOrdinato2(Convert.ToInt32(Console.ReadLine()));
                c.Print();
            }
        }
    }
}