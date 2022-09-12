using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Unindo_Forms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnMostar_Click(object sender, EventArgs e)
        {
           
           Global.Nome=txtNome.Text;

            MessageBox.Show(Global.Nome);
        }

        private void btnIr_Click(object sender, EventArgs e)
        {
            Form2 form= new Form2();
            form.Show();

        }
    }
}
