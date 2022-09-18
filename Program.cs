namespace _2_Info
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Contenitore c = new Contenitore();

            Console.Write("Scelte possibili: \n" +
                            "1. Inserimento ordinato \n" +
                            "2. Bubble Sort \n" +
                            "3. Elemento più frequente\n" +
                            "Scelta: ");
            int scelta = Convert.ToInt32(Console.ReadLine());

            Console.Write("Inserire dimensione: ");
            int dim = Convert.ToInt32(Console.ReadLine());

            while (dim > 0 && scelta != 1)
            {
                c.Input(Convert.ToInt32(Console.ReadLine()));
                dim--;
            }

            switch (scelta)
            {
                case 1:
                    while (dim > 0)
                    {
                        c.InserimentoOrdinato(Convert.ToInt32(Console.ReadLine()));
                        dim--;
                    }
                    c.Print();
                    break;
                case 2:
                    c.BubbleSort();
                    c.Print();
                    break;
                case 3:
                    Console.Write("Elemento più frequente: " + c.Elemento_Piu_Frequente());
                    break;
                default:
                    break;
            }
        }
    }
}