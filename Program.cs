using System;
using System.Collections.Generic;

namespace ListasyNumeros
{
    class Program
    {
        static void Main(string[] args)
        {
            int [] array = new int [] {1,2,3,4,5}; 
            array[1]=6;
            array[4]=7;

            for (int i = 0; i < array.Length - 1; i++)
            {
                array[i] = array[i+1];
            }
            
            array[4]=8;

            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }

            Console.WriteLine("\n--------\n");

            List<int> ListaNum = new List<int>();
            ListaNum.Add(1);
            ListaNum.Add(2);
            ListaNum.Add(3);
            ListaNum.Add(4);
            ListaNum.Add(5);

            ListaNum[1]=6;
            ListaNum[4]=7;

            ListaNum.RemoveAt(0); 


            ListaNum.Add(8);
            ListaNum.Add(9);

            for (int i = 0; i < ListaNum.Count; i++)
            {
                Console.WriteLine(ListaNum[i]);
            }

            for (int i = 0; i < ListaNum.Count; i++)
            {
                ListaNum[i] = ListaNum[i]*3;
            }
            
            Console.WriteLine("\n--------\n");

            for (int i = ListaNum.Count -1; i >= 0; i--)
            {
                if (ListaNum[i] > 20)
                {
                    ListaNum.RemoveAt(i);
                }
            }
            
            for (int i = 0; i < ListaNum.Count; i++)
            {
                Console.WriteLine(ListaNum[i]);
            }

            Console.WriteLine("\n--------\n");
            
            List<int> NewListNum = new List<int>();
            NewListNum.Add(2);
            NewListNum.Add(6);
            NewListNum.Add(19);
            NewListNum.Add(34);
            NewListNum.Add(65);
            NewListNum.Add(12);
            NewListNum.Add(42);
            NewListNum.Add(33);
            NewListNum.Add(40);
            NewListNum.Add(15);
            
            int mayor = NewListNum[0];
            for (int i = 0; i < NewListNum.Count; i++)
            {
                if (NewListNum[i] > mayor)
                {
                    mayor = NewListNum[i];
                }
            }
            
            for (int i = 0; i < NewListNum.Count; i++)
            {
                Console.WriteLine(NewListNum[i]);
            }

            Console.WriteLine("El número mayor de la lista es " + mayor);
        
        }
        
    }
}
