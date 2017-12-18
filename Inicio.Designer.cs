namespace _EDD_Practica1_201114567
{
    partial class Inicio
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnlogin = new System.Windows.Forms.Button();
            this.btnregistrar = new System.Windows.Forms.Button();
            this.btnsalir = new System.Windows.Forms.Button();
            this.btn_eliminar = new System.Windows.Forms.Button();
            this.btn_ver = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnlogin
            // 
            this.btnlogin.Location = new System.Drawing.Point(12, 12);
            this.btnlogin.Name = "btnlogin";
            this.btnlogin.Size = new System.Drawing.Size(103, 61);
            this.btnlogin.TabIndex = 0;
            this.btnlogin.Text = "Login";
            this.btnlogin.UseVisualStyleBackColor = true;
            this.btnlogin.Click += new System.EventHandler(this.btnlogin_Click);
            // 
            // btnregistrar
            // 
            this.btnregistrar.Location = new System.Drawing.Point(12, 96);
            this.btnregistrar.Name = "btnregistrar";
            this.btnregistrar.Size = new System.Drawing.Size(103, 64);
            this.btnregistrar.TabIndex = 1;
            this.btnregistrar.Text = "Registrar Usuario";
            this.btnregistrar.UseVisualStyleBackColor = true;
            this.btnregistrar.Click += new System.EventHandler(this.btnregistrar_Click);
            // 
            // btnsalir
            // 
            this.btnsalir.Location = new System.Drawing.Point(90, 185);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(103, 64);
            this.btnsalir.TabIndex = 2;
            this.btnsalir.Text = "Salir";
            this.btnsalir.UseVisualStyleBackColor = true;
            this.btnsalir.Click += new System.EventHandler(this.btnsalir_Click);
            // 
            // btn_eliminar
            // 
            this.btn_eliminar.Location = new System.Drawing.Point(169, 96);
            this.btn_eliminar.Name = "btn_eliminar";
            this.btn_eliminar.Size = new System.Drawing.Size(103, 64);
            this.btn_eliminar.TabIndex = 4;
            this.btn_eliminar.Text = "Eliminar Usuario";
            this.btn_eliminar.UseVisualStyleBackColor = true;
            this.btn_eliminar.Click += new System.EventHandler(this.btn_eliminar_Click);
            // 
            // btn_ver
            // 
            this.btn_ver.Location = new System.Drawing.Point(169, 12);
            this.btn_ver.Name = "btn_ver";
            this.btn_ver.Size = new System.Drawing.Size(103, 61);
            this.btn_ver.TabIndex = 3;
            this.btn_ver.Text = "Ver Usuarios";
            this.btn_ver.UseVisualStyleBackColor = true;
            this.btn_ver.Click += new System.EventHandler(this.btn_ver_Click);
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btn_eliminar);
            this.Controls.Add(this.btn_ver);
            this.Controls.Add(this.btnsalir);
            this.Controls.Add(this.btnregistrar);
            this.Controls.Add(this.btnlogin);
            this.Name = "Inicio";
            this.Text = "Inicio";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnlogin;
        private System.Windows.Forms.Button btnregistrar;
        private System.Windows.Forms.Button btnsalir;
        private System.Windows.Forms.Button btn_eliminar;
        private System.Windows.Forms.Button btn_ver;

    }
}

