
namespace Biblioteca
{
    partial class GestionarLibrosForm
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
            buttonAgregarLibro = new Button();
            label2 = new Label();
            textBoxTitulo = new TextBox();
            textBoxAutor = new TextBox();
            label3 = new Label();
            textBoxPublicacion = new TextBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            textBoxUbicacion = new TextBox();
            label7 = new Label();
            textBoxTamano = new TextBox();
            label8 = new Label();
            label9 = new Label();
            textBoxFormato = new TextBox();
            label10 = new Label();
            buttonModificar = new Button();
            buttonEliminar = new Button();
            radioFisico = new RadioButton();
            radioElectronico = new RadioButton();
            buttonMenu = new Button();
            listBoxLibros = new ListBox();
            SuspendLayout();
            // 
            // buttonAgregarLibro
            // 
            buttonAgregarLibro.Location = new Point(68, 385);
            buttonAgregarLibro.Name = "buttonAgregarLibro";
            buttonAgregarLibro.Size = new Size(139, 29);
            buttonAgregarLibro.TabIndex = 0;
            buttonAgregarLibro.Text = "Agregar Libro";
            buttonAgregarLibro.UseVisualStyleBackColor = true;
            buttonAgregarLibro.Click += buttonAgregarLibro_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(68, 50);
            label2.Name = "label2";
            label2.Size = new Size(47, 20);
            label2.TabIndex = 2;
            label2.Text = "Título";
            // 
            // textBoxTitulo
            // 
            textBoxTitulo.Location = new Point(121, 47);
            textBoxTitulo.Name = "textBoxTitulo";
            textBoxTitulo.Size = new Size(308, 27);
            textBoxTitulo.TabIndex = 3;
            // 
            // textBoxAutor
            // 
            textBoxAutor.Location = new Point(121, 80);
            textBoxAutor.Name = "textBoxAutor";
            textBoxAutor.Size = new Size(308, 27);
            textBoxAutor.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(68, 83);
            label3.Name = "label3";
            label3.Size = new Size(46, 20);
            label3.TabIndex = 4;
            label3.Text = "Autor";
            // 
            // textBoxPublicacion
            // 
            textBoxPublicacion.Location = new Point(262, 113);
            textBoxPublicacion.Name = "textBoxPublicacion";
            textBoxPublicacion.Size = new Size(167, 27);
            textBoxPublicacion.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(68, 116);
            label4.Name = "label4";
            label4.Size = new Size(116, 20);
            label4.TabIndex = 6;
            label4.Text = "Año Publicación";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(67, 157);
            label5.Name = "label5";
            label5.Size = new Size(39, 20);
            label5.TabIndex = 8;
            label5.Text = "Tipo";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(447, 51);
            label6.Name = "label6";
            label6.Size = new Size(126, 20);
            label6.TabIndex = 10;
            label6.Text = "Ubicación (Físico)";
            label6.Click += label6_Click;
            // 
            // textBoxUbicacion
            // 
            textBoxUbicacion.Location = new Point(634, 51);
            textBoxUbicacion.Name = "textBoxUbicacion";
            textBoxUbicacion.Size = new Size(174, 27);
            textBoxUbicacion.TabIndex = 11;
            textBoxUbicacion.TextChanged += textBoxUbicacion_TextChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = SystemColors.Control;
            label7.Location = new Point(545, 26);
            label7.Name = "label7";
            label7.Size = new Size(142, 20);
            label7.TabIndex = 12;
            label7.Text = "*Solo Libros Físicos*";
            label7.Click += label7_Click;
            // 
            // textBoxTamano
            // 
            textBoxTamano.Location = new Point(641, 116);
            textBoxTamano.Name = "textBoxTamano";
            textBoxTamano.Size = new Size(167, 27);
            textBoxTamano.TabIndex = 14;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(447, 116);
            label8.Name = "label8";
            label8.Size = new Size(140, 20);
            label8.TabIndex = 13;
            label8.Text = "Tamaño del Archivo";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(545, 89);
            label9.Name = "label9";
            label9.Size = new Size(158, 20);
            label9.TabIndex = 15;
            label9.Text = "*Solo Libros Digitales*";
            // 
            // textBoxFormato
            // 
            textBoxFormato.Location = new Point(641, 149);
            textBoxFormato.Name = "textBoxFormato";
            textBoxFormato.Size = new Size(167, 27);
            textBoxFormato.TabIndex = 17;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(447, 149);
            label10.Name = "label10";
            label10.Size = new Size(144, 20);
            label10.TabIndex = 16;
            label10.Text = "Formato del Archivo";
            // 
            // buttonModificar
            // 
            buttonModificar.Location = new Point(213, 385);
            buttonModificar.Name = "buttonModificar";
            buttonModificar.Size = new Size(139, 29);
            buttonModificar.TabIndex = 18;
            buttonModificar.Text = "Modificar Libro";
            buttonModificar.UseVisualStyleBackColor = true;
            // 
            // buttonEliminar
            // 
            buttonEliminar.Location = new Point(358, 385);
            buttonEliminar.Name = "buttonEliminar";
            buttonEliminar.Size = new Size(139, 29);
            buttonEliminar.TabIndex = 19;
            buttonEliminar.Text = "Eliminar Libro";
            buttonEliminar.UseVisualStyleBackColor = true;
            // 
            // radioFisico
            // 
            radioFisico.AutoSize = true;
            radioFisico.Location = new Point(166, 157);
            radioFisico.Name = "radioFisico";
            radioFisico.Size = new Size(67, 24);
            radioFisico.TabIndex = 20;
            radioFisico.TabStop = true;
            radioFisico.Text = "Fisico";
            radioFisico.UseVisualStyleBackColor = true;
            // 
            // radioElectronico
            // 
            radioElectronico.AutoSize = true;
            radioElectronico.Location = new Point(272, 157);
            radioElectronico.Name = "radioElectronico";
            radioElectronico.Size = new Size(104, 24);
            radioElectronico.TabIndex = 21;
            radioElectronico.TabStop = true;
            radioElectronico.Text = "Electronico";
            radioElectronico.UseVisualStyleBackColor = true;
            // 
            // buttonMenu
            // 
            buttonMenu.Location = new Point(645, 385);
            buttonMenu.Name = "buttonMenu";
            buttonMenu.Size = new Size(163, 98);
            buttonMenu.TabIndex = 22;
            buttonMenu.Text = "Regresar al Menú";
            buttonMenu.UseVisualStyleBackColor = true;
            // 
            // listBoxLibros
            // 
            listBoxLibros.FormattingEnabled = true;
            listBoxLibros.Location = new Point(68, 206);
            listBoxLibros.Name = "listBoxLibros";
            listBoxLibros.Size = new Size(740, 164);
            listBoxLibros.TabIndex = 24;
            // 
            // GestionarLibrosForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(860, 511);
            Controls.Add(listBoxLibros);
            Controls.Add(buttonMenu);
            Controls.Add(radioElectronico);
            Controls.Add(radioFisico);
            Controls.Add(buttonEliminar);
            Controls.Add(buttonModificar);
            Controls.Add(textBoxFormato);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(textBoxTamano);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(textBoxUbicacion);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(textBoxPublicacion);
            Controls.Add(label4);
            Controls.Add(textBoxAutor);
            Controls.Add(label3);
            Controls.Add(textBoxTitulo);
            Controls.Add(label2);
            Controls.Add(buttonAgregarLibro);
            Name = "GestionarLibrosForm";
            Text = "GestionarLibrosForm";
            Load += GestionarLibrosForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private Button buttonAgregarLibro;
        private Label label1;
        private Label label2;
        private TextBox textBoxTitulo;
        private TextBox textBoxAutor;
        private Label label3;
        private TextBox textBoxPublicacion;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox textBoxUbicacion;
        private Label label7;
        private TextBox textBoxTamano;
        private Label label8;
        private Label label9;
        private TextBox textBoxFormato;
        private Label label10;
        private Button buttonModificar;
        private Button buttonEliminar;
        private RadioButton radioFisico;
        private RadioButton radioElectronico;
        private Button buttonMenu;
        private ListBox listBoxLibros;
    }
}