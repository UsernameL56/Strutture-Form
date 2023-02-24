using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Strutture
{
    public partial class Form1 : Form
    {
        public struct Prodotto
        {
            public string nome;
            public float prezzo;
        }
        public Prodotto [] P;
        public int indice;
        public Form1()
        {
            InitializeComponent();
            P = new Prodotto[100];
            indice = 0;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Salva_Click(object sender, EventArgs e)
        {
            P[indice].nome = Nome.Text;
            P[indice].prezzo = float.Parse(Prezzo.Text);
            indice++;
            visualizza(P);
            
        }
        private void Cancellazione_Click(object sender, EventArgs e)
        {
            Cancella(P, ref indice, Nome.Text);
            visualizza(P);
        }



        public string Pstring(Prodotto P)
        {
            return "nome: "+ P.nome+"   Prezzo: "+P.prezzo.ToString();
        }
        public void visualizza(Prodotto[] PP)
        {
            listView1.Items.Clear();
            for(int i = 0; i < indice; i++)  
            listView1.Items.Add(Pstring(P[i]));
        }
        public void Cancella(Prodotto[] P, ref int indice, string input)
        {
            //ciclo per ricercare la parola nell'array
            for (int z = 0; z < P.Length; z++)
            {
                //se la parola viene trovata allora
                if (P[z].nome == input)
                {
                    //ciclo per sovrascrivere le parole per cancellare quella inserita
                    while (z < indice)
                    {
                        P[z] = P[z + 1];
                        z++;
                    }
                    //decremento dell'indice data la parola cancellata
                    indice = indice - 1;
                    //uscita dal ciclo 
                    break;
                }
            }
        }
        public void Ricerca(Prodotto P)
        {

        }
    }
}
