namespace Proyecto1Compi
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
            btnEjecutar = new Button();
            btnCompilar = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // btnEjecutar
            // 
            btnEjecutar.BackColor = Color.FromArgb(2, 94, 115);
            btnEjecutar.FlatAppearance.BorderColor = Color.FromArgb(2, 94, 115);
            btnEjecutar.Font = new Font("Arial", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            btnEjecutar.ForeColor = Color.White;
            btnEjecutar.Location = new Point(189, 90);
            btnEjecutar.Margin = new Padding(3, 2, 3, 2);
            btnEjecutar.Name = "btnEjecutar";
            btnEjecutar.Size = new Size(317, 59);
            btnEjecutar.TabIndex = 0;
            btnEjecutar.Text = "Seleccionar archivo";
            btnEjecutar.UseVisualStyleBackColor = false;
            btnEjecutar.Click += btnEjecutar_Click;
            // 
            // btnCompilar
            // 
            btnCompilar.BackColor = Color.FromArgb(2, 94, 115);
            btnCompilar.Font = new Font("Arial", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            btnCompilar.ForeColor = Color.White;
            btnCompilar.Location = new Point(242, 160);
            btnCompilar.Margin = new Padding(3, 2, 3, 2);
            btnCompilar.Name = "btnCompilar";
            btnCompilar.Size = new Size(220, 61);
            btnCompilar.TabIndex = 1;
            btnCompilar.Text = "Compilar";
            btnCompilar.UseVisualStyleBackColor = false;
            btnCompilar.Click += btnCompilar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(242, 167, 27);
            label1.Location = new Point(75, 32);
            label1.Name = "label1";
            label1.Size = new Size(557, 36);
            label1.TabIndex = 2;
            label1.Text = "PROYECTO FINAL COMPILADORES";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.FromArgb(242, 167, 27);
            label2.Location = new Point(276, 255);
            label2.Name = "label2";
            label2.Size = new Size(146, 15);
            label2.TabIndex = 3;
            label2.Text = "Angely Thomas 202108047";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.FromArgb(242, 167, 27);
            label3.Location = new Point(276, 279);
            label3.Name = "label3";
            label3.Size = new Size(139, 15);
            label3.TabIndex = 4;
            label3.Text = "Pablo Vasquez 202108025";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(1, 31, 38);
            ClientSize = new Size(700, 338);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnCompilar);
            Controls.Add(btnEjecutar);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnEjecutar;
        private Button btnCompilar;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}