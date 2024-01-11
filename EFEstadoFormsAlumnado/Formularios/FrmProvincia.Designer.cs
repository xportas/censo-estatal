
namespace Formularios
{
    partial class FrmProvincia
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblLocalidadMayor = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblHabitantesProvincia = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cboProvincias = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblMensaje = new System.Windows.Forms.Label();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.btnVolver = new System.Windows.Forms.Button();
            this.lblIdProvincia = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // lblLocalidadMayor
            // 
            this.lblLocalidadMayor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lblLocalidadMayor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblLocalidadMayor.Location = new System.Drawing.Point(781, 113);
            this.lblLocalidadMayor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLocalidadMayor.Name = "lblLocalidadMayor";
            this.lblLocalidadMayor.Size = new System.Drawing.Size(242, 27);
            this.lblLocalidadMayor.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(609, 124);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 16);
            this.label5.TabIndex = 11;
            this.label5.Text = "Mayor localidad";
            // 
            // lblHabitantesProvincia
            // 
            this.lblHabitantesProvincia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lblHabitantesProvincia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblHabitantesProvincia.Location = new System.Drawing.Point(440, 113);
            this.lblHabitantesProvincia.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHabitantesProvincia.Name = "lblHabitantesProvincia";
            this.lblHabitantesProvincia.Size = new System.Drawing.Size(82, 27);
            this.lblHabitantesProvincia.TabIndex = 10;
            this.lblHabitantesProvincia.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(325, 119);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 16);
            this.label1.TabIndex = 9;
            this.label1.Text = "Habitantes";
            // 
            // cboProvincias
            // 
            this.cboProvincias.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboProvincias.FormattingEnabled = true;
            this.cboProvincias.Location = new System.Drawing.Point(401, 47);
            this.cboProvincias.Margin = new System.Windows.Forms.Padding(4);
            this.cboProvincias.Name = "cboProvincias";
            this.cboProvincias.Size = new System.Drawing.Size(381, 24);
            this.cboProvincias.TabIndex = 0;
            this.cboProvincias.SelectedIndexChanged += new System.EventHandler(this.cboProvincias_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(267, 50);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Provincias";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(60, 119);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Id provincia";
            // 
            // lblMensaje
            // 
            this.lblMensaje.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblMensaje.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblMensaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMensaje.Location = new System.Drawing.Point(147, 186);
            this.lblMensaje.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMensaje.Name = "lblMensaje";
            this.lblMensaje.Size = new System.Drawing.Size(911, 30);
            this.lblMensaje.TabIndex = 32;
            this.lblMensaje.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgv
            // 
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(240, 239);
            this.dgv.Margin = new System.Windows.Forms.Padding(4);
            this.dgv.Name = "dgv";
            this.dgv.RowHeadersWidth = 51;
            this.dgv.Size = new System.Drawing.Size(663, 462);
            this.dgv.TabIndex = 15;
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(487, 726);
            this.btnVolver.Margin = new System.Windows.Forms.Padding(4);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(144, 38);
            this.btnVolver.TabIndex = 33;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // lblIdProvincia
            // 
            this.lblIdProvincia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lblIdProvincia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblIdProvincia.Location = new System.Drawing.Point(196, 113);
            this.lblIdProvincia.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIdProvincia.Name = "lblIdProvincia";
            this.lblIdProvincia.Size = new System.Drawing.Size(82, 27);
            this.lblIdProvincia.TabIndex = 34;
            this.lblIdProvincia.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // FrmProvincia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1113, 795);
            this.Controls.Add(this.lblIdProvincia);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.lblMensaje);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblLocalidadMayor);
            this.Controls.Add(this.cboProvincias);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblHabitantesProvincia);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmProvincia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Datos de provincias";
            this.Load += new System.EventHandler(this.FrmProvincia_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cboProvincias;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblMensaje;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Label lblHabitantesProvincia;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblLocalidadMayor;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Label lblIdProvincia;
    }
}

