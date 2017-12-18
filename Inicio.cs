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
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            this.Hide();

            Login log = new Login();

            log.Show();
        }

        private void btnregistrar_Click(object sender, EventArgs e)
        {
            this.Hide();

            Registrar_Usuario registro = new Registrar_Usuario();

            registro.Show();
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_ver_Click(object sender, EventArgs e)
        {
            
            string texto = main.lista_usuarios.imprimirPrimeroUltimo();

            ventana_imagen img = new ventana_imagen(texto);
            
            img.Show();
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            this.Hide();

            Eliminar_Usuario elimi = new Eliminar_Usuario();

            elimi.Show();
        }

        
    }
}
