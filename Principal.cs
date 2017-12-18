using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _EDD_Practica1_201114567
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void Principal_Load(object sender, EventArgs e)
        {

        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //usuario_activo = 0;

            this.Hide();

            Inicio ini = new Inicio();

            ini.Show();
        }
    }
}
