namespace A2U3_NumeroControlED3B
{
    partial class Form1
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
            txtNumCliente = new TextBox();
            txtNombre = new TextBox();
            txtOpracion = new TextBox();
            dtgDatos = new DataGridView();
            btnEncolar = new Button();
            btnDesencolar = new Button();
            ((System.ComponentModel.ISupportInitialize)dtgDatos).BeginInit();
            SuspendLayout();
            // 
            // txtNumCliente
            // 
            txtNumCliente.Location = new Point(146, 171);
            txtNumCliente.Name = "txtNumCliente";
            txtNumCliente.PlaceholderText = "Numero Cliente";
            txtNumCliente.Size = new Size(150, 31);
            txtNumCliente.TabIndex = 1;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(155, 252);
            txtNombre.Name = "txtNombre";
            txtNombre.PlaceholderText = "Nombre";
            txtNombre.Size = new Size(150, 31);
            txtNombre.TabIndex = 2;
            // 
            // txtOpracion
            // 
            txtOpracion.Location = new Point(155, 322);
            txtOpracion.Name = "txtOpracion";
            txtOpracion.PlaceholderText = "Operacion";
            txtOpracion.Size = new Size(150, 31);
            txtOpracion.TabIndex = 3;
            // 
            // dtgDatos
            // 
            dtgDatos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgDatos.Location = new Point(383, 86);
            dtgDatos.Name = "dtgDatos";
            dtgDatos.RowHeadersWidth = 62;
            dtgDatos.Size = new Size(469, 297);
            dtgDatos.TabIndex = 5;
            // 
            // btnEncolar
            // 
            btnEncolar.Location = new Point(153, 407);
            btnEncolar.Name = "btnEncolar";
            btnEncolar.Size = new Size(112, 34);
            btnEncolar.TabIndex = 6;
            btnEncolar.Text = "Encolar";
            btnEncolar.UseVisualStyleBackColor = true;
            btnEncolar.Click += btnEncolar_Click;
            // 
            // btnDesencolar
            // 
            btnDesencolar.Location = new Point(165, 470);
            btnDesencolar.Name = "btnDesencolar";
            btnDesencolar.Size = new Size(112, 34);
            btnDesencolar.TabIndex = 7;
            btnDesencolar.Text = "Desencolar";
            btnDesencolar.UseVisualStyleBackColor = true;
            btnDesencolar.Click += btnDesencolar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(954, 564);
            Controls.Add(btnDesencolar);
            Controls.Add(btnEncolar);
            Controls.Add(dtgDatos);
            Controls.Add(txtOpracion);
            Controls.Add(txtNombre);
            Controls.Add(txtNumCliente);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dtgDatos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtNumCliente;
        private TextBox txtNombre;
        private TextBox txtOpracion;
        private DataGridView dtgDatos;
        private Button btnEncolar;
        private Button btnDesencolar;
    }
}
