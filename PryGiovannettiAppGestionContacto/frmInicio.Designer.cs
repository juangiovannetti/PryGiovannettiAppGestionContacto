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
            mtbContacto = new TextBox();
            lblCantidad = new Label();
            dtpFecha = new DateTimePicker();
            lblFecha = new Label();
            label1 = new Label();
            btnMostar = new Button();
            btnLimpiar = new Button();
            lblCantidadContactos = new Label();
            lblCantidadContacto = new Label();
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
            lblNumero.Location = new Point(37, 91);
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
            btnAgendar.Location = new Point(184, 131);
            btnAgendar.Name = "btnAgendar";
            btnAgendar.Size = new Size(86, 29);
            btnAgendar.TabIndex = 4;
            btnAgendar.Text = "Agendar";
            btnAgendar.UseVisualStyleBackColor = false;
            btnAgendar.Click += btnAgendar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = SystemColors.ActiveCaption;
            btnCancelar.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCancelar.ForeColor = SystemColors.ControlText;
            btnCancelar.Location = new Point(98, 131);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(80, 29);
            btnCancelar.TabIndex = 6;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // mtbNumero
            // 
            mtbNumero.Enabled = false;
            mtbNumero.Location = new Point(135, 90);
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
            lstResultado.Location = new Point(33, 182);
            lstResultado.Name = "lstResultado";
            lstResultado.Size = new Size(233, 95);
            lstResultado.TabIndex = 8;
            // 
            // mtbContacto
            // 
            mtbContacto.Location = new Point(135, 36);
            mtbContacto.Name = "mtbContacto";
            mtbContacto.Size = new Size(135, 22);
            mtbContacto.TabIndex = 9;
            mtbContacto.TextChanged += txtContacto_TextChanged;
            // 
            // lblCantidad
            // 
            lblCantidad.AutoSize = true;
            lblCantidad.ForeColor = SystemColors.ActiveCaptionText;
            lblCantidad.Location = new Point(29, 296);
            lblCantidad.Name = "lblCantidad";
            lblCantidad.Size = new Size(54, 13);
            lblCantidad.TabIndex = 10;
            lblCantidad.Text = "Cantidad";
            // 
            // dtpFecha
            // 
            dtpFecha.Enabled = false;
            dtpFecha.Format = DateTimePickerFormat.Short;
            dtpFecha.Location = new Point(99, 334);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.Size = new Size(100, 22);
            dtpFecha.TabIndex = 11;
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.ForeColor = SystemColors.ActiveCaptionText;
            lblFecha.Location = new Point(29, 341);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(37, 13);
            lblFecha.TabIndex = 13;
            lblFecha.Text = "Fecha";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(342, 360);
            label1.Name = "label1";
            label1.Size = new Size(38, 13);
            label1.TabIndex = 14;
            label1.Text = "label1";
            // 
            // btnMostar
            // 
            btnMostar.Location = new Point(94, 391);
            btnMostar.Name = "btnMostar";
            btnMostar.Size = new Size(70, 26);
            btnMostar.TabIndex = 16;
            btnMostar.Text = "Mostar";
            btnMostar.UseVisualStyleBackColor = true;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(198, 391);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(68, 26);
            btnLimpiar.TabIndex = 17;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            // 
            // lblCantidadContactos
            // 
            lblCantidadContactos.AutoSize = true;
            lblCantidadContactos.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCantidadContactos.Location = new Point(111, 296);
            lblCantidadContactos.Name = "lblCantidadContactos";
            lblCantidadContactos.Size = new Size(0, 20);
            lblCantidadContactos.TabIndex = 18;
            // 
            // lblCantidadContacto
            // 
            lblCantidadContacto.AutoSize = true;
            lblCantidadContacto.ForeColor = SystemColors.ActiveCaptionText;
            lblCantidadContacto.Location = new Point(99, 296);
            lblCantidadContacto.Name = "lblCantidadContacto";
            lblCantidadContacto.Size = new Size(19, 13);
            lblCantidadContacto.TabIndex = 19;
            lblCantidadContacto.Text = "---";
            // 
            // frmInicio
            // 
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(346, 439);
            Controls.Add(lblCantidadContacto);
            Controls.Add(lblCantidadContactos);
            Controls.Add(btnLimpiar);
            Controls.Add(btnMostar);
            Controls.Add(label1);
            Controls.Add(lblFecha);
            Controls.Add(dtpFecha);
            Controls.Add(lblCantidad);
            Controls.Add(mtbContacto);
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
            Load += frmInicio_Load;
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
        //private TextBox txtContacto;
        private Label lblCantidad;
        private DateTimePicker dtpFecha;
        private Label lblFecha;
        private Label label1;
        private TextBox mtbContacto;
        private Button btnMostar;
        private Button btnLimpiar;
        private Label lblCantidadContactos;
        private Label lblCantidadContacto;
    }
}
