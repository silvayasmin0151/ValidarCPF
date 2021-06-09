
namespace ValidarCPF
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
            this.label1_DigiteCPF = new System.Windows.Forms.Label();
            this.textBox_CPF = new System.Windows.Forms.TextBox();
            this.bt_checarCPF = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.resultado = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1_DigiteCPF
            // 
            this.label1_DigiteCPF.AutoSize = true;
            this.label1_DigiteCPF.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1_DigiteCPF.Location = new System.Drawing.Point(12, 136);
            this.label1_DigiteCPF.Name = "label1_DigiteCPF";
            this.label1_DigiteCPF.Size = new System.Drawing.Size(113, 21);
            this.label1_DigiteCPF.TabIndex = 0;
            this.label1_DigiteCPF.Text = "Digite seu CPF:";
            // 
            // textBox_CPF
            // 
            this.textBox_CPF.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox_CPF.Location = new System.Drawing.Point(12, 160);
            this.textBox_CPF.Name = "textBox_CPF";
            this.textBox_CPF.PlaceholderText = "###.###.###-##";
            this.textBox_CPF.Size = new System.Drawing.Size(180, 29);
            this.textBox_CPF.TabIndex = 1;
            // 
            // bt_checarCPF
            // 
            this.bt_checarCPF.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.bt_checarCPF.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bt_checarCPF.Location = new System.Drawing.Point(27, 211);
            this.bt_checarCPF.Name = "bt_checarCPF";
            this.bt_checarCPF.Size = new System.Drawing.Size(144, 34);
            this.bt_checarCPF.TabIndex = 2;
            this.bt_checarCPF.Text = "Checar CPF";
            this.bt_checarCPF.UseVisualStyleBackColor = false;
            this.bt_checarCPF.Click += new System.EventHandler(this.bt_checarCPF_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Resultado:";
            // 
            // resultado
            // 
            this.resultado.AutoSize = true;
            this.resultado.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.resultado.Location = new System.Drawing.Point(0, 25);
            this.resultado.Name = "resultado";
            this.resultado.Size = new System.Drawing.Size(24, 25);
            this.resultado.TabIndex = 4;
            this.resultado.Text = "...";
            this.resultado.Visible = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Controls.Add(this.resultado);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 33);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(180, 76);
            this.panel1.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(217, 285);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.bt_checarCPF);
            this.Controls.Add(this.textBox_CPF);
            this.Controls.Add(this.label1_DigiteCPF);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1_DigiteCPF;
        private System.Windows.Forms.TextBox textBox_CPF;
        private System.Windows.Forms.Button bt_checarCPF;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label resultado;
        private System.Windows.Forms.Panel panel1;
    }
}

