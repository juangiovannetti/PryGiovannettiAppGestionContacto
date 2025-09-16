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
            lblFecha = new Label();
            lblCantidadContactos = new Label();
            lblCantidadContacto = new Label();
            btnVerContactos = new Button();
            mtbFecha = new MaskedTextBox();
            SuspendLayout();
            // 
            // lblContacto
            // 
            lblContacto.AutoSize = true;
            lblContacto.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblContacto.ForeColor = SystemColors.ActiveCaptionText;
            lblContacto.Location = new Point(33, 33);
            lblContacto.Name = "lblContacto";
            lblContacto.Size = new Size(60, 17);
            lblContacto.TabIndex = 0;
            lblContacto.Text = "Contacto";
            // 
            // lblNumero
            // 
            lblNumero.AutoSize = true;
            lblNumero.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNumero.ForeColor = SystemColors.ActiveCaptionText;
            lblNumero.Location = new Point(37, 91);
            lblNumero.Name = "lblNumero";
            lblNumero.Size = new Size(56, 17);
            lblNumero.TabIndex = 1;
            lblNumero.Text = "Número";
            // 
            // btnAgendar
            // 
            btnAgendar.BackColor = SystemColors.ActiveCaption;
            btnAgendar.Enabled = false;
            btnAgendar.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
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
            btnCancelar.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
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
            mtbNumero.MaskInputRejected += mtbNumero_MaskInputRejected;
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
            mtbContacto.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            mtbContacto.Location = new Point(135, 36);
            mtbContacto.Name = "mtbContacto";
            mtbContacto.Size = new Size(135, 25);
            mtbContacto.TabIndex = 9;
            mtbContacto.TextChanged += txtContacto_TextChanged;
            // 
            // lblCantidad
            // 
            lblCantidad.AutoSize = true;
            lblCantidad.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCantidad.ForeColor = SystemColors.ActiveCaptionText;
            lblCantidad.Location = new Point(29, 296);
            lblCantidad.Name = "lblCantidad";
            lblCantidad.Size = new Size(60, 17);
            lblCantidad.TabIndex = 10;
            lblCantidad.Text = "Cantidad";
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblFecha.ForeColor = SystemColors.ActiveCaptionText;
            lblFecha.Location = new Point(29, 337);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(41, 17);
            lblFecha.TabIndex = 13;
            lblFecha.Text = "Fecha";
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
            // btnVerContactos
            // 
            btnVerContactos.BackColor = SystemColors.ActiveCaption;
            btnVerContactos.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnVerContactos.ForeColor = SystemColors.ActiveCaptionText;
            btnVerContactos.Location = new Point(184, 376);
            btnVerContactos.Name = "btnVerContactos";
            btnVerContactos.Size = new Size(119, 29);
            btnVerContactos.TabIndex = 20;
            btnVerContactos.Text = "Ver Contacto";
            btnVerContactos.UseVisualStyleBackColor = false;
            btnVerContactos.Click += btnVerContactos_Click;
            // 
            // mtbFecha
            // 
            mtbFecha.Location = new Point(98, 332);
            mtbFecha.Mask = "00/00/0000 00:00";
            mtbFecha.Name = "mtbFecha";
            mtbFecha.Size = new Size(100, 22);
            mtbFecha.TabIndex = 21;
            mtbFecha.ValidatingType = typeof(DateTime);
            // 
            // frmInicio
            // 
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(331, 426);
            Controls.Add(mtbFecha);
            Controls.Add(btnVerContactos);
            Controls.Add(lblCantidadContacto);
            Controls.Add(lblCantidadContactos);
            Controls.Add(lblFecha);
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
        private Label lblFecha;
        private TextBox mtbContacto;
        private Label lblCantidadContactos;
        private Label lblCantidadContacto;
        private Button btnVerContactos;
        private MaskedTextBox mtbFecha;
    }
}
