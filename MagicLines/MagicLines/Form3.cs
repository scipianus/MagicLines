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

namespace MagicLines
{
    public partial class Form3 : Form
    {
        List<Persoana> L;

        public Form3()
        {
            InitializeComponent();
            L = new List<Persoana>();
            CitesteScoruri();
            Sorteaza();
            AfiseazaScoruri();
        }

        /// <summary>
        /// Citeste fisierul cu scorurile salvate
        /// </summary>
        private void CitesteScoruri()
        {
            if (!File.Exists("highscore.dbs"))
            {
                File.Create("highscore.dbs");
                StreamWriter fout = new StreamWriter("highscore.dbs");
                fout.WriteLine();
                fout.Close();
            }
            StreamReader fin = new StreamReader("highscore.dbs");
            string line, nume;
            int scor, i, ns;
            while((line = fin.ReadLine()) != null)
            {
                ns = line.Length;
                i = 0;
                nume = "";
                while(line[i] != 32)
                {
                    nume += line[i];
                    i++;
                }
                i++;
                scor = 0;
                while(i < ns)
                {
                    scor = scor * 10 + line[i] - '0';
                    i++;
                }
                L.Add(new Persoana(scor, nume));
            }
            fin.Close();
        }

        /// <summary>
        /// Sorteaza scorurile dupa punctaj si dupa nume
        /// </summary>
        private void Sorteaza()
        {
            int i, n = L.Count;
            bool modif = true;
            while (modif)
            {
                modif = false;
                for (i = 0; i + 1 < n; ++i)
                {
                    if(L[i].scor < L[i +1].scor || (L[i].scor == L[i + 1].scor && L[i].nume.CompareTo(L[i+1].nume) > 0))
                    {
                        Persoana aux = L[i + 1];
                        L[i + 1] = L[i];
                        L[i] = aux;
                        modif = true;
                    }
                }
            }
        }

        /// <summary>
        /// Afiseaza primele 30 de scoruri
        /// </summary>
        private void AfiseazaScoruri()
        {
            int i, n;
            if (L.Count > 30)
                n = 30;
            else
                n = L.Count;
            for (i = 0; i < n; ++i)
            {
                ListViewItem item = new ListViewItem((i+1).ToString());
                item.SubItems.Add(L[i].nume);
                item.SubItems.Add(L[i].scor.ToString());
                listView1.Items.Add(item);
            }
        }
    }
}
