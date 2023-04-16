namespace TP_VarYSec_Ejercicio2
{
    partial class fViaje
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
            this.bCalcularTiempo = new System.Windows.Forms.Button();
            this.bCerrar = new System.Windows.Forms.Button();
            this.lDestino = new System.Windows.Forms.Label();
            this.lDistancia = new System.Windows.Forms.Label();
            this.lVelocidad = new System.Windows.Forms.Label();
            this.tDestino = new System.Windows.Forms.TextBox();
            this.tDistancia = new System.Windows.Forms.TextBox();
            this.tVelocidad = new System.Windows.Forms.TextBox();
            this.lKilometros = new System.Windows.Forms.Label();
            this.lKmPorH = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bCalcularTiempo
            // 
            this.bCalcularTiempo.Location = new System.Drawing.Point(245, 194);
            this.bCalcularTiempo.Name = "bCalcularTiempo";
            this.bCalcularTiempo.Size = new System.Drawing.Size(107, 23);
            this.bCalcularTiempo.TabIndex = 0;
            this.bCalcularTiempo.Text = "Calcular el tiempo";
            this.bCalcularTiempo.UseVisualStyleBackColor = true;
            this.bCalcularTiempo.Click += new System.EventHandler(this.bCalcularTiempo_Click);
            // 
            // bCerrar
            // 
            this.bCerrar.Location = new System.Drawing.Point(382, 194);
            this.bCerrar.Name = "bCerrar";
            this.bCerrar.Size = new System.Drawing.Size(75, 23);
            this.bCerrar.TabIndex = 1;
            this.bCerrar.Text = "Cerrar";
            this.bCerrar.UseVisualStyleBackColor = true;
            this.bCerrar.Click += new System.EventHandler(this.bCerrar_Click);
            // 
            // lDestino
            // 
            this.lDestino.AutoSize = true;
            this.lDestino.Location = new System.Drawing.Point(54, 34);
            this.lDestino.Name = "lDestino";
            this.lDestino.Size = new System.Drawing.Size(46, 13);
            this.lDestino.TabIndex = 2;
            this.lDestino.Text = "Destino:";
            // 
            // lDistancia
            // 
            this.lDistancia.AutoSize = true;
            this.lDistancia.Location = new System.Drawing.Point(46, 61);
            this.lDistancia.Name = "lDistancia";
            this.lDistancia.Size = new System.Drawing.Size(54, 13);
            this.lDistancia.TabIndex = 3;
            this.lDistancia.Text = "Distancia:";
            // 
            // lVelocidad
            // 
            this.lVelocidad.AutoSize = true;
            this.lVelocidad.Location = new System.Drawing.Point(43, 88);
            this.lVelocidad.Name = "lVelocidad";
            this.lVelocidad.Size = new System.Drawing.Size(57, 13);
            this.lVelocidad.TabIndex = 4;
            this.lVelocidad.Text = "Velocidad:";
            // 
            // tDestino
            // 
            this.tDestino.Location = new System.Drawing.Point(107, 31);
            this.tDestino.Name = "tDestino";
            this.tDestino.Size = new System.Drawing.Size(182, 20);
            this.tDestino.TabIndex = 5;
            // 
            // tDistancia
            // 
            this.tDistancia.Location = new System.Drawing.Point(107, 58);
            this.tDistancia.Name = "tDistancia";
            this.tDistancia.Size = new System.Drawing.Size(100, 20);
            this.tDistancia.TabIndex = 6;
            // 
            // tVelocidad
            // 
            this.tVelocidad.Location = new System.Drawing.Point(107, 85);
            this.tVelocidad.Name = "tVelocidad";
            this.tVelocidad.Size = new System.Drawing.Size(100, 20);
            this.tVelocidad.TabIndex = 7;
            // 
            // lKilometros
            // 
            this.lKilometros.AutoSize = true;
            this.lKilometros.Location = new System.Drawing.Point(214, 61);
            this.lKilometros.Name = "lKilometros";
            this.lKilometros.Size = new System.Drawing.Size(54, 13);
            this.lKilometros.TabIndex = 8;
            this.lKilometros.Text = "kilómetros";
            // 
            // lKmPorH
            // 
            this.lKmPorH.AutoSize = true;
            this.lKmPorH.Location = new System.Drawing.Point(214, 88);
            this.lKmPorH.Name = "lKmPorH";
            this.lKmPorH.Size = new System.Drawing.Size(37, 13);
            this.lKmPorH.TabIndex = 9;
            this.lKmPorH.Text = "kms/h";
            // 
            // fViaje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 238);
            this.Controls.Add(this.lKmPorH);
            this.Controls.Add(this.lKilometros);
            this.Controls.Add(this.tVelocidad);
            this.Controls.Add(this.tDistancia);
            this.Controls.Add(this.tDestino);
            this.Controls.Add(this.lVelocidad);
            this.Controls.Add(this.lDistancia);
            this.Controls.Add(this.lDestino);
            this.Controls.Add(this.bCerrar);
            this.Controls.Add(this.bCalcularTiempo);
            this.Name = "fViaje";
            this.Text = "Viaje";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bCalcularTiempo;
        private System.Windows.Forms.Button bCerrar;
        private System.Windows.Forms.Label lDestino;
        private System.Windows.Forms.Label lDistancia;
        private System.Windows.Forms.Label lVelocidad;
        private System.Windows.Forms.TextBox tDestino;
        private System.Windows.Forms.TextBox tDistancia;
        private System.Windows.Forms.TextBox tVelocidad;
        private System.Windows.Forms.Label lKilometros;
        private System.Windows.Forms.Label lKmPorH;
    }
}

