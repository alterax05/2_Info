namespace _2_Info
{
    internal class Contenitore
    {
        private int[] array;
        private int num;
        public Contenitore()
        {
            array = new int[1000];
            num = 0;
        }
        public void Print()
        {
            for (int i = 0; i < num; i++)
            {
                Console.Write(array[i] + " ");
            }
        }
        public int InserimentoOrdinato(int n)
        {
            int i;
            for (i = num - 1; i >= 0 && array[i] > n; i--)
            {
                array[i + 1] = array[i];
            }
            array[i + 1] = n;
            num++;
            return num;
        }
        public void BubbleSort()
        {
            for (int i = 0; i < num - 1; i++)
            {
                for (int j = 0; j < num - i - 1; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        int temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                    }
                }
            }
        }
        public void Input(int n)
        {
            array[num] = n;
            num++;
        }
        public int Elemento_Piu_Frequente()
        {
            int n = array[0];
            int volte_max = 0;

            for (int i = 0; i < num; i++)
            {
                int volte = 0;
                for (int j = i; j < num; j++)
                {
                    if (array[i] == array[j])
                    {
                        volte++;
                    }
                }
                if (volte_max < volte)
                {
                    volte_max = volte;
                    n = array[i];
                }
            }
            return n;
        }
    }
}
