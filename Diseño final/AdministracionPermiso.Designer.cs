namespace ProyectoDiseñoSoft
{
    partial class AdministracionPermiso
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
            this.dgvUsuarios = new System.Windows.Forms.DataGridView();
            this.dgvPermisos = new System.Windows.Forms.DataGridView();
            this.labelUsuarios = new System.Windows.Forms.Label();
            this.labelPermisos = new System.Windows.Forms.Label();
            this.bttAgregarPermiso = new System.Windows.Forms.Button();
            this.bttEditarPermiso = new System.Windows.Forms.Button();
            this.bttEliminarPermiso = new System.Windows.Forms.Button();
            this.linkAtras = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPermisos)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvUsuarios
            // 
            this.dgvUsuarios.AllowUserToAddRows = false;
            this.dgvUsuarios.AllowUserToDeleteRows = false;
            this.dgvUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsuarios.Location = new System.Drawing.Point(20, 67);
            this.dgvUsuarios.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.dgvUsuarios.Name = "dgvUsuarios";
            this.dgvUsuarios.ReadOnly = true;
            this.dgvUsuarios.RowHeadersWidth = 51;
            this.dgvUsuarios.Size = new System.Drawing.Size(667, 385);
            this.dgvUsuarios.TabIndex = 0;
            // 
            // dgvPermisos
            // 
            this.dgvPermisos.AllowUserToAddRows = false;
            this.dgvPermisos.AllowUserToDeleteRows = false;
            this.dgvPermisos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPermisos.Location = new System.Drawing.Point(743, 67);
            this.dgvPermisos.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.dgvPermisos.Name = "dgvPermisos";
            this.dgvPermisos.ReadOnly = true;
            this.dgvPermisos.RowHeadersWidth = 51;
            this.dgvPermisos.Size = new System.Drawing.Size(667, 385);
            this.dgvPermisos.TabIndex = 1;
            // 
            // labelUsuarios
            // 
            this.labelUsuarios.AutoSize = true;
            this.labelUsuarios.Location = new System.Drawing.Point(293, 26);
            this.labelUsuarios.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelUsuarios.Name = "labelUsuarios";
            this.labelUsuarios.Size = new System.Drawing.Size(80, 25);
            this.labelUsuarios.TabIndex = 2;
            this.labelUsuarios.Text = "Usuarios";
            // 
            // labelPermisos
            // 
            this.labelPermisos.AutoSize = true;
            this.labelPermisos.Location = new System.Drawing.Point(1042, 26);
            this.labelPermisos.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelPermisos.Name = "labelPermisos";
            this.labelPermisos.Size = new System.Drawing.Size(83, 25);
            this.labelPermisos.TabIndex = 3;
            this.labelPermisos.Text = "Permisos";
            // 
            // bttAgregarPermiso
            // 
            this.bttAgregarPermiso.Location = new System.Drawing.Point(20, 463);
            this.bttAgregarPermiso.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.bttAgregarPermiso.Name = "bttAgregarPermiso";
            this.bttAgregarPermiso.Size = new System.Drawing.Size(167, 44);
            this.bttAgregarPermiso.TabIndex = 4;
            this.bttAgregarPermiso.Text = "Agregar Permiso";
            this.bttAgregarPermiso.UseVisualStyleBackColor = true;
            // 
            // bttEditarPermiso
            // 
            this.bttEditarPermiso.Location = new System.Drawing.Point(197, 463);
            this.bttEditarPermiso.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.bttEditarPermiso.Name = "bttEditarPermiso";
            this.bttEditarPermiso.Size = new System.Drawing.Size(167, 44);
            this.bttEditarPermiso.TabIndex = 5;
            this.bttEditarPermiso.Text = "Editar Permiso";
            this.bttEditarPermiso.UseVisualStyleBackColor = true;
            // 
            // bttEliminarPermiso
            // 
            this.bttEliminarPermiso.Location = new System.Drawing.Point(373, 463);
            this.bttEliminarPermiso.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.bttEliminarPermiso.Name = "bttEliminarPermiso";
            this.bttEliminarPermiso.Size = new System.Drawing.Size(167, 44);
            this.bttEliminarPermiso.TabIndex = 6;
            this.bttEliminarPermiso.Text = "Eliminar Permiso";
            this.bttEliminarPermiso.UseVisualStyleBackColor = true;
            // 
            // linkAtras
            // 
            this.linkAtras.AutoSize = true;
            this.linkAtras.Location = new System.Drawing.Point(1357, 497);
            this.linkAtras.Name = "linkAtras";
            this.linkAtras.Size = new System.Drawing.Size(53, 25);
            this.linkAtras.TabIndex = 7;
            this.linkAtras.TabStop = true;
            this.linkAtras.Text = "Atras";
            // 
            // AdministracionPermiso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1430, 531);
            this.Controls.Add(this.linkAtras);
            this.Controls.Add(this.bttEliminarPermiso);
            this.Controls.Add(this.bttEditarPermiso);
            this.Controls.Add(this.bttAgregarPermiso);
            this.Controls.Add(this.labelPermisos);
            this.Controls.Add(this.labelUsuarios);
            this.Controls.Add(this.dgvPermisos);
            this.Controls.Add(this.dgvUsuarios);
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "AdministracionPermiso";
            this.Text = "Administración de Permisos";
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPermisos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.DataGridView dgvUsuarios;
        private System.Windows.Forms.DataGridView dgvPermisos;
        private System.Windows.Forms.Label labelUsuarios;
        private System.Windows.Forms.Label labelPermisos;
        private System.Windows.Forms.Button bttAgregarPermiso;
        private System.Windows.Forms.Button bttEditarPermiso;
        private System.Windows.Forms.Button bttEliminarPermiso;

        #endregion

        private LinkLabel linkAtras;
    }
}