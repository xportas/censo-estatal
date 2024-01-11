namespace Formularios
{
    partial class FrmAbandonadas
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
            this.lblMensaje = new System.Windows.Forms.Label();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.lblNombreProvincia = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtIdProv = new System.Windows.Forms.TextBox();
            this.btnBuscarLocalidadesPorIdProvincia = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMensaje
            // 
            this.lblMensaje.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblMensaje.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblMensaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMensaje.Location = new System.Drawing.Point(275, 146);
            this.lblMensaje.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMensaje.Name = "lblMensaje";
            this.lblMensaje.Size = new System.Drawing.Size(911, 27);
            this.lblMensaje.TabIndex = 34;
            this.lblMensaje.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgv
            // 
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(225, 219);
            this.dgv.Margin = new System.Windows.Forms.Padding(4);
            this.dgv.Name = "dgv";
            this.dgv.RowHeadersWidth = 51;
            this.dgv.Size = new System.Drawing.Size(961, 393);
            this.dgv.TabIndex = 33;
            // 
            // lblNombreProvincia
            // 
            this.lblNombreProvincia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lblNombreProvincia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblNombreProvincia.Location = new System.Drawing.Point(831, 74);
            this.lblNombreProvincia.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombreProvincia.Name = "lblNombreProvincia";
            this.lblNombreProvincia.Size = new System.Drawing.Size(317, 27);
            this.lblNombreProvincia.TabIndex = 30;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(665, 85);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(114, 16);
            this.label6.TabIndex = 29;
            this.label6.Text = "Nombre provincia";
            // 
            // txtIdProv
            // 
            this.txtIdProv.Location = new System.Drawing.Point(509, 81);
            this.txtIdProv.Margin = new System.Windows.Forms.Padding(4);
            this.txtIdProv.Name = "txtIdProv";
            this.txtIdProv.Size = new System.Drawing.Size(76, 22);
            this.txtIdProv.TabIndex = 28;
            // 
            // btnBuscarLocalidadesPorIdProvincia
            // 
            this.btnBuscarLocalidadesPorIdProvincia.Location = new System.Drawing.Point(93, 62);
            this.btnBuscarLocalidadesPorIdProvincia.Margin = new System.Windows.Forms.Padding(4);
            this.btnBuscarLocalidadesPorIdProvincia.Name = "btnBuscarLocalidadesPorIdProvincia";
            this.btnBuscarLocalidadesPorIdProvincia.Size = new System.Drawing.Size(353, 63);
            this.btnBuscarLocalidadesPorIdProvincia.TabIndex = 6;
            this.btnBuscarLocalidadesPorIdProvincia.Text = "Localidades abandonadas de provincia (por Id) >> En blanco para todo el estado";
            this.btnBuscarLocalidadesPorIdProvincia.UseVisualStyleBackColor = true;
            this.btnBuscarLocalidadesPorIdProvincia.Click += new System.EventHandler(this.btnBuscarLocalidadesPorIdProvincia_Click);
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(608, 661);
            this.btnVolver.Margin = new System.Windows.Forms.Padding(4);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(144, 47);
            this.btnVolver.TabIndex = 42;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // FrmAbandonadas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1404, 746);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.lblMensaje);
            this.Controls.Add(this.btnBuscarLocalidadesPorIdProvincia);
            this.Controls.Add(this.lblNombreProvincia);
            this.Controls.Add(this.txtIdProv);
            this.Controls.Add(this.label6);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmAbandonadas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Localidades abandonadas de provincia seleccionada (sin habitantes)";
            this.Load += new System.EventHandler(this.FrmAbandonadas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblNombreProvincia;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtIdProv;
        private System.Windows.Forms.Button btnBuscarLocalidadesPorIdProvincia;
        private System.Windows.Forms.Label lblMensaje;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Button btnVolver;
    }
}