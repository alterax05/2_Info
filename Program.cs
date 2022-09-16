namespace _2_Info
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Inserisci dim: ");
            int dim = Convert.ToInt32(Console.ReadLine());

            Contenitore v = new Contenitore();
            //v.Inserisci();
            for (int i = 0; i < dim; i++)
            {
                Console.Write("Inserisci numero: ");
                int num = Convert.ToInt32(Console.ReadLine());
                v.InserimentoOrdinato(num);
            }
            v.Print();
        }
    }
}