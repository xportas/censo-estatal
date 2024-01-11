namespace Formularios
{
    partial class FrmAltaLocalidad
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
            this.label2 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.btnAñadirLocalidad = new System.Windows.Forms.Button();
            this.txtNumHab = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtIdLocalidad = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtIdProv = new System.Windows.Forms.TextBox();
            this.txtLocalidad = new System.Windows.Forms.TextBox();
            this.btnVolver = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(435, 215);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(657, 24);
            this.label2.TabIndex = 40;
            this.label2.Text = "El identificador habrá que pasarlo a mayúsculas para que funcione todo bien, ya q" +
    "ue así está en la bd";
            // 
            // Label1
            // 
            this.Label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Label1.ForeColor = System.Drawing.Color.Red;
            this.Label1.Location = new System.Drawing.Point(435, 156);
            this.Label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(291, 22);
            this.Label1.TabIndex = 39;
            this.Label1.Text = "Si dejas habitantes vacío se guardará null";
            // 
            // btnBorrar
            // 
            this.btnBorrar.Location = new System.Drawing.Point(671, 334);
            this.btnBorrar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(135, 49);
            this.btnBorrar.TabIndex = 35;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // btnAñadirLocalidad
            // 
            this.btnAñadirLocalidad.Location = new System.Drawing.Point(405, 334);
            this.btnAñadirLocalidad.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAñadirLocalidad.Name = "btnAñadirLocalidad";
            this.btnAñadirLocalidad.Size = new System.Drawing.Size(135, 49);
            this.btnAñadirLocalidad.TabIndex = 34;
            this.btnAñadirLocalidad.Text = "Añadir";
            this.btnAñadirLocalidad.UseVisualStyleBackColor = true;
            this.btnAñadirLocalidad.Click += new System.EventHandler(this.btnAñadirLocalidad_Click);
            // 
            // txtNumHab
            // 
            this.txtNumHab.Location = new System.Drawing.Point(247, 154);
            this.txtNumHab.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNumHab.Name = "txtNumHab";
            this.txtNumHab.Size = new System.Drawing.Size(76, 22);
            this.txtNumHab.TabIndex = 33;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(431, 100);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(67, 16);
            this.label10.TabIndex = 32;
            this.label10.Text = "Localidad";
            // 
            // txtIdLocalidad
            // 
            this.txtIdLocalidad.Location = new System.Drawing.Point(247, 91);
            this.txtIdLocalidad.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtIdLocalidad.Name = "txtIdLocalidad";
            this.txtIdLocalidad.Size = new System.Drawing.Size(76, 22);
            this.txtIdLocalidad.TabIndex = 31;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(128, 100);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(81, 16);
            this.label9.TabIndex = 30;
            this.label9.Text = "Id Localidad";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(132, 219);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 16);
            this.label8.TabIndex = 29;
            this.label8.Text = "Id provincia";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(128, 154);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 16);
            this.label7.TabIndex = 28;
            this.label7.Text = "Habitantes";
            // 
            // txtIdProv
            // 
            this.txtIdProv.Location = new System.Drawing.Point(247, 215);
            this.txtIdProv.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtIdProv.Name = "txtIdProv";
            this.txtIdProv.Size = new System.Drawing.Size(76, 22);
            this.txtIdProv.TabIndex = 27;
            // 
            // txtLocalidad
            // 
            this.txtLocalidad.Location = new System.Drawing.Point(557, 96);
            this.txtLocalidad.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtLocalidad.Name = "txtLocalidad";
            this.txtLocalidad.Size = new System.Drawing.Size(403, 22);
            this.txtLocalidad.TabIndex = 26;
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(557, 444);
            this.btnVolver.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(144, 47);
            this.btnVolver.TabIndex = 41;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // FrmAltaLocalidad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1288, 554);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.btnAñadirLocalidad);
            this.Controls.Add(this.txtNumHab);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtLocalidad);
            this.Controls.Add(this.txtIdLocalidad);
            this.Controls.Add(this.txtIdProv);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmAltaLocalidad";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Altas de localidades";
            this.Load += new System.EventHandler(this.FrmAltaLocalidad_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Button btnAñadirLocalidad;
        private System.Windows.Forms.TextBox txtNumHab;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtIdLocalidad;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtIdProv;
        private System.Windows.Forms.TextBox txtLocalidad;
        private System.Windows.Forms.Label Label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnVolver;
    }
}