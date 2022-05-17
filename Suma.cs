using System;
using System.Collections.Generic;
using System.Text;


namespace JoseMero3AEJ5
{
    public class Suma
    {
        private int[] num { set; get; }
        private int suma { get; set; }

        public void proceso()
        {
        num = new int[8] { 5, 6, 7, 8, 9, 5, 6, 5 } ;
            for (int i = 0; i <= 7; i++)
            {
                
                Console.WriteLine("Numeros "+num[i]);
                suma = suma + num[i];
            }
            Console.WriteLine("Suma total: " +suma);
        }
    }
}
