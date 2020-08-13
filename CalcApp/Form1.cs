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
    public partial class FormHomepage : Form
    {
        FormAbout formAbout;
        public FormHomepage()
        {
            InitializeComponent();
            formAbout = new FormAbout();
            formAbout.Visible = false;
        }

        private void ButtonAboutForm_Click(object sender, EventArgs e)
        {
            if (formAbout.Visible == true)
                formAbout.Visible = false;
            else
                formAbout.Visible = true;
        }
    }
}
