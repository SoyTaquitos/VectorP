using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VectorP
{
    class Vector
    {
        //Atributos
        private int n, max;
        private int[] v;

        //Constructor
        public Vector()
        {
            max = 50;
            n = 0;
            v = new int[max];
        }
         
        //Métodos
        public void CargarE(int a) //Elemento por Elemento
        {
            n++;
            v[n] = a;
        }
        public void Cargar(int n1, int a, int b) //Cargar normal
        {
            int i;
            Random r;
            r = new Random();
            n = n1;
            for (i = 1; i <= n; i++)
                v[i] = r.Next(a, b);
        }
        public string Descargar()
        {
            int i;
            string s = "";
            for (i = 1; i <= n; i++)
            {
                s = s + " | ";
                s = s + string.Concat(v[i]);
            }
            return s;
        }
        //Métodos de ayuda
        public void Intercambiar(int p1, int p2)
        {
            int aux;
            aux = v[p1];
            v[p1] = v[p2];
            v[p2] = aux;
        }
        public void CargarSerie(int ne, int b)
        {
            n = ne + 1;
            int exp = ne + 1;
            for (int i = 1; i <= n; i++)
            {
                exp--;
                v[i] = (int)Math.Pow((b * 1.0), (exp * 1.0));
            }
        }
        public double AcumularConElementosDelVector()
        {
            int i, ban = 1; ;
            double f = 0;
            for (i = 1; i <= n; i++)
            {
                if (ban == 1)
                {
                    f -= Math.Pow(v[i], 1.0 / (i + 1));
                    ban++;
                }
                else
                {
                    f += Math.Pow(v[i], 1.0 / (i + 1));
                    ban = 1;
                }

            }
            return f;
        }
        public int ContarFibos(int m)
        {
            NumEnt nu = new NumEnt();
            int num = m;
            int cont = 0;
            for (int i = m; i <= n; i = i + m)
            {
                nu.Cargar(v[i]);
                if (nu.VerificarFibo())
                {
                    cont++;
                }
            }
            return cont;
        }
        public double EncontrarMedia(int vi, int r)
        {
            int c = 0, sum = 0;
            double me = 0;
            for (int i = vi; i <= n; i = i + r)
            {
                sum = sum + v[i];
                c++;
            }
            me = sum * 1.0 / c * 1.0;
            return me;
        }
        public void PrimoyNoPrimo(Vector R1, Vector R2)
        {
            NumEnt nu = new NumEnt();
            for (int i = 1; i <= n; i++)
            {
                nu.Cargar(v[i]);
                if (nu.EsPrimo())
                {
                    R1.CargarE(v[i]);
                }
                else
                {
                    R2.CargarE(v[i]);
                }
            }
        }       
        public void InvertirElementos(int a, int b)      
        {
            for (int i = b; i >= a; i--)

            {
                if (a < b)
                    this.Intercambiar(a, b);
                a++;
                b--;
            }
        }              
        public int BusquedaSecuencial(int ele, int a, int b)
        {
            int posi = 0;
            for (int i = a; i <= b; i++)
            {
                if (ele == v[i])
                {
                    posi = i;
                    break;
                }
                else
                    posi = 0;

            }
            return posi;
        }
        public void InterseccionDeElementos(Vector v2, Vector v3)
        {
            int ele;
            for (int i = 1; i <= v2.n; i++)
            {
                ele = v2.v[i];
                if ((v3.BusquedaSecuencial(ele, 1, v3.n) != 0) && (this.BusquedaSecuencial(ele, 1, n) == 0))
                {
                    this.CargarE(ele);
                }
            }
        }
        public void UniónDeElementos (Vector v2,Vector v3) 
        {
            for (int i = 1; i <= v2.n; i++)
            {
                this.CargarE(v2.v[i]);
            }
            for (int i = 1; i <= v3.n; i++)
            {
                if (this.BusquedaSecuencial(v3.v[i],1,v3.n)==0)
                {
                    this.CargarE(v3.v[i]);
                }
            }            
        }
        public bool VerificarSegmentoOrdenado(int a,int b)
        {
            bool r = true;
            for (int i = 1; i <= b; i++)
            {
                if (v[i] <= v[i + 1])
                {
                    r = true;
                }
                else
                {
                    r = false;
                    break;
                }
            }
            return r;
           
        }
        //-------------------------------PARTE 2----------------------------------
        // Métodos de ayuda
        public void InserDer(Vector aux) 
        {
            int i;
            for (i = 1; i <= aux.n; i++)
            {
                this.CargarE(aux.v[i]);
            }
        }
        public void OrdenamientoBurbuja()
        {
            int d;
            for (int t = n; t >= 2; t--)
                for(d = 1; d <= t -1; d++)
                    if (v[d] > v[d + 1])                  
                        this.Intercambiar(d, d + 1);
        }
        //Métodos
        public void InserObj(Vector y, int p) //N1
        {
            Vector aux = new Vector();
            for (int i = p; i <= n; i++)
            {
                aux.CargarE(v[i]);
            }
            n = p - 1;
            for (int i = 1; i <= y.n; i++)
            {
                this.CargarE(y.v[i]);

            }
            this.InserDer(aux);
        }
        public void EliminarEle(int a, int b) //N2
        {
            int i;
            Vector aux = new Vector();
            for (i = b + 1; i <= n; i++)
            {
                aux.CargarE(v[i]);
            }
            n = a - 1;
            this.InserDer(aux);
        }
        public void GirarPosiIzq(int m) //N3
        {
            for (int i = 1; i <= m; i++)
            {
                int aux = v[1];
                this.CargarE(aux);
                this.EliminarEle(1, 1);
            }
        }
        public void OrdEleSeg(int a, int b) //N4
        {
            int i, j;
            for (i = a; i < b; i++)           
                for (j = i + 1; j <= b; j++)                
                    if (v[i] > v[j])                   
                        this.Intercambiar(i, j);                                                                     
        }
        public int ContarElementosDiferentes(int a, int b) //N5
        {
            int i = a, aux, cont = 0;
            Vector v1 = new Vector();
            v1 = this;
            v1.OrdEleSeg(a, b);
            while (i <= b)
            {
                aux = v1.v[i];
                while (v1.v[i] == aux)
                {
                    i++;
                }
                cont++;
            }
            return cont;
        }       
        public int ElementoMenosRepetido(int a,int b) //N6
        {
            Vector d = new Vector();
            Vector f = new Vector();
            int i = a;
            int ele,fr,result;
            int nm = 1;
            int men;
            this.OrdenamientoBurbuja();
            while (i<=b)
            {
                fr = 0;
                ele = v[i];
                while ((i<=b)&&(v[i]==ele))
                {
                    i++;
                    fr++;                   
                }
                d.CargarE(ele);
                f.CargarE(fr);               
            }
            men = f.v[1];          
            for (int p = 2; p < f.n; p++)
            {
                if (men > f.v[p])
                {
                    men = f.v[p];
                    nm = p;
                }              
            }            
            result = d.v[nm];
            return result;
        }
        public void DistribucionyFrecuencia(int a, int b, ref Vector d, ref Vector f) //N7
        {
            int i = a;
            int ele, fr;
            this.OrdEleSeg(a, b);
            while (i <= b)
            {
                fr = 0;
                ele = v[i];
                while ((i <= b) && (v[i] == ele))
                {
                    i++;
                    fr++;
                }
                d.CargarE(ele);
                f.CargarE(fr);
            }

        }
        public void Intercalacion2Vectores(Vector v1, Vector v2) //N8
        {
            if (v1.n > v2.n)
            {
                for (int i = 1; i <= v2.n; i++)
                {
                    this.CargarE(v1.v[i]);
                    this.CargarE(v2.v[i]);
                }
                for (int i = v2.n + 1; i <= v1.n; i++)
                {
                    this.CargarE(v1.v[i]);
                }
            }
            else
                for (int i = 1; i <= v1.n; i++)
                {
                    this.CargarE(v1.v[i]);
                    this.CargarE(v2.v[i]);
                }
            for (int i = v1.n + 1; i <= v2.n; i++)
            {
                this.CargarE(v2.v[i]);
            }

        }
        public void SegPriNoPri(int a, int b) //N9 esta mal
        {
            int p, d;
            NumEnt e1, e2;
            e1 = new NumEnt(); e2 = new NumEnt();
            for (p = a; p <= b - 1; p++)
                for (d = p + 1; d <= b; d++)
                {
                    e1.Cargar(v[p]); e2.Cargar(v[d]);
                    if (!e1.EsPrimo() && e2.EsPrimo() ||
                        e1.EsPrimo() && e2.EsPrimo() && (v[d] < v[p]) ||
                        !e1.EsPrimo() && !e2.EsPrimo() && (v[d] < v[p]))
                    {
                        OrdEleSeg(a, b);
                        Intercambiar(p, d);
                    }
                }
        }
        public void SegCapiNoCapi() //N10
        {
            int p, d;
            NumEnt e1, e2;
            e1 = new NumEnt(); e2 = new NumEnt();
            for (p = 1; p <= n - 1; p++)
                for (d = p + 1; d <= n; d++)
                {
                    e1.Cargar(v[p]); e2.Cargar(v[d]);
                    if ((!e1.EsCapicua() && e2.EsCapicua()) ||
                        (e1.EsCapicua() && e2.EsCapicua() && (v[d] < v[p])) ||
                        (!e1.EsCapicua() && !e2.EsCapicua() && (v[d] > v[p])))
                    {
                        Intercambiar(p, d);
                    }
                }
        }
        public void IntercalarPrimoNoPrimo(int a, int b) //N11
        {
            int p, d;
            bool swich = false;
            NumEnt e1, e2;
            e1 = new NumEnt(); e2 = new NumEnt();
            for (p = a; p <= b - 1; p++)
            {
                swich = !swich;
                for (d = p + 1; d <= b; d++)
                {
                    e1.Cargar(v[p]); e2.Cargar(v[d]);
                    if (swich)
                    {
                        if (!e1.EsPrimo() && e2.EsPrimo() ||
                            e1.EsPrimo() && e2.EsPrimo() && (v[d] < v[p]) ||
                            !e1.EsPrimo() && !e2.EsPrimo() && (v[d] < v[p]))
                        {
                            Intercambiar(p, d);
                        }
                    }
                    else
                    {
                        if (e1.EsPrimo() && !e2.EsPrimo() ||
                            e1.EsPrimo() && e2.EsPrimo() && (v[d] < v[p]) ||
                            !e1.EsPrimo() && !e2.EsPrimo() && (v[d] < v[p]))
                        {
                            Intercambiar(p, d);
                        }
                    }

                }
            }
        }


    }              
}
