namespace Aplikasi_Diskon
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
            txttotalbelanja = new TextBox();
            txtdiskon = new TextBox();
            txtharga = new TextBox();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(145, 88);
            label1.Name = "label1";
            label1.Size = new Size(95, 20);
            label1.TabIndex = 0;
            label1.Text = "Total Belanja";
            label1.TextAlign = ContentAlignment.TopCenter;
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(145, 147);
            label2.Name = "label2";
            label2.Size = new Size(80, 20);
            label2.TabIndex = 1;
            label2.Text = "Diskon (%)";
            label2.TextAlign = ContentAlignment.TopCenter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(145, 207);
            label3.Name = "label3";
            label3.Size = new Size(184, 20);
            label3.TabIndex = 2;
            label3.Text = "Harga Yang Harus Dibayar";
            label3.TextAlign = ContentAlignment.TopCenter;
            // 
            // txttotalbelanja
            // 
            txttotalbelanja.Location = new Point(272, 85);
            txttotalbelanja.Name = "txttotalbelanja";
            txttotalbelanja.Size = new Size(232, 27);
            txttotalbelanja.TabIndex = 3;
            // 
            // txtdiskon
            // 
            txtdiskon.Location = new Point(272, 147);
            txtdiskon.Name = "txtdiskon";
            txtdiskon.Size = new Size(121, 27);
            txtdiskon.TabIndex = 4;
            // 
            // txtharga
            // 
            txtharga.Location = new Point(145, 245);
            txtharga.Name = "txtharga";
            txtharga.Size = new Size(359, 27);
            txtharga.TabIndex = 5;
            txtharga.TextChanged += txtharga_TextChanged;
            // 
            // button1
            // 
            button1.Location = new Point(544, 82);
            button1.Name = "button1";
            button1.Size = new Size(86, 32);
            button1.TabIndex = 6;
            button1.Text = "Hitung";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(544, 129);
            button2.Name = "button2";
            button2.Size = new Size(86, 28);
            button2.TabIndex = 7;
            button2.Text = "Clear";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(txtharga);
            Controls.Add(txtdiskon);
            Controls.Add(txttotalbelanja);
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
        private TextBox txttotalbelanja;
        private TextBox txtdiskon;
        private TextBox txtharga;
        private Button button1;
        private Button button2;
    }
}