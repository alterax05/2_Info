namespace _2_Info
{
    internal class Contenitore
    {
        private int[] array;
        private int dim;
        public Contenitore()
        {
            array = new int[100];
            dim = 0;
        }
        public void InserimentoOrdinato(int n)
        {
            //Ciao zos
            array[dim] = n;
            int i = dim;
            bool fine = false;

            while (i > 0 && !fine)
            {
                if (array[i] < array[i - 1])
                {
                    //Scambio di numeri
                    int temp = array[i];
                    array[i] = array[i - 1];
                    array[i - 1] = temp;

                    i--;
                }
                else
                {
                    fine = true;
                }
            }
            dim++;
        }
        public void Print()
        {
            foreach (int i in array)
            {
                if (i != 0)
                {
                    Console.WriteLine(i);
                }
                else
                {
                    break;
                }
            }
        }
        public int InserimentoOrdinato2(int n)
        {
            int i;
            for (i = dim - 1; i >= 0 && array[i] > n; i--)
            {
                array[i + 1] = array[i];
            }
            array[i + 1] = n;
            dim++;
            return dim;
        }
    }
}
