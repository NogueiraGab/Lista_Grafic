using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace _2015_3003_1BIM_ListaEncadeada
{
    public partial class Form1 : Form
    {
        private Lista lista;
        Random r = new Random();
        public List<int> bubble = new List<int>();
        DateTime inicial, final;
        List<float> tempos = new List<float>();
        List<int> elementos = new List<int>();
        List<int> nElem = new List<int>();
        int aux;

        public Form1()
        {
            InitializeComponent();
        }

        private void CarregarPrograma(object sender, EventArgs e)
        {
            lista = new Lista();

        }

        private void InicializarLista(object sender, EventArgs e)
        {
            Elemento elemento = new Elemento(lista.Count);
            lista.Adiciona(elemento);
        }

        private void AdicionaElemento(object sender, EventArgs e)
        {
            Random r = new Random();
            //r.Next(1,100) + (2 * DateTime.Now.Second)
            Elemento elemento = new Elemento(lista.Count);
            lista.Adiciona(elemento);
        }

        private void ExibirLista(object sender, EventArgs e)
        {
            lista.ImprimeLista();
        }

        void abc()
        {
            inicial = DateTime.Now;
            for (int i = 0; i < bubble.Count - 1; i++)
            {
                for (int j = i + 1; j < bubble.Count; j++)
                {
                    if (bubble[i] > bubble[j])
                    {
                        int temp = bubble[i];
                        bubble[i] = bubble[j];
                        bubble[j] = temp;
                    }
                }
            }

            final = DateTime.Now;
            

            //Console.WriteLine("TEMPO DO PROCESSAMENTO COM " + bubble.Count + " ELEMENTOS: " + (final - inicial));
            TimeSpan value = (final - inicial);
            elementos.Add(aux);

            tempos.Add((float)value.TotalSeconds);
            nElem.Add(elementos.Count);
            looping();

            for (int i = 0; i < elementos.Count; i++)
            {
                chart1.Series[0].Points.AddXY(nElem[i], tempos[i]);
                //Console.WriteLine("ELEMENTOS: " + elementos.Count + " TEMPOS: " + tempos[i]);
            }
        }

        private void Organizarbublle_Click(object sender, EventArgs e)
        {
            abc();
        }

        private void NElementos_Click(object sender, EventArgs e)
        {
             Random r = new Random();
            
            for (int i = 0; i < int.Parse(num.Text); i++)
            {
                aux = r.Next(1, int.Parse(num.Text));
                bubble.Add(aux);
            }
        }

        private void NElementos_Click()
        {
            Random r = new Random();

            for (int i = 0; i < int.Parse(num.Text); i++)
            {
                aux = r.Next(1, int.Parse(num.Text));
                bubble.Add(aux);
            }
        }

        private void BubbleSort_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 10; i++)
            {
                bubble[i] = r.Next(0, 10);
            }
        }

        private void BubbleSort_Click()
        {
            for (int i = 0; i < 10; i++)
            {
                bubble[i] = r.Next(0, 10);
            }
        }

        private void looping()
        {
            while (bubble.Count < 20000)
            {
                NElementos_Click();
                BubbleSort_Click();
                abc();
            }
        }
    }
}