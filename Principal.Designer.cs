namespace _EDD_Practica1_201114567
{
    partial class Principal
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.usuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cargarJSONToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reporteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.matrizToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pilaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnoperar = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btncargar = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usuarioToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(284, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // usuarioToolStripMenuItem
            // 
            this.usuarioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cargarJSONToolStripMenuItem,
            this.reporteToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.usuarioToolStripMenuItem.Name = "usuarioToolStripMenuItem";
            this.usuarioToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.usuarioToolStripMenuItem.Text = "Usuario";
            // 
            // cargarJSONToolStripMenuItem
            // 
            this.cargarJSONToolStripMenuItem.Name = "cargarJSONToolStripMenuItem";
            this.cargarJSONToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.cargarJSONToolStripMenuItem.Text = "Cargar JSON";
            // 
            // reporteToolStripMenuItem
            // 
            this.reporteToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.matrizToolStripMenuItem,
            this.pilaToolStripMenuItem,
            this.colaToolStripMenuItem});
            this.reporteToolStripMenuItem.Name = "reporteToolStripMenuItem";
            this.reporteToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.reporteToolStripMenuItem.Text = "Reporte";
            // 
            // matrizToolStripMenuItem
            // 
            this.matrizToolStripMenuItem.Name = "matrizToolStripMenuItem";
            this.matrizToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.matrizToolStripMenuItem.Text = "Matriz";
            // 
            // pilaToolStripMenuItem
            // 
            this.pilaToolStripMenuItem.Name = "pilaToolStripMenuItem";
            this.pilaToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.pilaToolStripMenuItem.Text = "Pila";
            // 
            // colaToolStripMenuItem
            // 
            this.colaToolStripMenuItem.Name = "colaToolStripMenuItem";
            this.colaToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.colaToolStripMenuItem.Text = "Cola";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.salirToolStripMenuItem.Text = "Logout";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // btnoperar
            // 
            this.btnoperar.Location = new System.Drawing.Point(197, 226);
            this.btnoperar.Name = "btnoperar";
            this.btnoperar.Size = new System.Drawing.Size(75, 23);
            this.btnoperar.TabIndex = 1;
            this.btnoperar.Text = "Operar";
            this.btnoperar.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(13, 27);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(259, 175);
            this.textBox1.TabIndex = 2;
            // 
            // btncargar
            // 
            this.btncargar.Location = new System.Drawing.Point(13, 226);
            this.btncargar.Name = "btncargar";
            this.btncargar.Size = new System.Drawing.Size(75, 23);
            this.btncargar.TabIndex = 3;
            this.btncargar.Text = "Cargar";
            this.btncargar.UseVisualStyleBackColor = true;
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btncargar);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnoperar);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Principal";
            this.Text = "Principal";
            this.Load += new System.EventHandler(this.Principal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem usuarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cargarJSONToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reporteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem matrizToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pilaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem colaToolStripMenuItem;
        private System.Windows.Forms.Button btnoperar;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btncargar;
    }
}