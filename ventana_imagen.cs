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
    public partial class ventana_imagen : Form
    {
        private string textoDOT = "";
        public ventana_imagen()
        {
            InitializeComponent();
        }

        public ventana_imagen (string textoDOT) : this()
    {
        this.textoDOT = textoDOT;
    }

        private void ventana_imagen_Load(object sender, EventArgs e)
        {
            //pictureBox1.Image = graficar.dibujarGrafo(textoDOT);
        }
    }
}
