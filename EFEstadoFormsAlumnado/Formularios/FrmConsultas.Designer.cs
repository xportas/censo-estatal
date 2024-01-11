namespace Formularios
{
    partial class FrmConsultas
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
            this.btnVolver = new System.Windows.Forms.Button();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.lblMensaje = new System.Windows.Forms.Label();
            this.btnLocalidadesHabitadasPequeñas = new System.Windows.Forms.Button();
            this.btnProvinciasPorHabitantes = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(575, 682);
            this.btnVolver.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(144, 38);
            this.btnVolver.TabIndex = 36;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // dgv
            // 
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(176, 188);
            this.dgv.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgv.Name = "dgv";
            this.dgv.RowHeadersWidth = 51;
            this.dgv.Size = new System.Drawing.Size(961, 462);
            this.dgv.TabIndex = 34;
            // 
            // lblMensaje
            // 
            this.lblMensaje.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblMensaje.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblMensaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMensaje.Location = new System.Drawing.Point(203, 133);
            this.lblMensaje.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMensaje.Name = "lblMensaje";
            this.lblMensaje.Size = new System.Drawing.Size(911, 30);
            this.lblMensaje.TabIndex = 35;
            this.lblMensaje.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnLocalidadesHabitadasPequeñas
            // 
            this.btnLocalidadesHabitadasPequeñas.Location = new System.Drawing.Point(264, 47);
            this.btnLocalidadesHabitadasPequeñas.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnLocalidadesHabitadasPequeñas.Name = "btnLocalidadesHabitadasPequeñas";
            this.btnLocalidadesHabitadasPequeñas.Size = new System.Drawing.Size(289, 70);
            this.btnLocalidadesHabitadasPequeñas.TabIndex = 37;
            this.btnLocalidadesHabitadasPequeñas.Text = "Localidades habitadas con menor nº habitantes";
            this.btnLocalidadesHabitadasPequeñas.UseVisualStyleBackColor = true;
            this.btnLocalidadesHabitadasPequeñas.Click += new System.EventHandler(this.btnLocalidadesHabitadasPequeñas_Click);
            // 
            // btnProvinciasPorHabitantes
            // 
            this.btnProvinciasPorHabitantes.Location = new System.Drawing.Point(685, 47);
            this.btnProvinciasPorHabitantes.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnProvinciasPorHabitantes.Name = "btnProvinciasPorHabitantes";
            this.btnProvinciasPorHabitantes.Size = new System.Drawing.Size(289, 70);
            this.btnProvinciasPorHabitantes.TabIndex = 38;
            this.btnProvinciasPorHabitantes.Text = "Provincias (ordenadas por habitantes)";
            this.btnProvinciasPorHabitantes.UseVisualStyleBackColor = true;
            this.btnProvinciasPorHabitantes.Click += new System.EventHandler(this.btnProvinciasPorHabitantes_Click);
            // 
            // FrmConsultas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1295, 747);
            this.Controls.Add(this.btnProvinciasPorHabitantes);
            this.Controls.Add(this.btnLocalidadesHabitadasPequeñas);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.lblMensaje);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmConsultas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consultas varias";
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Label lblMensaje;
        private System.Windows.Forms.Button btnLocalidadesHabitadasPequeñas;
        private System.Windows.Forms.Button btnProvinciasPorHabitantes;
    }
}