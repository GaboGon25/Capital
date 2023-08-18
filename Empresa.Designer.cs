namespace Capital
{
    partial class Empresa
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSocio1 = new System.Windows.Forms.TextBox();
            this.txtSocio2 = new System.Windows.Forms.TextBox();
            this.txtSocio3 = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCapital = new System.Windows.Forms.TextBox();
            this.txtPor1 = new System.Windows.Forms.TextBox();
            this.txtPor2 = new System.Windows.Forms.TextBox();
            this.txtPor3 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(171, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "EMPRESA";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Socio 1:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Socio 2:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(43, 238);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Socio 3:";
            // 
            // txtSocio1
            // 
            this.txtSocio1.Location = new System.Drawing.Point(103, 117);
            this.txtSocio1.Name = "txtSocio1";
            this.txtSocio1.Size = new System.Drawing.Size(203, 20);
            this.txtSocio1.TabIndex = 4;
            // 
            // txtSocio2
            // 
            this.txtSocio2.Location = new System.Drawing.Point(103, 176);
            this.txtSocio2.Name = "txtSocio2";
            this.txtSocio2.Size = new System.Drawing.Size(203, 20);
            this.txtSocio2.TabIndex = 5;
            // 
            // txtSocio3
            // 
            this.txtSocio3.Location = new System.Drawing.Point(104, 231);
            this.txtSocio3.Name = "txtSocio3";
            this.txtSocio3.Size = new System.Drawing.Size(203, 20);
            this.txtSocio3.TabIndex = 6;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(76, 287);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(127, 52);
            this.btnCalcular.TabIndex = 7;
            this.btnCalcular.Text = "CALCULAR CAPITAL";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(283, 287);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(127, 52);
            this.btnNuevo.TabIndex = 8;
            this.btnNuevo.Text = "NUEVA OPERACION";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(48, 375);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Total Capital:";
            // 
            // txtCapital
            // 
            this.txtCapital.Location = new System.Drawing.Point(120, 372);
            this.txtCapital.Name = "txtCapital";
            this.txtCapital.Size = new System.Drawing.Size(187, 20);
            this.txtCapital.TabIndex = 10;
            // 
            // txtPor1
            // 
            this.txtPor1.Location = new System.Drawing.Point(329, 117);
            this.txtPor1.Name = "txtPor1";
            this.txtPor1.Size = new System.Drawing.Size(49, 20);
            this.txtPor1.TabIndex = 11;
            // 
            // txtPor2
            // 
            this.txtPor2.Location = new System.Drawing.Point(329, 176);
            this.txtPor2.Name = "txtPor2";
            this.txtPor2.Size = new System.Drawing.Size(49, 20);
            this.txtPor2.TabIndex = 12;
            // 
            // txtPor3
            // 
            this.txtPor3.Location = new System.Drawing.Point(329, 231);
            this.txtPor3.Name = "txtPor3";
            this.txtPor3.Size = new System.Drawing.Size(49, 20);
            this.txtPor3.TabIndex = 13;
            // 
            // Empresa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 496);
            this.Controls.Add(this.txtPor3);
            this.Controls.Add(this.txtPor2);
            this.Controls.Add(this.txtPor1);
            this.Controls.Add(this.txtCapital);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtSocio3);
            this.Controls.Add(this.txtSocio2);
            this.Controls.Add(this.txtSocio1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Empresa";
            this.Text = "Empresa";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSocio1;
        private System.Windows.Forms.TextBox txtSocio2;
        private System.Windows.Forms.TextBox txtSocio3;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCapital;
        private System.Windows.Forms.TextBox txtPor1;
        private System.Windows.Forms.TextBox txtPor2;
        private System.Windows.Forms.TextBox txtPor3;
    }
}