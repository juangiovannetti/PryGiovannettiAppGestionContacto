namespace PryGiovannettiAppGestionContacto
{
    partial class frmVerContacto
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
            btnAtras = new Button();
            btnSiguiente = new Button();
            lblDatos = new Label();
            lblDatosArray = new Label();
            btnAbrirGestion = new Button();
            SuspendLayout();
            // 
            // btnAtras
            // 
            btnAtras.BackColor = SystemColors.ActiveCaption;
            btnAtras.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAtras.Location = new Point(30, 188);
            btnAtras.Name = "btnAtras";
            btnAtras.Size = new Size(133, 50);
            btnAtras.TabIndex = 0;
            btnAtras.Text = "Atras";
            btnAtras.UseVisualStyleBackColor = false;
            btnAtras.Click += btnAtras_Click;
            // 
            // btnSiguiente
            // 
            btnSiguiente.BackColor = SystemColors.ActiveCaption;
            btnSiguiente.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSiguiente.Location = new Point(188, 188);
            btnSiguiente.Name = "btnSiguiente";
            btnSiguiente.Size = new Size(133, 50);
            btnSiguiente.TabIndex = 1;
            btnSiguiente.Text = "Siguiente";
            btnSiguiente.UseVisualStyleBackColor = false;
            btnSiguiente.Click += btnSiguiente_Click;
            // 
            // lblDatos
            // 
            lblDatos.BorderStyle = BorderStyle.Fixed3D;
            lblDatos.Location = new Point(30, 51);
            lblDatos.Name = "lblDatos";
            lblDatos.Size = new Size(220, 105);
            lblDatos.TabIndex = 2;
            lblDatos.Text = "---";
            // 
            // lblDatosArray
            // 
            lblDatosArray.BorderStyle = BorderStyle.Fixed3D;
            lblDatosArray.Location = new Point(30, 257);
            lblDatosArray.Name = "lblDatosArray";
            lblDatosArray.Size = new Size(220, 105);
            lblDatosArray.TabIndex = 3;
            // 
            // btnAbrirGestion
            // 
            btnAbrirGestion.BackColor = SystemColors.ActiveCaption;
            btnAbrirGestion.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAbrirGestion.Location = new Point(188, 384);
            btnAbrirGestion.Name = "btnAbrirGestion";
            btnAbrirGestion.Size = new Size(133, 50);
            btnAbrirGestion.TabIndex = 4;
            btnAbrirGestion.Text = "Abrir Gestion";
            btnAbrirGestion.UseVisualStyleBackColor = false;
            // 
            // frmVerContacto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(376, 446);
            Controls.Add(btnAbrirGestion);
            Controls.Add(lblDatosArray);
            Controls.Add(lblDatos);
            Controls.Add(btnSiguiente);
            Controls.Add(btnAtras);
            Name = "frmVerContacto";
            Text = "Ver Contacto";
            Load += frmVerContacto_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button btnAtras;
        private Button btnSiguiente;
        private Label lblDatos;
        private Label lblDatosArray;
        private Button btnAbrirGestion;
    }
}