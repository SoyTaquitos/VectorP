using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace VectorP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Vector v1,v2,v3;
        private void Form1_Load(object sender, EventArgs e)
        {
            v1 = new Vector();
            v2 = new Vector();
            v3 = new Vector();
        }       
        private void cargarToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            v1.Cargar(int.Parse(textBox1.Text), int.Parse(textBox2.Text), int.Parse(textBox3.Text));
        }
        private void descargarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox4.Text = v1.Descargar();
            label4.Text = "Vector 1";       
        }
        private void cargarElementoPorElementoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int i, n;
            n = int.Parse(Interaction.InputBox("Cantidad de Elementos", "Cargar"));
            v1.Cargar(0, 0, 0); //Reinicia el vector si esque quiero cargar algo nuevo
            for (i = 1; i <= n; i++)
               {
                v1.CargarE(int.Parse(Interaction.InputBox("Elemento" + i + ":")));
               }
        }
        private void cargarSerieBneToolStripMenuItem_Click(object sender, EventArgs e)
        {
            v1.CargarSerie(int.Parse(textBox1.Text), int.Parse(textBox3.Text));
            label4.Text = "Serie";
            textBox4.Text = v1.Descargar();
        }

        private void acumularConElementosDelVectorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox5.Text = string.Concat(v1.AcumularConElementosDelVector());
            label4.Text = "Vector";
            label5.Text = "Elementos acumulados del Vector";
            
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void encontrarMediaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox5.Text = string.Concat(v1.EncontrarMedia(int.Parse(textBox8.Text), int.Parse(textBox2.Text)));
            label5.Text = "Media del Vector";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
            textBox8.Clear();
            label1.Text = @"Rango ""a"" ";
            label2.Text = @"Rango ""b"" ";
            label3.Text = "Cantidad de Elementos";
            label4.Text = "";
            label5.Text = "";
            label6.Text = "";
            label7.Text = "";
        }

        private void cargarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            v2.Cargar(int.Parse(textBox1.Text), int.Parse(textBox2.Text), int.Parse(textBox3.Text));
        }

        private void cargarToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            v3.Cargar(int.Parse(textBox1.Text), int.Parse(textBox2.Text), int.Parse(textBox3.Text));
        }

        private void descargarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            textBox5.Text = v2.Descargar();
            label5.Text = "Vector 2";
        }

        private void descargarToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            textBox6.Text = v3.Descargar();
        }

        private void invertirElementosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            v1.InvertirElementos(int.Parse(textBox2.Text), int.Parse(textBox3.Text));
            textBox5.Text = v1.Descargar();
            label5.Text = "Elementos invertidos";
        }

        private void busquedaSecuencialDeUnElementoEnRangoAYBToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox5.Text = string.Concat(v1.BusquedaSecuencial(int.Parse(textBox7.Text),int.Parse(textBox2.Text),int.Parse(textBox3.Text)));
            label5.Text = "Se encuentra en la posicion";
        }
        private void cargarElementoPorElementoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            int i, n;
            n = int.Parse(Interaction.InputBox("Cantidad de Elementos", "Cargar"));
            v2.Cargar(0, 0, 0); //Reinicia el vector si esque quiero cargar algo nuevo
            for (i = 1; i <= n; i++)
            {
                v2.CargarE(int.Parse(Interaction.InputBox("Elemento" + i + ":")));
            }
        }

        private void verificarSiElSegmentoAYBEstaOrdenadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox5.Text = string.Concat(v1.VerificarSegmentoOrdenado(int.Parse(textBox2.Text), int.Parse(textBox3.Text)));
            label5.Text = "Resultado del Segmento";
        }

        private void interseccionDeElementosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            v3.InterseccionDeElementos(v1, v2);
            textBox6.Text = v3.Descargar();
            label4.Text = "Vector 1";
            label6.Text = "Vector 2";
            label7.Text = "Intersección en Vectores";
        }

        private void uniónDeElementosToolStripMenuItem_Click(object sender, EventArgs e)
        {            
            v3.UniónDeElementos(v1,v2);
            textBox6.Text = v3.Descargar();
            label4.Text = "Vector 1";
            label6.Text = "Vector 2";
            label7.Text = "Unión de Elementos";
        }

        private void toolStripTextBox2_Click(object sender, EventArgs e)
        {

        }

        private void insertarObjetoEnUnaPosicionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            v1.InserObj(v2, int.Parse(textBox8.Text));
            textBox6.Text = v1.Descargar();
            label7.Text = "Objeto Insertado";
        }

        private void prueba1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox5.Text = string.Concat(v1.ElementoMenosRepetido(int.Parse(textBox2.Text), int.Parse(textBox3.Text)));
            label5.Text = "Elemento menos repetido";
            
        }

        private void encontrarLaFrecuenciaDeDistribuciónDeElementosDelSegmentoEntreAYBToolStripMenuItem_Click(object sender, EventArgs e)
        {
            v1.DistribucionyFrecuencia(int.Parse(textBox2.Text), int.Parse(textBox3.Text), ref v2, ref v3);
            textBox4.Text = v1.Descargar();
            textBox5.Text = v2.Descargar();
            textBox6.Text = v3.Descargar();
            label4.Text = "Vector";
            label5.Text = "Distribución";
            label7.Text = "Frecuencia";

        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            v3.Intercalacion2Vectores(v1,v2);
            textBox6.Text = v1.Descargar();
            label7.Text = "Elementos de vector intercalado";
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            v1.EliminarEle(int.Parse(textBox2.Text), int.Parse(textBox3.Text));
            textBox5.Text = v1.Descargar();
            label5.Text = "Vector Resultante";
        }

        private void girarNPosicionesLosElementosHaciaLaIzquierdaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            v1.GirarPosiIzq(int.Parse(textBox1.Text));
            textBox5.Text = v1.Descargar();
            label5.Text = "Vecto girado en N posiciones";
        }

        private void ordenarElementosDeUnSegmentoDelVectorentreAYBPorLaTécnicaBurbujaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            v1.OrdEleSeg(int.Parse(textBox2.Text), int.Parse(textBox3.Text));
            textBox5.Text = v1.Descargar();
            label5.Text = "Elementos del Vector ordenados";
        }

        private void contarElementosDiferentesEntreElRangoAYBAplicandoCortesDeControlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox5.Text = string.Concat(v1.ContarElementosDiferentes(int.Parse(textBox2.Text), int.Parse(textBox3.Text)));           
            label5.Text = "Conteo de elementos diferentes";
        }

        private void segmentarElVectorEnPrimosYNoPrimosOrdenadosDescendentementeASuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            v1.SegPriNoPri(int.Parse(textBox2.Text), int.Parse(textBox3.Text));
            textBox5.Text = v1.Descargar();
        }

        private void segmentarElVectorEnCapicúasYNoCapicúasDondeEl1erSegmentoEsteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            v1.SegCapiNoCapi();
            textBox5.Text = v1.Descargar();
            label5.Text = "Vector segmentado en capicuas y no capicuas";
        }

        private void intercalarPrimosYNoPrimosOrdenadosYMientrasSeaPosibleEnElRangoAYBToolStripMenuItem_Click(object sender, EventArgs e)
        {
            v1.IntercalarPrimoNoPrimo(int.Parse(textBox2.Text), int.Parse(textBox3.Text));
            textBox5.Text = v1.Descargar();
            label5.Text = "Vector intercalado en primo y no primos ";
        }

        private void seleccionarPrimosYNoPrimosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            v1.PrimoyNoPrimo(v2,v3);
            textBox5.Text = v2.Descargar();
            textBox6.Text = v3.Descargar();
            label5.Text = "Son Números Primos";
            label7.Text = "No son Números Primos";

        }

        private void contarFibonacciToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox5.Text = string.Concat(v1.ContarFibos(int.Parse(textBox8.Text)));
            label6.Text = "Números Fibonacci en el Vector";
        }
    }
}
