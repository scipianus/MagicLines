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
    public partial class Form2 : Form
    {
        int scor;

        public Form2(int savedscore)
        {
            InitializeComponent();
            scor = savedscore;
        }

        /// <summary>
        /// Salveaza scorul curent in lista de scoruri
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonOk_Click(object sender, EventArgs e)
        {
            string text = "";
            if (File.Exists("highscore.dbs"))
                text = System.IO.File.ReadAllText("highscore.dbs");
            text += textBoxNume.Text + " " + scor;
            StreamWriter fout = new StreamWriter("highscore.dbs");
            fout.Write(text + "\n");
            fout.Close();
            this.Close();
        }
    }
}
