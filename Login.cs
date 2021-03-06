﻿using System;
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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btningresar_Click(object sender, EventArgs e)
        {

            if (!string.IsNullOrEmpty(txtbox_user.Text) && !string.IsNullOrEmpty(txtbox_pass.Text))
            {
                //main.lista_usuarios.insertarNodo(txtbox_user.Text, txtbox_pass.Text);
                //main.lista_usuarios.imprimirPrimeroUltimo();

                this.Hide();

                Principal prin = new Principal();

                prin.Show();
            }
            else 
            {
                MessageBox.Show("Debe completar la informacion");
            }
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            this.Hide();

            Inicio ini  = new Inicio();

            ini.Show();            
        }
    }
}
