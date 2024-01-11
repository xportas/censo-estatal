namespace Formularios
{
    partial class FrmMenu
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
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.provinciaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abandonadasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.borrarLocalidadesDeProvinciaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.altaDelocalidadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.provinciaToolStripMenuItem,
            this.consultasToolStripMenuItem,
            this.abandonadasToolStripMenuItem,
            this.borrarLocalidadesDeProvinciaToolStripMenuItem,
            this.altaDelocalidadToolStripMenuItem,
            this.toolStripMenuItem1,
            this.salirToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "&Archivo";
            // 
            // provinciaToolStripMenuItem
            // 
            this.provinciaToolStripMenuItem.Name = "provinciaToolStripMenuItem";
            this.provinciaToolStripMenuItem.Size = new System.Drawing.Size(239, 22);
            this.provinciaToolStripMenuItem.Text = "&Datos provincias";
            this.provinciaToolStripMenuItem.Click += new System.EventHandler(this.provinciaToolStripMenuItem_Click);
            // 
            // abandonadasToolStripMenuItem
            // 
            this.abandonadasToolStripMenuItem.Name = "abandonadasToolStripMenuItem";
            this.abandonadasToolStripMenuItem.Size = new System.Drawing.Size(239, 22);
            this.abandonadasToolStripMenuItem.Text = "&Abandonadas";
            this.abandonadasToolStripMenuItem.Click += new System.EventHandler(this.abandonadasToolStripMenuItem_Click);
            // 
            // borrarLocalidadesDeProvinciaToolStripMenuItem
            // 
            this.borrarLocalidadesDeProvinciaToolStripMenuItem.Name = "borrarLocalidadesDeProvinciaToolStripMenuItem";
            this.borrarLocalidadesDeProvinciaToolStripMenuItem.Size = new System.Drawing.Size(239, 22);
            this.borrarLocalidadesDeProvinciaToolStripMenuItem.Text = "Borrar Localidades de provincia";
            this.borrarLocalidadesDeProvinciaToolStripMenuItem.Click += new System.EventHandler(this.borrarLocalidadesDeProvinciaToolStripMenuItem_Click);
            // 
            // altaDelocalidadToolStripMenuItem
            // 
            this.altaDelocalidadToolStripMenuItem.Name = "altaDelocalidadToolStripMenuItem";
            this.altaDelocalidadToolStripMenuItem.Size = new System.Drawing.Size(239, 22);
            this.altaDelocalidadToolStripMenuItem.Text = "Alta de &localidad";
            this.altaDelocalidadToolStripMenuItem.Click += new System.EventHandler(this.altaDelocalidadToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(236, 6);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(239, 22);
            this.salirToolStripMenuItem.Text = "&Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // consultasToolStripMenuItem
            // 
            this.consultasToolStripMenuItem.Name = "consultasToolStripMenuItem";
            this.consultasToolStripMenuItem.Size = new System.Drawing.Size(239, 22);
            this.consultasToolStripMenuItem.Text = "&Consultas ";
            this.consultasToolStripMenuItem.Click += new System.EventHandler(this.consultasToolStripMenuItem_Click);
            // 
            // FrmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem provinciaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem abandonadasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem altaDelocalidadToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem borrarLocalidadesDeProvinciaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultasToolStripMenuItem;
    }
}