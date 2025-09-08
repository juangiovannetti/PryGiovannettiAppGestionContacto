namespace PryGiovannettiAppGestionContacto
{
    partial class frmInicio
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
            lblContacto = new Label();
            lblNumero = new Label();
            btnAgendar = new Button();
            btnCancelar = new Button();
            mtbNumero = new MaskedTextBox();
            lstResultado = new ListBox();
            txtContacto = new TextBox();
            lblCantidad = new Label();
            dtpFecha = new DateTimePicker();
            txtCantidad = new TextBox();
            lblFecha = new Label();
            SuspendLayout();
            // 
            // lblContacto
            // 
            lblContacto.AutoSize = true;
            lblContacto.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblContacto.ForeColor = SystemColors.ActiveCaptionText;
            lblContacto.Location = new Point(33, 33);
            lblContacto.Name = "lblContacto";
            lblContacto.Size = new Size(72, 21);
            lblContacto.TabIndex = 0;
            lblContacto.Text = "Contacto";
            // 
            // lblNumero
            // 
            lblNumero.AutoSize = true;
            lblNumero.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNumero.ForeColor = SystemColors.ActiveCaptionText;
            lblNumero.Location = new Point(37, 106);
            lblNumero.Name = "lblNumero";
            lblNumero.Size = new Size(68, 21);
            lblNumero.TabIndex = 1;
            lblNumero.Text = "Número";
            // 
            // btnAgendar
            // 
            btnAgendar.BackColor = SystemColors.ActiveCaption;
            btnAgendar.Enabled = false;
            btnAgendar.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAgendar.ForeColor = SystemColors.InfoText;
            btnAgendar.Location = new Point(239, 170);
            btnAgendar.Name = "btnAgendar";
            btnAgendar.Size = new Size(86, 29);
            btnAgendar.TabIndex = 4;
            btnAgendar.Text = "Agendar";
            btnAgendar.UseVisualStyleBackColor = false;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = SystemColors.ActiveCaption;
            btnCancelar.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCancelar.ForeColor = SystemColors.ControlText;
            btnCancelar.Location = new Point(103, 170);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(80, 29);
            btnCancelar.TabIndex = 6;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            // 
            // mtbNumero
            // 
            mtbNumero.Enabled = false;
            mtbNumero.Location = new Point(135, 105);
            mtbNumero.Mask = "(999)000-0000";
            mtbNumero.Name = "mtbNumero";
            mtbNumero.Size = new Size(100, 22);
            mtbNumero.TabIndex = 7;
            mtbNumero.TextChanged += mtbNumero_TextChanged;
            // 
            // lstResultado
            // 
            lstResultado.FormattingEnabled = true;
            lstResultado.ItemHeight = 13;
            lstResultado.Location = new Point(37, 205);
            lstResultado.Name = "lstResultado";
            lstResultado.Size = new Size(233, 95);
            lstResultado.TabIndex = 8;
            // 
            // txtContacto
            // 
            txtContacto.Location = new Point(135, 36);
            txtContacto.Name = "txtContacto";
            txtContacto.Size = new Size(100, 22);
            txtContacto.TabIndex = 9;
            txtContacto.TextChanged += txtContacto_TextChanged;
            // 
            // lblCantidad
            // 
            lblCantidad.AutoSize = true;
            lblCantidad.ForeColor = SystemColors.ActiveCaptionText;
            lblCantidad.Location = new Point(33, 319);
            lblCantidad.Name = "lblCantidad";
            lblCantidad.Size = new Size(54, 13);
            lblCantidad.TabIndex = 10;
            lblCantidad.Text = "Cantidad";
            // 
            // dtpFecha
            // 
            dtpFecha.Location = new Point(103, 357);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.Size = new Size(200, 22);
            dtpFecha.TabIndex = 11;
            // 
            // txtCantidad
            // 
            txtCantidad.Location = new Point(103, 316);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(100, 22);
            txtCantidad.TabIndex = 12;
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.ForeColor = SystemColors.ActiveCaptionText;
            lblFecha.Location = new Point(33, 364);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(37, 13);
            lblFecha.TabIndex = 13;
            lblFecha.Text = "Fecha";
            // 
            // frmInicio
            // 
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(495, 391);
            Controls.Add(lblFecha);
            Controls.Add(txtCantidad);
            Controls.Add(dtpFecha);
            Controls.Add(lblCantidad);
            Controls.Add(txtContacto);
            Controls.Add(lstResultado);
            Controls.Add(mtbNumero);
            Controls.Add(btnCancelar);
            Controls.Add(btnAgendar);
            Controls.Add(lblNumero);
            Controls.Add(lblContacto);
            Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ForeColor = SystemColors.ActiveCaption;
            Name = "frmInicio";
            Text = "GESTION AGENDA CONTACTO";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblContacto;
        private Label lblNumero;
        private Button btnAgendar;
        private Button btnCancelar;
        private MaskedTextBox mtbNumero;
        private ListBox lstResultado;
        private TextBox txtContacto;
        private Label lblCantidad;
        private DateTimePicker dtpFecha;
        private TextBox txtCantidad;
        private Label lblFecha;
    }
}
