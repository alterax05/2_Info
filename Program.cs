namespace _2_Info
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Inserisci dim: ");
            int dim = Convert.ToInt32(Console.ReadLine());

            Contenitore c = new Contenitore();

            for (int i = 0; i < dim; i++)
            {
                Console.Write("Inserisci numero: ");
                int num = Convert.ToInt32(Console.ReadLine());
                c.InserimentoOrdinato(num);
            }
            c.Print();
        }
    }
}