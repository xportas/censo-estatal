namespace Formularios
{
    partial class FrmBorrarLocalidades
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
            this.label13 = new System.Windows.Forms.Label();
            this.txtComienzaPor = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtIdProv = new System.Windows.Forms.TextBox();
            this.btnBorrarLocalidades = new System.Windows.Forms.Button();
            this.btnMostrarLocalidades = new System.Windows.Forms.Button();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.lblMensaje = new System.Windows.Forms.Label();
            this.btnVolver = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(533, 82);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(208, 16);
            this.label13.TabIndex = 34;
            this.label13.Text = "Localidades que comienzan por...";
            // 
            // txtComienzaPor
            // 
            this.txtComienzaPor.Location = new System.Drawing.Point(787, 79);
            this.txtComienzaPor.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtComienzaPor.Name = "txtComienzaPor";
            this.txtComienzaPor.Size = new System.Drawing.Size(152, 22);
            this.txtComienzaPor.TabIndex = 33;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(211, 79);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(76, 16);
            this.label12.TabIndex = 29;
            this.label12.Text = "Id provincia";
            // 
            // txtIdProv
            // 
            this.txtIdProv.Location = new System.Drawing.Point(344, 79);
            this.txtIdProv.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtIdProv.Name = "txtIdProv";
            this.txtIdProv.Size = new System.Drawing.Size(76, 22);
            this.txtIdProv.TabIndex = 28;
            // 
            // btnBorrarLocalidades
            // 
            this.btnBorrarLocalidades.Location = new System.Drawing.Point(581, 149);
            this.btnBorrarLocalidades.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBorrarLocalidades.Name = "btnBorrarLocalidades";
            this.btnBorrarLocalidades.Size = new System.Drawing.Size(153, 39);
            this.btnBorrarLocalidades.TabIndex = 6;
            this.btnBorrarLocalidades.Text = "Borrar";
            this.btnBorrarLocalidades.UseVisualStyleBackColor = true;
            this.btnBorrarLocalidades.Click += new System.EventHandler(this.btnBorrarLocalidades_Click);
            // 
            // btnMostrarLocalidades
            // 
            this.btnMostrarLocalidades.Location = new System.Drawing.Point(344, 149);
            this.btnMostrarLocalidades.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnMostrarLocalidades.Name = "btnMostrarLocalidades";
            this.btnMostrarLocalidades.Size = new System.Drawing.Size(153, 39);
            this.btnMostrarLocalidades.TabIndex = 35;
            this.btnMostrarLocalidades.Text = "Mostrar localidades ";
            this.btnMostrarLocalidades.UseVisualStyleBackColor = true;
            this.btnMostrarLocalidades.Click += new System.EventHandler(this.btnMostrarLocalidades_Click);
            // 
            // dgv
            // 
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(69, 310);
            this.dgv.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgv.Name = "dgv";
            this.dgv.RowHeadersWidth = 51;
            this.dgv.Size = new System.Drawing.Size(961, 170);
            this.dgv.TabIndex = 36;
            // 
            // lblMensaje
            // 
            this.lblMensaje.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblMensaje.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblMensaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMensaje.Location = new System.Drawing.Point(89, 231);
            this.lblMensaje.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMensaje.Name = "lblMensaje";
            this.lblMensaje.Size = new System.Drawing.Size(911, 44);
            this.lblMensaje.TabIndex = 37;
            this.lblMensaje.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(479, 519);
            this.btnVolver.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(144, 38);
            this.btnVolver.TabIndex = 38;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // FrmBorrarLocalidades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 586);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.lblMensaje);
            this.Controls.Add(this.btnMostrarLocalidades);
            this.Controls.Add(this.btnBorrarLocalidades);
            this.Controls.Add(this.txtComienzaPor);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtIdProv);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmBorrarLocalidades";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Borrar Localidades de provincia que empiezan por...";
            this.Load += new System.EventHandler(this.FrmBorrarLocalidades_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtComienzaPor;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtIdProv;
        private System.Windows.Forms.Button btnBorrarLocalidades;
        private System.Windows.Forms.Button btnMostrarLocalidades;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Label lblMensaje;
        private System.Windows.Forms.Button btnVolver;
    }
}