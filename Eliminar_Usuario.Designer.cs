namespace _EDD_Practica1_201114567
{
    partial class Eliminar_Usuario
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
            this.btnsalir = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtbox_pass = new System.Windows.Forms.TextBox();
            this.txtbox_user = new System.Windows.Forms.TextBox();
            this.btn_eliminar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnsalir
            // 
            this.btnsalir.Location = new System.Drawing.Point(152, 176);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(75, 23);
            this.btnsalir.TabIndex = 17;
            this.btnsalir.Text = "Salir";
            this.btnsalir.UseVisualStyleBackColor = true;
            this.btnsalir.Click += new System.EventHandler(this.btnsalir_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(57, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Contraseña:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Usuario:";
            // 
            // txtbox_pass
            // 
            this.txtbox_pass.Location = new System.Drawing.Point(127, 113);
            this.txtbox_pass.Name = "txtbox_pass";
            this.txtbox_pass.Size = new System.Drawing.Size(100, 20);
            this.txtbox_pass.TabIndex = 14;
            // 
            // txtbox_user
            // 
            this.txtbox_user.Location = new System.Drawing.Point(127, 61);
            this.txtbox_user.Name = "txtbox_user";
            this.txtbox_user.Size = new System.Drawing.Size(100, 20);
            this.txtbox_user.TabIndex = 13;
            // 
            // btn_eliminar
            // 
            this.btn_eliminar.Location = new System.Drawing.Point(60, 176);
            this.btn_eliminar.Name = "btn_eliminar";
            this.btn_eliminar.Size = new System.Drawing.Size(75, 23);
            this.btn_eliminar.TabIndex = 12;
            this.btn_eliminar.Text = "Eliminar";
            this.btn_eliminar.UseVisualStyleBackColor = true;
            this.btn_eliminar.Click += new System.EventHandler(this.btn_eliminar_Click);
            // 
            // Eliminar_Usuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btnsalir);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtbox_pass);
            this.Controls.Add(this.txtbox_user);
            this.Controls.Add(this.btn_eliminar);
            this.Name = "Eliminar_Usuario";
            this.Text = "Eliminar_Usuario";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnsalir;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtbox_pass;
        private System.Windows.Forms.TextBox txtbox_user;
        private System.Windows.Forms.Button btn_eliminar;
    }
}