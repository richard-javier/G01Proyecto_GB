namespace ProyectoDise
{
    partial class Prestamos_Automaticos
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
            label1 = new Label();
            txtNombreLibro = new Label();
            dtpFechaPrestamo = new Label();
            lstPrestamos = new Label();
            listBox1 = new ListBox();
            textNombreLibro = new TextBox();
            dateTimeFechaPrest = new DateTimePicker();
            btnEditar = new Button();
            btnAgregar = new Button();
            btnEliminar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(196, 20);
            label1.Name = "label1";
            label1.Size = new Size(238, 27);
            label1.TabIndex = 0;
            label1.Text = "Prestamos Automáticos";
            label1.Click += label1_Click;
            // 
            // txtNombreLibro
            // 
            txtNombreLibro.AutoSize = true;
            txtNombreLibro.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtNombreLibro.Location = new Point(40, 78);
            txtNombreLibro.Name = "txtNombreLibro";
            txtNombreLibro.Size = new Size(127, 19);
            txtNombreLibro.TabIndex = 1;
            txtNombreLibro.Text = "Nombre del Libro";
            // 
            // dtpFechaPrestamo
            // 
            dtpFechaPrestamo.AutoSize = true;
            dtpFechaPrestamo.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            dtpFechaPrestamo.Location = new Point(40, 131);
            dtpFechaPrestamo.Name = "dtpFechaPrestamo";
            dtpFechaPrestamo.Size = new Size(140, 19);
            dtpFechaPrestamo.TabIndex = 2;
            dtpFechaPrestamo.Text = "Fecha del Préstamo";
            // 
            // lstPrestamos
            // 
            lstPrestamos.AutoSize = true;
            lstPrestamos.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lstPrestamos.Location = new Point(40, 187);
            lstPrestamos.Name = "lstPrestamos";
            lstPrestamos.Size = new Size(129, 19);
            lstPrestamos.TabIndex = 3;
            lstPrestamos.Text = "Lista de préstamo";
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(196, 187);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(303, 19);
            listBox1.TabIndex = 4;
            // 
            // textNombreLibro
            // 
            textNombreLibro.Location = new Point(196, 78);
            textNombreLibro.Name = "textNombreLibro";
            textNombreLibro.Size = new Size(303, 23);
            textNombreLibro.TabIndex = 5;
            // 
            // dateTimeFechaPrest
            // 
            dateTimeFechaPrest.Location = new Point(197, 131);
            dateTimeFechaPrest.Name = "dateTimeFechaPrest";
            dateTimeFechaPrest.Size = new Size(302, 23);
            dateTimeFechaPrest.TabIndex = 6;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(55, 280);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(75, 23);
            btnEditar.TabIndex = 7;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(233, 280);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(75, 23);
            btnAgregar.TabIndex = 8;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(415, 280);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(75, 23);
            btnEliminar.TabIndex = 9;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            // 
            // Prestamos_Automaticos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(524, 330);
            Controls.Add(btnEliminar);
            Controls.Add(btnAgregar);
            Controls.Add(btnEditar);
            Controls.Add(dateTimeFechaPrest);
            Controls.Add(textNombreLibro);
            Controls.Add(listBox1);
            Controls.Add(lstPrestamos);
            Controls.Add(dtpFechaPrestamo);
            Controls.Add(txtNombreLibro);
            Controls.Add(label1);
            Name = "Prestamos_Automaticos";
            Text = "Prestamos_Automaticos";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label txtNombreLibro;
        private Label dtpFechaPrestamo;
        private Label lstPrestamos;
        private ListBox listBox1;
        private TextBox textNombreLibro;
        private DateTimePicker dateTimeFechaPrest;
        private Button btnEditar;
        private Button btnAgregar;
        private Button btnEliminar;
    }
}