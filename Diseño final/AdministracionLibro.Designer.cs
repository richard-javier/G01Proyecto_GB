namespace ProyectoDiseñoSoft
{
    partial class AdministracionLibro
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
            this.dtpAquiscion = new System.Windows.Forms.DateTimePicker();
            this.cbDisponibilidad = new System.Windows.Forms.ComboBox();
            this.dtpPublicacion = new System.Windows.Forms.DateTimePicker();
            this.labelAquisicion = new System.Windows.Forms.Label();
            this.labelPublicacion = new System.Windows.Forms.Label();
            this.tbDecripcion = new System.Windows.Forms.TextBox();
            this.labelDisponibilidad = new System.Windows.Forms.Label();
            this.labelDescripcion = new System.Windows.Forms.Label();
            this.tbGenero = new System.Windows.Forms.TextBox();
            this.tbISBN = new System.Windows.Forms.TextBox();
            this.tbPagina = new System.Windows.Forms.TextBox();
            this.tbEditor = new System.Windows.Forms.TextBox();
            this.labelIsbn = new System.Windows.Forms.Label();
            this.labelPagina = new System.Windows.Forms.Label();
            this.labelEditor = new System.Windows.Forms.Label();
            this.linkAtras = new System.Windows.Forms.LinkLabel();
            this.botonEliminarLibro = new System.Windows.Forms.Button();
            this.botonEditarLibro = new System.Windows.Forms.Button();
            this.botonCrearLibro = new System.Windows.Forms.Button();
            this.tbAutor = new System.Windows.Forms.TextBox();
            this.tbTitulo = new System.Windows.Forms.TextBox();
            this.labelGenero = new System.Windows.Forms.Label();
            this.labelAutor = new System.Windows.Forms.Label();
            this.labelTitulo = new System.Windows.Forms.Label();
            this.dgvLibro = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLibro)).BeginInit();
            this.SuspendLayout();
            // 
            // dtpAquiscion
            // 
            this.dtpAquiscion.Location = new System.Drawing.Point(666, 642);
            this.dtpAquiscion.Name = "dtpAquiscion";
            this.dtpAquiscion.Size = new System.Drawing.Size(331, 31);
            this.dtpAquiscion.TabIndex = 77;
            // 
            // cbDisponibilidad
            // 
            this.cbDisponibilidad.AutoCompleteCustomSource.AddRange(new string[] {
            "Si",
            "No"});
            this.cbDisponibilidad.FormattingEnabled = true;
            this.cbDisponibilidad.Location = new System.Drawing.Point(735, 587);
            this.cbDisponibilidad.Name = "cbDisponibilidad";
            this.cbDisponibilidad.Size = new System.Drawing.Size(182, 33);
            this.cbDisponibilidad.TabIndex = 76;
            // 
            // dtpPublicacion
            // 
            this.dtpPublicacion.Location = new System.Drawing.Point(151, 642);
            this.dtpPublicacion.Name = "dtpPublicacion";
            this.dtpPublicacion.Size = new System.Drawing.Size(331, 31);
            this.dtpPublicacion.TabIndex = 75;
            // 
            // labelAquisicion
            // 
            this.labelAquisicion.AutoSize = true;
            this.labelAquisicion.Location = new System.Drawing.Point(535, 647);
            this.labelAquisicion.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelAquisicion.Name = "labelAquisicion";
            this.labelAquisicion.Size = new System.Drawing.Size(109, 25);
            this.labelAquisicion.TabIndex = 74;
            this.labelAquisicion.Text = "Adquisición:";
            // 
            // labelPublicacion
            // 
            this.labelPublicacion.AutoSize = true;
            this.labelPublicacion.Location = new System.Drawing.Point(32, 647);
            this.labelPublicacion.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelPublicacion.Name = "labelPublicacion";
            this.labelPublicacion.Size = new System.Drawing.Size(105, 25);
            this.labelPublicacion.TabIndex = 73;
            this.labelPublicacion.Text = "Publicación:";
            // 
            // tbDecripcion
            // 
            this.tbDecripcion.Location = new System.Drawing.Point(151, 590);
            this.tbDecripcion.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.tbDecripcion.Name = "tbDecripcion";
            this.tbDecripcion.Size = new System.Drawing.Size(331, 31);
            this.tbDecripcion.TabIndex = 72;
            // 
            // labelDisponibilidad
            // 
            this.labelDisponibilidad.AutoSize = true;
            this.labelDisponibilidad.Location = new System.Drawing.Point(525, 590);
            this.labelDisponibilidad.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelDisponibilidad.Name = "labelDisponibilidad";
            this.labelDisponibilidad.Size = new System.Drawing.Size(131, 25);
            this.labelDisponibilidad.TabIndex = 71;
            this.labelDisponibilidad.Text = "Disponibilidad:";
            // 
            // labelDescripcion
            // 
            this.labelDescripcion.AutoSize = true;
            this.labelDescripcion.Location = new System.Drawing.Point(32, 593);
            this.labelDescripcion.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelDescripcion.Name = "labelDescripcion";
            this.labelDescripcion.Size = new System.Drawing.Size(108, 25);
            this.labelDescripcion.TabIndex = 70;
            this.labelDescripcion.Text = "Descripción:";
            // 
            // tbGenero
            // 
            this.tbGenero.Location = new System.Drawing.Point(151, 539);
            this.tbGenero.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.tbGenero.Name = "tbGenero";
            this.tbGenero.Size = new System.Drawing.Size(331, 31);
            this.tbGenero.TabIndex = 69;
            // 
            // tbISBN
            // 
            this.tbISBN.Location = new System.Drawing.Point(666, 533);
            this.tbISBN.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.tbISBN.Name = "tbISBN";
            this.tbISBN.Size = new System.Drawing.Size(331, 31);
            this.tbISBN.TabIndex = 68;
            // 
            // tbPagina
            // 
            this.tbPagina.Location = new System.Drawing.Point(666, 483);
            this.tbPagina.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.tbPagina.Name = "tbPagina";
            this.tbPagina.Size = new System.Drawing.Size(331, 31);
            this.tbPagina.TabIndex = 67;
            // 
            // tbEditor
            // 
            this.tbEditor.Location = new System.Drawing.Point(666, 429);
            this.tbEditor.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.tbEditor.Name = "tbEditor";
            this.tbEditor.Size = new System.Drawing.Size(331, 31);
            this.tbEditor.TabIndex = 66;
            // 
            // labelIsbn
            // 
            this.labelIsbn.AutoSize = true;
            this.labelIsbn.Location = new System.Drawing.Point(562, 539);
            this.labelIsbn.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelIsbn.Name = "labelIsbn";
            this.labelIsbn.Size = new System.Drawing.Size(54, 25);
            this.labelIsbn.TabIndex = 65;
            this.labelIsbn.Text = "ISBN:";
            // 
            // labelPagina
            // 
            this.labelPagina.AutoSize = true;
            this.labelPagina.Location = new System.Drawing.Point(553, 483);
            this.labelPagina.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelPagina.Name = "labelPagina";
            this.labelPagina.Size = new System.Drawing.Size(76, 25);
            this.labelPagina.TabIndex = 64;
            this.labelPagina.Text = "Páginas:";
            // 
            // labelEditor
            // 
            this.labelEditor.AutoSize = true;
            this.labelEditor.Location = new System.Drawing.Point(553, 434);
            this.labelEditor.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelEditor.Name = "labelEditor";
            this.labelEditor.Size = new System.Drawing.Size(63, 25);
            this.labelEditor.TabIndex = 63;
            this.labelEditor.Text = "Editor:";
            // 
            // linkAtras
            // 
            this.linkAtras.AutoSize = true;
            this.linkAtras.Location = new System.Drawing.Point(1154, 647);
            this.linkAtras.Name = "linkAtras";
            this.linkAtras.Size = new System.Drawing.Size(53, 25);
            this.linkAtras.TabIndex = 62;
            this.linkAtras.TabStop = true;
            this.linkAtras.Text = "Atras";
            // 
            // botonEliminarLibro
            // 
            this.botonEliminarLibro.Location = new System.Drawing.Point(1048, 327);
            this.botonEliminarLibro.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.botonEliminarLibro.Name = "botonEliminarLibro";
            this.botonEliminarLibro.Size = new System.Drawing.Size(167, 44);
            this.botonEliminarLibro.TabIndex = 61;
            this.botonEliminarLibro.Text = "Eliminar Libro";
            this.botonEliminarLibro.UseVisualStyleBackColor = true;
            // 
            // botonEditarLibro
            // 
            this.botonEditarLibro.Location = new System.Drawing.Point(1048, 195);
            this.botonEditarLibro.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.botonEditarLibro.Name = "botonEditarLibro";
            this.botonEditarLibro.Size = new System.Drawing.Size(167, 44);
            this.botonEditarLibro.TabIndex = 60;
            this.botonEditarLibro.Text = "Editar Libro";
            this.botonEditarLibro.UseVisualStyleBackColor = true;
            // 
            // botonCrearLibro
            // 
            this.botonCrearLibro.Location = new System.Drawing.Point(1048, 75);
            this.botonCrearLibro.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.botonCrearLibro.Name = "botonCrearLibro";
            this.botonCrearLibro.Size = new System.Drawing.Size(167, 44);
            this.botonCrearLibro.TabIndex = 59;
            this.botonCrearLibro.Text = "Crear Libro";
            this.botonCrearLibro.UseVisualStyleBackColor = true;
            // 
            // tbAutor
            // 
            this.tbAutor.Location = new System.Drawing.Point(151, 483);
            this.tbAutor.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.tbAutor.Name = "tbAutor";
            this.tbAutor.Size = new System.Drawing.Size(331, 31);
            this.tbAutor.TabIndex = 58;
            // 
            // tbTitulo
            // 
            this.tbTitulo.Location = new System.Drawing.Point(151, 429);
            this.tbTitulo.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.tbTitulo.Name = "tbTitulo";
            this.tbTitulo.Size = new System.Drawing.Size(331, 31);
            this.tbTitulo.TabIndex = 57;
            // 
            // labelGenero
            // 
            this.labelGenero.AutoSize = true;
            this.labelGenero.Location = new System.Drawing.Point(47, 539);
            this.labelGenero.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelGenero.Name = "labelGenero";
            this.labelGenero.Size = new System.Drawing.Size(73, 25);
            this.labelGenero.TabIndex = 56;
            this.labelGenero.Text = "Género:";
            // 
            // labelAutor
            // 
            this.labelAutor.AutoSize = true;
            this.labelAutor.Location = new System.Drawing.Point(47, 486);
            this.labelAutor.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelAutor.Name = "labelAutor";
            this.labelAutor.Size = new System.Drawing.Size(61, 25);
            this.labelAutor.TabIndex = 55;
            this.labelAutor.Text = "Autor:";
            // 
            // labelTitulo
            // 
            this.labelTitulo.AutoSize = true;
            this.labelTitulo.Location = new System.Drawing.Point(47, 432);
            this.labelTitulo.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelTitulo.Name = "labelTitulo";
            this.labelTitulo.Size = new System.Drawing.Size(60, 25);
            this.labelTitulo.TabIndex = 54;
            this.labelTitulo.Text = "Título:";
            // 
            // dgvLibro
            // 
            this.dgvLibro.AllowUserToAddRows = false;
            this.dgvLibro.AllowUserToDeleteRows = false;
            this.dgvLibro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLibro.Location = new System.Drawing.Point(38, 15);
            this.dgvLibro.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.dgvLibro.Name = "dgvLibro";
            this.dgvLibro.ReadOnly = true;
            this.dgvLibro.RowHeadersWidth = 51;
            this.dgvLibro.Size = new System.Drawing.Size(1000, 385);
            this.dgvLibro.TabIndex = 53;
            // 
            // AdministracionLibro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1247, 689);
            this.Controls.Add(this.dtpAquiscion);
            this.Controls.Add(this.cbDisponibilidad);
            this.Controls.Add(this.dtpPublicacion);
            this.Controls.Add(this.labelAquisicion);
            this.Controls.Add(this.labelPublicacion);
            this.Controls.Add(this.tbDecripcion);
            this.Controls.Add(this.labelDisponibilidad);
            this.Controls.Add(this.labelDescripcion);
            this.Controls.Add(this.tbGenero);
            this.Controls.Add(this.tbISBN);
            this.Controls.Add(this.tbPagina);
            this.Controls.Add(this.tbEditor);
            this.Controls.Add(this.labelIsbn);
            this.Controls.Add(this.labelPagina);
            this.Controls.Add(this.labelEditor);
            this.Controls.Add(this.linkAtras);
            this.Controls.Add(this.botonEliminarLibro);
            this.Controls.Add(this.botonEditarLibro);
            this.Controls.Add(this.botonCrearLibro);
            this.Controls.Add(this.tbAutor);
            this.Controls.Add(this.tbTitulo);
            this.Controls.Add(this.labelGenero);
            this.Controls.Add(this.labelAutor);
            this.Controls.Add(this.labelTitulo);
            this.Controls.Add(this.dgvLibro);
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "AdministracionLibro";
            this.Text = "Administración de Usuarios";
            ((System.ComponentModel.ISupportInitialize)(this.dgvLibro)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DateTimePicker dtpAquiscion;
        private ComboBox cbDisponibilidad;
        private DateTimePicker dtpPublicacion;
        private Label labelAquisicion;
        private Label labelPublicacion;
        private TextBox tbDecripcion;
        private Label labelDisponibilidad;
        private Label labelDescripcion;
        private TextBox tbGenero;
        private TextBox tbISBN;
        private TextBox tbPagina;
        private TextBox tbEditor;
        private Label labelIsbn;
        private Label labelPagina;
        private Label labelEditor;
        private LinkLabel linkAtras;
        private Button botonEliminarLibro;
        private Button botonEditarLibro;
        private Button botonCrearLibro;
        private TextBox tbAutor;
        private TextBox tbTitulo;
        private Label labelGenero;
        private Label labelAutor;
        private Label labelTitulo;
        private DataGridView dgvLibro;
    }
}