using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VectorP
{
    class NumEnt
    {
        private int n;
        public NumEnt() //inicial
        {
            n = 0;
        }
        public NumEnt(int x)  //Parametrizado
        {
            n = x;
        }
        public NumEnt(NumEnt objeto) //Copia
        {
            n = objeto.n;
        }
        public void Cargar(int dato)
        {
            n = dato;
        }
        public bool VerificarFibo()
        {
            int a = -1;
            int b = 1;
            int c = a + b;
            while (c < n)
            {
                a = b;
                b = c;
                c = a + b;
            }
            if (c == n)
                return true;
            return false;
        }
        public bool EsPrimo()
        {
            if (n < 2)
            {
                return false;
            }

            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0)
                {
                    return false;
                }
            }

            return true;
        }
        public bool EsCapicua()
        {
            bool s;
            int Numeroaux = n;
            int NumeroInvertido = 0;


            while (Numeroaux > 0)
            {
                NumeroInvertido = (NumeroInvertido * 10) + (Numeroaux % 10);
                Numeroaux /= 10;
            }
            if (n == NumeroInvertido)
                s = true;
            else
                s = false;
            return s;
        }
    }
}
