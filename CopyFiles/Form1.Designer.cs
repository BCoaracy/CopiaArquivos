﻿namespace CopyFiles
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
            this.button1 = new System.Windows.Forms.Button();
            this.empresasNFCE = new System.Windows.Forms.CheckBox();
            this.outraEmpresa = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtOutraEmpresa = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(197, 227);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Executar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // empresasNFCE
            // 
            this.empresasNFCE.AutoSize = true;
            this.empresasNFCE.Location = new System.Drawing.Point(12, 56);
            this.empresasNFCE.Name = "empresasNFCE";
            this.empresasNFCE.Size = new System.Drawing.Size(81, 17);
            this.empresasNFCE.TabIndex = 1;
            this.empresasNFCE.TabStop = false;
            this.empresasNFCE.Text = "ECF/NFC-e";
            this.empresasNFCE.UseVisualStyleBackColor = true;
            // 
            // outraEmpresa
            // 
            this.outraEmpresa.AutoSize = true;
            this.outraEmpresa.Location = new System.Drawing.Point(12, 79);
            this.outraEmpresa.Name = "outraEmpresa";
            this.outraEmpresa.Size = new System.Drawing.Size(58, 17);
            this.outraEmpresa.TabIndex = 2;
            this.outraEmpresa.TabStop = false;
            this.outraEmpresa.Text = "Outra: ";
            this.outraEmpresa.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Grupo de Empresas";
            // 
            // txtOutraEmpresa
            // 
            this.txtOutraEmpresa.Location = new System.Drawing.Point(76, 77);
            this.txtOutraEmpresa.Name = "txtOutraEmpresa";
            this.txtOutraEmpresa.Size = new System.Drawing.Size(100, 20);
            this.txtOutraEmpresa.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.txtOutraEmpresa);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.outraEmpresa);
            this.Controls.Add(this.empresasNFCE);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox empresasNFCE;
        private System.Windows.Forms.CheckBox outraEmpresa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtOutraEmpresa;
    }
}

