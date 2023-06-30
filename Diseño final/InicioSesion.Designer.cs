namespace ProyectoDiseñoSoft
{
    partial class InicioSesion
    {
        private System.ComponentModel.IContainer components = null;

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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelUsuario = new System.Windows.Forms.Label();
            this.labelcontrasena = new System.Windows.Forms.Label();
            this.tbUsuario = new System.Windows.Forms.TextBox();
            this.tbContrasena = new System.Windows.Forms.TextBox();
            this.botonLogin = new System.Windows.Forms.Button();
            this.linkCrear = new System.Windows.Forms.LinkLabel();
            this.linkAdministrador = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // labelUsuario
            // 
            this.labelUsuario.AutoSize = true;
            this.labelUsuario.Location = new System.Drawing.Point(61, 33);
            this.labelUsuario.Name = "labelUsuario";
            this.labelUsuario.Size = new System.Drawing.Size(76, 25);
            this.labelUsuario.TabIndex = 0;
            this.labelUsuario.Text = "Usuario:";
            // 
            // labelcontrasena
            // 
            this.labelcontrasena.AutoSize = true;
            this.labelcontrasena.Location = new System.Drawing.Point(50, 87);
            this.labelcontrasena.Name = "labelcontrasena";
            this.labelcontrasena.Size = new System.Drawing.Size(105, 25);
            this.labelcontrasena.TabIndex = 1;
            this.labelcontrasena.Text = "Contraseña:";
            // 
            // tbUsuario
            // 
            this.tbUsuario.Location = new System.Drawing.Point(238, 30);
            this.tbUsuario.Name = "tbUsuario";
            this.tbUsuario.Size = new System.Drawing.Size(238, 31);
            this.tbUsuario.TabIndex = 2;
            // 
            // tbContrasena
            // 
            this.tbContrasena.Location = new System.Drawing.Point(238, 87);
            this.tbContrasena.Name = "tbContrasena";
            this.tbContrasena.PasswordChar = '*';
            this.tbContrasena.Size = new System.Drawing.Size(238, 31);
            this.tbContrasena.TabIndex = 3;
            // 
            // botonLogin
            // 
            this.botonLogin.Location = new System.Drawing.Point(220, 183);
            this.botonLogin.Name = "botonLogin";
            this.botonLogin.Size = new System.Drawing.Size(153, 37);
            this.botonLogin.TabIndex = 4;
            this.botonLogin.Text = "Iniciar sesión";
            // 
            // linkCrear
            // 
            this.linkCrear.AutoSize = true;
            this.linkCrear.Location = new System.Drawing.Point(27, 280);
            this.linkCrear.Name = "linkCrear";
            this.linkCrear.Size = new System.Drawing.Size(110, 25);
            this.linkCrear.TabIndex = 5;
            this.linkCrear.TabStop = true;
            this.linkCrear.Text = "Crear cuenta";
            // 
            // linkAdministrador
            // 
            this.linkAdministrador.AutoSize = true;
            this.linkAdministrador.Location = new System.Drawing.Point(376, 280);
            this.linkAdministrador.Name = "linkAdministrador";
            this.linkAdministrador.Size = new System.Drawing.Size(242, 25);
            this.linkAdministrador.TabIndex = 6;
            this.linkAdministrador.TabStop = true;
            this.linkAdministrador.Text = "Acceder como administrador";
            // 
            // InicioSesion
            // 
            this.ClientSize = new System.Drawing.Size(630, 332);
            this.Controls.Add(this.labelUsuario);
            this.Controls.Add(this.labelcontrasena);
            this.Controls.Add(this.tbUsuario);
            this.Controls.Add(this.tbContrasena);
            this.Controls.Add(this.botonLogin);
            this.Controls.Add(this.linkCrear);
            this.Controls.Add(this.linkAdministrador);
            this.Name = "InicioSesion";
            this.Text = "Inicio de Sesión";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Label labelUsuario;
        private System.Windows.Forms.Label labelcontrasena;
        private System.Windows.Forms.TextBox tbUsuario;
        private System.Windows.Forms.TextBox tbContrasena;
        private System.Windows.Forms.Button botonLogin;
        private System.Windows.Forms.LinkLabel linkCrear;
        private System.Windows.Forms.LinkLabel linkAdministrador;
    }

    #endregion
}
