using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        //public void Inserisci()
        //{
        //    for (int i = 0; i < dim; i++)
        //    {
        //        Console.Write("Inserisci il numero: ");
        //        array[i] = Convert.ToInt32(Console.ReadLine());
        //    }
        //}

        public void InserimentoOrdinato(int n)
        {
            array[dim] = n;
            int i = dim;
            bool fine = false;

            while (i > 0 && ! fine)
            {
                if(array[i] < array[i - 1])
                {
                    int temp = array[i];
                    array[i] = array[i - 1];
                    array[i - 1] = temp;

                }
                else
                {
                    fine = true:
                }
            }
            dim++;
        } 

 /*        public void InserimentoOrdinato(int n)
        {
            array[dim] = n;  //metto il nuovo valore alla fine
            int i = dim;
            bool finito = false;

            while (i > 0 && !finito)
            {
                if (array[dim] < array[i - 1])
                {
                    array[i] = array[i - 1];
                    array[i - 1] = n;
                    i--;
                }
                else
                {
                    finito = true;
                }
            }
            dim++;
        } */

        public void Print()
        {
            foreach (int i in array)
            {
                if (i!=0)
                {
                    Console.WriteLine(i);
                }
                else
                {
                    break;
                }
            }
        }
    }
}
