namespace Biblioteca
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            buttonLibros = new Button();
            buttonMiembros = new Button();
            buttonPrestamos = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // buttonLibros
            // 
            buttonLibros.Location = new Point(78, 82);
            buttonLibros.Name = "buttonLibros";
            buttonLibros.Size = new Size(174, 43);
            buttonLibros.TabIndex = 0;
            buttonLibros.Text = "Gestionar Libros";
            buttonLibros.UseVisualStyleBackColor = true;
            buttonLibros.Click += buttonLibros_Click;
            // 
            // buttonMiembros
            // 
            buttonMiembros.Location = new Point(78, 131);
            buttonMiembros.Name = "buttonMiembros";
            buttonMiembros.Size = new Size(174, 43);
            buttonMiembros.TabIndex = 1;
            buttonMiembros.Text = "Gestionar Miembros";
            buttonMiembros.UseVisualStyleBackColor = true;
            buttonMiembros.Click += buttonMiembros_Click;
            // 
            // buttonPrestamos
            // 
            buttonPrestamos.Location = new Point(78, 180);
            buttonPrestamos.Name = "buttonPrestamos";
            buttonPrestamos.Size = new Size(174, 43);
            buttonPrestamos.TabIndex = 2;
            buttonPrestamos.Text = "Gestionar Préstamos";
            buttonPrestamos.UseVisualStyleBackColor = true;
            buttonPrestamos.Click += buttonPrestamos_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(86, 40);
            label1.Name = "label1";
            label1.Size = new Size(160, 20);
            label1.TabIndex = 3;
            label1.Text = "Seleccione una Opción";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(337, 266);
            Controls.Add(label1);
            Controls.Add(buttonPrestamos);
            Controls.Add(buttonMiembros);
            Controls.Add(buttonLibros);
            Name = "MainForm";
            Text = "Biblioteca";
            Load += MainForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonLibros;
        private Button buttonMiembros;
        private Button buttonPrestamos;
        private Label label1;
    }
}
