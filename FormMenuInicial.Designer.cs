namespace ProyectoCuentas_Unidad1_
{
    partial class FormMenuInicial
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMenuInicial));
            label1 = new Label();
            btnIngresarMovimiento = new Button();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Perpetua Titling MT", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(54, 46);
            label1.Name = "label1";
            label1.Size = new Size(283, 72);
            label1.TabIndex = 0;
            label1.Text = "SISTEMA GESTOR\r\n    DE CUENTAS\r\n";
            // 
            // btnIngresarMovimiento
            // 
            btnIngresarMovimiento.BackColor = Color.FromArgb(255, 224, 192);
            btnIngresarMovimiento.Font = new Font("Book Antiqua", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnIngresarMovimiento.Location = new Point(45, 135);
            btnIngresarMovimiento.Name = "btnIngresarMovimiento";
            btnIngresarMovimiento.Size = new Size(143, 75);
            btnIngresarMovimiento.TabIndex = 1;
            btnIngresarMovimiento.Text = "Nuevo Movimiento";
            btnIngresarMovimiento.UseVisualStyleBackColor = false;
            btnIngresarMovimiento.Click += btnIngresarMovimiento_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(255, 224, 192);
            button1.Font = new Font("Book Antiqua", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(207, 135);
            button1.Name = "button1";
            button1.Size = new Size(143, 75);
            button1.TabIndex = 2;
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(255, 224, 192);
            button2.Font = new Font("Book Antiqua", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(45, 235);
            button2.Name = "button2";
            button2.Size = new Size(143, 75);
            button2.TabIndex = 3;
            button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(255, 224, 192);
            button3.Font = new Font("Book Antiqua", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button3.Location = new Point(207, 235);
            button3.Name = "button3";
            button3.Size = new Size(143, 75);
            button3.TabIndex = 4;
            button3.UseVisualStyleBackColor = false;
            // 
            // FormMenuInicial
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.OldLace;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(633, 388);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(btnIngresarMovimiento);
            Controls.Add(label1);
            Name = "FormMenuInicial";
            Text = "Menu Inicial";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnIngresarMovimiento;
        private Button button1;
        private Button button2;
        private Button button3;
    }
}