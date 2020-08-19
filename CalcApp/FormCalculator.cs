using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalcApp
{
    public partial class FormCalculator : Form
    {
        public FormCalculator()
        {
            InitializeComponent();
        }

        private void buttonAdunare_Click(object sender, EventArgs e)
        {
            decimal termen1 = numericUpDownTermen1.Value;
            decimal termen2 = numericUpDownTermen2.Value;

            if ((termen1 >= 0 && termen1 < 1000001) && (termen2 >= 0 && termen2 < 1000001)) { 
            decimal rezultat = termen1 + termen2;
            textBoxRezultat.Text = rezultat.ToString();
            }
            else
            {
                string message = "Valorile acceptate sunt de la 0 la 1000000";
                string title = "Valori acceptate";
                MessageBox.Show(message, title);
            }

        }

        private void buttonScadere_Click(object sender, EventArgs e)
        {
            decimal termen1 = numericUpDownTermen1.Value;
            decimal termen2 = numericUpDownTermen2.Value;

            decimal rezultat = termen1 - termen2;
            textBoxRezultat.Text = rezultat.ToString();
        }

        private void buttonInmultire_Click(object sender, EventArgs e)
        {
            decimal termen1 = numericUpDownTermen1.Value;
            decimal termen2 = numericUpDownTermen2.Value;

            decimal rezultat = termen1 * termen2;
            textBoxRezultat.Text = rezultat.ToString();
        }

        private void buttonImpartire_Click(object sender, EventArgs e)
        {
            decimal termen1 = numericUpDownTermen1.Value;
            decimal termen2 = numericUpDownTermen2.Value;

            decimal rezultat = termen1 / termen2;
            textBoxRezultat.Text = rezultat.ToString();
        }
    }
}
