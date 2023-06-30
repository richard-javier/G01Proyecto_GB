namespace ProyectoDiseñoSoft
{
    partial class Administrador
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
            this.botonAdminPermisos = new System.Windows.Forms.Button();
            this.linkCerrarSesion = new System.Windows.Forms.LinkLabel();
            this.botonLibro = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // botonAdminPermisos
            // 
            this.botonAdminPermisos.Location = new System.Drawing.Point(142, 222);
            this.botonAdminPermisos.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.botonAdminPermisos.Name = "botonAdminPermisos";
            this.botonAdminPermisos.Size = new System.Drawing.Size(250, 58);
            this.botonAdminPermisos.TabIndex = 1;
            this.botonAdminPermisos.Text = "Administrador de Permisos";
            this.botonAdminPermisos.UseVisualStyleBackColor = true;
            // 
            // linkCerrarSesion
            // 
            this.linkCerrarSesion.AutoSize = true;
            this.linkCerrarSesion.Location = new System.Drawing.Point(25, 368);
            this.linkCerrarSesion.Name = "linkCerrarSesion";
            this.linkCerrarSesion.Size = new System.Drawing.Size(116, 25);
            this.linkCerrarSesion.TabIndex = 6;
            this.linkCerrarSesion.TabStop = true;
            this.linkCerrarSesion.Text = "Cerrar Sesión";
            // 
            // botonLibro
            // 
            this.botonLibro.Location = new System.Drawing.Point(142, 106);
            this.botonLibro.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.botonLibro.Name = "botonLibro";
            this.botonLibro.Size = new System.Drawing.Size(250, 58);
            this.botonLibro.TabIndex = 7;
            this.botonLibro.Text = "Administrador de Libros";
            this.botonLibro.UseVisualStyleBackColor = true;
            // 
            // Administrador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(546, 418);
            this.Controls.Add(this.botonLibro);
            this.Controls.Add(this.linkCerrarSesion);
            this.Controls.Add(this.botonAdminPermisos);
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "Administrador";
            this.Text = "Pantalla de Administrador";
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        private System.Windows.Forms.Button botonAdminPermisos;

        #endregion

        private LinkLabel linkCerrarSesion;
        private Button botonLibro;
    }
}