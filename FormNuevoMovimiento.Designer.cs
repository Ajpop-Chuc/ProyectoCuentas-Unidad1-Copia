namespace ProyectoCuentas_Unidad1_
{
    partial class FormNuevoMovimiento
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
            CBoxInDebe = new ComboBox();
            CBoxInHaber = new ComboBox();
            TBoxInMontoDebe = new TextBox();
            TBoxInMontoHaber = new TextBox();
            BtnGuardarDebe = new Button();
            BtnGuardarHaber = new Button();
            BtnFinMovimiento = new Button();
            BtnGuardarNuevaCuenta = new Button();
            CBoxNewTipoCuenta = new ComboBox();
            TBoxNombreCuentaNueva = new TextBox();
            BtnNuevaCuenta = new Button();
            btnReset = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // CBoxInDebe
            // 
            CBoxInDebe.Font = new Font("Book Antiqua", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            CBoxInDebe.FormattingEnabled = true;
            CBoxInDebe.Location = new Point(70, 96);
            CBoxInDebe.Name = "CBoxInDebe";
            CBoxInDebe.Size = new Size(151, 30);
            CBoxInDebe.TabIndex = 0;
            // 
            // CBoxInHaber
            // 
            CBoxInHaber.Font = new Font("Book Antiqua", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            CBoxInHaber.FormattingEnabled = true;
            CBoxInHaber.Location = new Point(70, 160);
            CBoxInHaber.Name = "CBoxInHaber";
            CBoxInHaber.Size = new Size(151, 30);
            CBoxInHaber.TabIndex = 1;
            // 
            // TBoxInMontoDebe
            // 
            TBoxInMontoDebe.Font = new Font("Book Antiqua", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            TBoxInMontoDebe.Location = new Point(248, 96);
            TBoxInMontoDebe.Name = "TBoxInMontoDebe";
            TBoxInMontoDebe.Size = new Size(146, 28);
            TBoxInMontoDebe.TabIndex = 2;
            // 
            // TBoxInMontoHaber
            // 
            TBoxInMontoHaber.Font = new Font("Book Antiqua", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            TBoxInMontoHaber.Location = new Point(248, 161);
            TBoxInMontoHaber.Name = "TBoxInMontoHaber";
            TBoxInMontoHaber.Size = new Size(146, 28);
            TBoxInMontoHaber.TabIndex = 3;
            // 
            // BtnGuardarDebe
            // 
            BtnGuardarDebe.BackColor = Color.FromArgb(255, 224, 192);
            BtnGuardarDebe.FlatAppearance.BorderColor = Color.FromArgb(192, 192, 0);
            BtnGuardarDebe.FlatAppearance.BorderSize = 4;
            BtnGuardarDebe.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 128, 128);
            BtnGuardarDebe.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 128, 255);
            BtnGuardarDebe.Font = new Font("Book Antiqua", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            BtnGuardarDebe.Location = new Point(422, 82);
            BtnGuardarDebe.Name = "BtnGuardarDebe";
            BtnGuardarDebe.Size = new Size(143, 51);
            BtnGuardarDebe.TabIndex = 4;
            BtnGuardarDebe.Text = "Guardar Debe";
            BtnGuardarDebe.UseVisualStyleBackColor = false;
            BtnGuardarDebe.Click += BtnGuardarDebe_Click;
            // 
            // BtnGuardarHaber
            // 
            BtnGuardarHaber.BackColor = Color.FromArgb(255, 224, 192);
            BtnGuardarHaber.Font = new Font("Book Antiqua", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            BtnGuardarHaber.Location = new Point(422, 148);
            BtnGuardarHaber.Name = "BtnGuardarHaber";
            BtnGuardarHaber.Size = new Size(143, 53);
            BtnGuardarHaber.TabIndex = 5;
            BtnGuardarHaber.Text = "Guardar Haber";
            BtnGuardarHaber.UseVisualStyleBackColor = false;
            BtnGuardarHaber.Click += BtnGuardarHaber_Click;
            // 
            // BtnFinMovimiento
            // 
            BtnFinMovimiento.BackColor = Color.FromArgb(255, 224, 192);
            BtnFinMovimiento.Font = new Font("Book Antiqua", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            BtnFinMovimiento.Location = new Point(248, 217);
            BtnFinMovimiento.Name = "BtnFinMovimiento";
            BtnFinMovimiento.Size = new Size(146, 51);
            BtnFinMovimiento.TabIndex = 6;
            BtnFinMovimiento.Text = "Teminar Partida";
            BtnFinMovimiento.UseVisualStyleBackColor = false;
            BtnFinMovimiento.Click += BtnFinMovimiento_Click;
            // 
            // BtnGuardarNuevaCuenta
            // 
            BtnGuardarNuevaCuenta.BackColor = Color.FromArgb(255, 224, 192);
            BtnGuardarNuevaCuenta.Font = new Font("Book Antiqua", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            BtnGuardarNuevaCuenta.Location = new Point(422, 303);
            BtnGuardarNuevaCuenta.Name = "BtnGuardarNuevaCuenta";
            BtnGuardarNuevaCuenta.Size = new Size(144, 46);
            BtnGuardarNuevaCuenta.TabIndex = 7;
            BtnGuardarNuevaCuenta.Text = "Guardar Cuenta";
            BtnGuardarNuevaCuenta.UseVisualStyleBackColor = false;
            BtnGuardarNuevaCuenta.Visible = false;
            BtnGuardarNuevaCuenta.Click += BtnGuardarNuevaCuenta_Click;
            // 
            // CBoxNewTipoCuenta
            // 
            CBoxNewTipoCuenta.Font = new Font("Book Antiqua", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            CBoxNewTipoCuenta.FormattingEnabled = true;
            CBoxNewTipoCuenta.Items.AddRange(new object[] { "ActivoCorriente", "ActivoNoCorriente", "PasivoCorriente", "PasivoNoCorriente" });
            CBoxNewTipoCuenta.Location = new Point(70, 312);
            CBoxNewTipoCuenta.Name = "CBoxNewTipoCuenta";
            CBoxNewTipoCuenta.Size = new Size(151, 30);
            CBoxNewTipoCuenta.TabIndex = 8;
            CBoxNewTipoCuenta.Visible = false;
            // 
            // TBoxNombreCuentaNueva
            // 
            TBoxNombreCuentaNueva.Font = new Font("Book Antiqua", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            TBoxNombreCuentaNueva.Location = new Point(248, 312);
            TBoxNombreCuentaNueva.Name = "TBoxNombreCuentaNueva";
            TBoxNombreCuentaNueva.Size = new Size(146, 28);
            TBoxNombreCuentaNueva.TabIndex = 9;
            TBoxNombreCuentaNueva.Visible = false;
            // 
            // BtnNuevaCuenta
            // 
            BtnNuevaCuenta.BackColor = Color.FromArgb(255, 224, 192);
            BtnNuevaCuenta.Font = new Font("Book Antiqua", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            BtnNuevaCuenta.Location = new Point(70, 217);
            BtnNuevaCuenta.Name = "BtnNuevaCuenta";
            BtnNuevaCuenta.Size = new Size(151, 51);
            BtnNuevaCuenta.TabIndex = 10;
            BtnNuevaCuenta.Text = "Crear Cuenta";
            BtnNuevaCuenta.UseVisualStyleBackColor = false;
            BtnNuevaCuenta.Click += BtnNuevaCuenta_Click;
            // 
            // btnReset
            // 
            btnReset.BackColor = Color.FromArgb(255, 224, 192);
            btnReset.Font = new Font("Book Antiqua", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnReset.Location = new Point(422, 217);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(143, 51);
            btnReset.TabIndex = 11;
            btnReset.Text = "Nueva Partida";
            btnReset.UseVisualStyleBackColor = false;
            btnReset.Click += btnReset_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Perpetua Titling MT", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(159, 25);
            label1.Name = "label1";
            label1.Size = new Size(357, 36);
            label1.TabIndex = 12;
            label1.Text = "Nuevo Movimiento";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Perpetua Titling MT", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(116, 34);
            label2.Name = "label2";
            label2.Size = new Size(450, 36);
            label2.TabIndex = 13;
            label2.Text = "_____________________________";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Perpetua Titling MT", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(23, 257);
            label3.Name = "label3";
            label3.Size = new Size(630, 36);
            label3.TabIndex = 14;
            label3.Text = "_________________________________________";
            // 
            // FormNuevoMovimiento
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.CadetBlue;
            ClientSize = new Size(667, 385);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(btnReset);
            Controls.Add(BtnNuevaCuenta);
            Controls.Add(TBoxNombreCuentaNueva);
            Controls.Add(CBoxNewTipoCuenta);
            Controls.Add(BtnGuardarNuevaCuenta);
            Controls.Add(BtnFinMovimiento);
            Controls.Add(BtnGuardarHaber);
            Controls.Add(BtnGuardarDebe);
            Controls.Add(TBoxInMontoHaber);
            Controls.Add(TBoxInMontoDebe);
            Controls.Add(CBoxInHaber);
            Controls.Add(CBoxInDebe);
            Controls.Add(label3);
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            Name = "FormNuevoMovimiento";
            Text = "FormNuevoMovimiento";
            Load += FormNuevoMovimiento_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox CBoxInDebe;
        private ComboBox CBoxInHaber;
        private TextBox TBoxInMontoDebe;
        private TextBox TBoxInMontoHaber;
        private Button BtnGuardarDebe;
        private Button BtnGuardarHaber;
        private Button BtnFinMovimiento;
        private Button BtnGuardarNuevaCuenta;
        private ComboBox CBoxNewTipoCuenta;
        private TextBox TBoxNombreCuentaNueva;
        private Button BtnNuevaCuenta;
        private Button btnReset;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}