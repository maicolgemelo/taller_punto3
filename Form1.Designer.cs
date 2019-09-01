namespace taller_punto3
{
    partial class Form1
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
            this.btncalculo = new System.Windows.Forms.Button();
            this.lbltitulo = new System.Windows.Forms.Label();
            this.lblradio = new System.Windows.Forms.Label();
            this.lblarea = new System.Windows.Forms.Label();
            this.txtradio = new System.Windows.Forms.TextBox();
            this.txtarea = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btncalculo
            // 
            this.btncalculo.Location = new System.Drawing.Point(349, 270);
            this.btncalculo.Name = "btncalculo";
            this.btncalculo.Size = new System.Drawing.Size(75, 23);
            this.btncalculo.TabIndex = 0;
            this.btncalculo.Text = "Calculo";
            this.btncalculo.UseVisualStyleBackColor = true;
            this.btncalculo.Click += new System.EventHandler(this.Btncalculo_Click);
            // 
            // lbltitulo
            // 
            this.lbltitulo.AutoSize = true;
            this.lbltitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltitulo.Location = new System.Drawing.Point(382, 23);
            this.lbltitulo.Name = "lbltitulo";
            this.lbltitulo.Size = new System.Drawing.Size(145, 24);
            this.lbltitulo.TabIndex = 1;
            this.lbltitulo.Text = "Area del Circulo";
            // 
            // lblradio
            // 
            this.lblradio.AutoSize = true;
            this.lblradio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblradio.Location = new System.Drawing.Point(218, 86);
            this.lblradio.Name = "lblradio";
            this.lblradio.Size = new System.Drawing.Size(137, 20);
            this.lblradio.TabIndex = 2;
            this.lblradio.Text = "Ingrese el Radio : ";
            this.lblradio.Click += new System.EventHandler(this.Lblradio_Click);
            // 
            // lblarea
            // 
            this.lblarea.AutoSize = true;
            this.lblarea.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblarea.Location = new System.Drawing.Point(264, 180);
            this.lblarea.Name = "lblarea";
            this.lblarea.Size = new System.Drawing.Size(55, 20);
            this.lblarea.TabIndex = 3;
            this.lblarea.Text = "Area : ";
            // 
            // txtradio
            // 
            this.txtradio.Location = new System.Drawing.Point(361, 86);
            this.txtradio.Name = "txtradio";
            this.txtradio.Size = new System.Drawing.Size(100, 20);
            this.txtradio.TabIndex = 4;
            // 
            // txtarea
            // 
            this.txtarea.Location = new System.Drawing.Point(361, 180);
            this.txtarea.Name = "txtarea";
            this.txtarea.Size = new System.Drawing.Size(100, 20);
            this.txtarea.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtarea);
            this.Controls.Add(this.txtradio);
            this.Controls.Add(this.lblarea);
            this.Controls.Add(this.lblradio);
            this.Controls.Add(this.lbltitulo);
            this.Controls.Add(this.btncalculo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btncalculo;
        private System.Windows.Forms.Label lbltitulo;
        private System.Windows.Forms.Label lblradio;
        private System.Windows.Forms.Label lblarea;
        private System.Windows.Forms.TextBox txtradio;
        private System.Windows.Forms.TextBox txtarea;
    }
}

