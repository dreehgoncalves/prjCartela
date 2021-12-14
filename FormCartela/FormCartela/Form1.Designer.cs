namespace FormCartela
{
    partial class Form1
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pnInferior = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.rbMega = new System.Windows.Forms.RadioButton();
            this.rbLotomania = new System.Windows.Forms.RadioButton();
            this.rbLotofacil = new System.Windows.Forms.RadioButton();
            this.rbQuina = new System.Windows.Forms.RadioButton();
            this.rbGerar = new System.Windows.Forms.Button();
            this.pnCartelas = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.pnInferior.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(683, 62);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.LightGray;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(683, 58);
            this.label1.TabIndex = 0;
            this.label1.Text = "GERADOR DE CARTELAS";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnInferior
            // 
            this.pnInferior.BackColor = System.Drawing.Color.LightGray;
            this.pnInferior.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnInferior.Controls.Add(this.rbGerar);
            this.pnInferior.Controls.Add(this.rbQuina);
            this.pnInferior.Controls.Add(this.rbLotofacil);
            this.pnInferior.Controls.Add(this.rbLotomania);
            this.pnInferior.Controls.Add(this.rbMega);
            this.pnInferior.Controls.Add(this.label2);
            this.pnInferior.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnInferior.Location = new System.Drawing.Point(0, 320);
            this.pnInferior.Name = "pnInferior";
            this.pnInferior.Size = new System.Drawing.Size(683, 100);
            this.pnInferior.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "TIPOS DE CARTELA";
            // 
            // rbMega
            // 
            this.rbMega.AutoSize = true;
            this.rbMega.Checked = true;
            this.rbMega.Location = new System.Drawing.Point(16, 42);
            this.rbMega.Name = "rbMega";
            this.rbMega.Size = new System.Drawing.Size(99, 21);
            this.rbMega.TabIndex = 1;
            this.rbMega.TabStop = true;
            this.rbMega.Text = "MEGA-SENA";
            this.rbMega.UseVisualStyleBackColor = true;
            // 
            // rbLotomania
            // 
            this.rbLotomania.AutoSize = true;
            this.rbLotomania.Location = new System.Drawing.Point(149, 42);
            this.rbLotomania.Name = "rbLotomania";
            this.rbLotomania.Size = new System.Drawing.Size(98, 21);
            this.rbLotomania.TabIndex = 2;
            this.rbLotomania.Text = "LOTOMANIA";
            this.rbLotomania.UseVisualStyleBackColor = true;
            // 
            // rbLotofacil
            // 
            this.rbLotofacil.AutoSize = true;
            this.rbLotofacil.Location = new System.Drawing.Point(275, 42);
            this.rbLotofacil.Name = "rbLotofacil";
            this.rbLotofacil.Size = new System.Drawing.Size(87, 21);
            this.rbLotofacil.TabIndex = 3;
            this.rbLotofacil.Text = "LOTOFACIL";
            this.rbLotofacil.UseVisualStyleBackColor = true;
            // 
            // rbQuina
            // 
            this.rbQuina.AutoSize = true;
            this.rbQuina.Location = new System.Drawing.Point(392, 42);
            this.rbQuina.Name = "rbQuina";
            this.rbQuina.Size = new System.Drawing.Size(66, 21);
            this.rbQuina.TabIndex = 4;
            this.rbQuina.Text = "QUINA";
            this.rbQuina.UseVisualStyleBackColor = true;
            // 
            // rbGerar
            // 
            this.rbGerar.Location = new System.Drawing.Point(518, 23);
            this.rbGerar.Name = "rbGerar";
            this.rbGerar.Size = new System.Drawing.Size(153, 59);
            this.rbGerar.TabIndex = 5;
            this.rbGerar.Text = "GERAR CARTELA";
            this.rbGerar.UseVisualStyleBackColor = true;
            // 
            // pnCartelas
            // 
            this.pnCartelas.BackColor = System.Drawing.Color.Silver;
            this.pnCartelas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnCartelas.Location = new System.Drawing.Point(0, 56);
            this.pnCartelas.Name = "pnCartelas";
            this.pnCartelas.Size = new System.Drawing.Size(683, 262);
            this.pnCartelas.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(683, 420);
            this.Controls.Add(this.pnCartelas);
            this.Controls.Add(this.pnInferior);
            this.Controls.Add(this.panel1);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.pnInferior.ResumeLayout(false);
            this.pnInferior.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnInferior;
        private System.Windows.Forms.Button rbGerar;
        private System.Windows.Forms.RadioButton rbQuina;
        private System.Windows.Forms.RadioButton rbLotofacil;
        private System.Windows.Forms.RadioButton rbLotomania;
        private System.Windows.Forms.RadioButton rbMega;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel pnCartelas;
    }
}

