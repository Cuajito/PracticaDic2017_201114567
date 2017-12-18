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
    public partial class Eliminar_Usuario : Form
    {
        public Eliminar_Usuario()
        {
            InitializeComponent();
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            this.Hide();

            Inicio ini = new Inicio();

            ini.Show(); 
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtbox_user.Text) && !string.IsNullOrEmpty(txtbox_pass.Text))
            {
                if (main.lista_usuarios.eliminarNodo(txtbox_user.Text, txtbox_pass.Text))
                {
                    main.lista_usuarios.imprimirPrimeroUltimo();

                    this.Hide();

                    Inicio ini = new Inicio();

                    ini.Show();
                }
                else 
                {
                    MessageBox.Show("Usuario no encontrado o datos incorrectos");
                }   
            }
            else
            {
                MessageBox.Show("Debe completar la informacion");
            }
        }
    }
}
