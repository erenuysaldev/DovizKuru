namespace DovizFiyatlari
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            lblDolarAlış = new Label();
            lblDolarSatis = new Label();
            lblEuroAlış = new Label();
            lblEuroSatış = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F);
            label1.Location = new Point(64, 32);
            label1.Name = "label1";
            label1.Size = new Size(127, 32);
            label1.TabIndex = 0;
            label1.Text = "Dolar Alış :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F);
            label2.Location = new Point(64, 100);
            label2.Name = "label2";
            label2.Size = new Size(139, 32);
            label2.TabIndex = 1;
            label2.Text = "Dolar Satış :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 18F);
            label3.Location = new Point(64, 174);
            label3.Name = "label3";
            label3.Size = new Size(118, 32);
            label3.TabIndex = 2;
            label3.Text = "Euro Alış :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 18F);
            label4.Location = new Point(64, 258);
            label4.Name = "label4";
            label4.Size = new Size(130, 32);
            label4.TabIndex = 3;
            label4.Text = "Euro Satış :";
            // 
            // lblDolarAlış
            // 
            lblDolarAlış.AutoSize = true;
            lblDolarAlış.Font = new Font("Segoe UI", 14.25F);
            lblDolarAlış.Location = new Point(197, 39);
            lblDolarAlış.Name = "lblDolarAlış";
            lblDolarAlış.Size = new Size(32, 25);
            lblDolarAlış.TabIndex = 4;
            lblDolarAlış.Text = "00";
            // 
            // lblDolarSatis
            // 
            lblDolarSatis.AutoSize = true;
            lblDolarSatis.Font = new Font("Segoe UI", 14.25F);
            lblDolarSatis.Location = new Point(197, 107);
            lblDolarSatis.Name = "lblDolarSatis";
            lblDolarSatis.Size = new Size(32, 25);
            lblDolarSatis.TabIndex = 5;
            lblDolarSatis.Text = "00";
            // 
            // lblEuroAlış
            // 
            lblEuroAlış.AutoSize = true;
            lblEuroAlış.Font = new Font("Segoe UI", 14.25F);
            lblEuroAlış.Location = new Point(197, 181);
            lblEuroAlış.Name = "lblEuroAlış";
            lblEuroAlış.Size = new Size(32, 25);
            lblEuroAlış.TabIndex = 6;
            lblEuroAlış.Text = "00";
            lblEuroAlış.Click += label7_Click;
            // 
            // lblEuroSatış
            // 
            lblEuroSatış.AutoSize = true;
            lblEuroSatış.Font = new Font("Segoe UI", 14.25F);
            lblEuroSatış.Location = new Point(197, 265);
            lblEuroSatış.Name = "lblEuroSatış";
            lblEuroSatış.Size = new Size(32, 25);
            lblEuroSatış.TabIndex = 7;
            lblEuroSatış.Text = "00";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 326);
            Controls.Add(lblEuroSatış);
            Controls.Add(lblEuroAlış);
            Controls.Add(lblDolarSatis);
            Controls.Add(lblDolarAlış);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label lblDolarAlış;
        private Label lblDolarSatis;
        private Label lblEuroAlış;
        private Label lblEuroSatış;
    }
}
