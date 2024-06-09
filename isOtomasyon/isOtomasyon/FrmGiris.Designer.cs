namespace isOtomasyon
{
    partial class FrmGiris
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
            txtYoneticiGir = new TextBox();
            txtYoneticiSifre = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            button3 = new Button();
            button4 = new Button();
            label3 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.Red;
            label1.Location = new Point(710, 497);
            label1.Margin = new Padding(6, 0, 6, 0);
            label1.Name = "label1";
            label1.Size = new Size(167, 30);
            label1.TabIndex = 0;
            label1.Text = "Mustafa Kaplan";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 48F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.SaddleBrown;
            label2.Location = new Point(110, 101);
            label2.Margin = new Padding(6, 0, 6, 0);
            label2.Name = "label2";
            label2.Size = new Size(703, 86);
            label2.TabIndex = 1;
            label2.Text = "Yazılım Şirketi İş Takip";
            // 
            // txtYoneticiGir
            // 
            txtYoneticiGir.Location = new Point(84, 310);
            txtYoneticiGir.Name = "txtYoneticiGir";
            txtYoneticiGir.Size = new Size(268, 35);
            txtYoneticiGir.TabIndex = 4;
            // 
            // txtYoneticiSifre
            // 
            txtYoneticiSifre.Location = new Point(84, 366);
            txtYoneticiSifre.Name = "txtYoneticiSifre";
            txtYoneticiSifre.Size = new Size(268, 35);
            txtYoneticiSifre.TabIndex = 5;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(567, 366);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(268, 35);
            textBox3.TabIndex = 6;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(567, 310);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(268, 35);
            textBox4.TabIndex = 6;
            // 
            // button3
            // 
            button3.Location = new Point(110, 426);
            button3.Name = "button3";
            button3.Size = new Size(188, 51);
            button3.TabIndex = 7;
            button3.Text = "Giriş Yap";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(625, 426);
            button4.Name = "button4";
            button4.Size = new Size(188, 51);
            button4.TabIndex = 8;
            button4.Text = "Giriş Yap";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label3.ForeColor = Color.MidnightBlue;
            label3.Location = new Point(84, 231);
            label3.Margin = new Padding(6, 0, 6, 0);
            label3.Name = "label3";
            label3.Size = new Size(253, 50);
            label3.TabIndex = 9;
            label3.Text = "Yönetici Giriş";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label4.ForeColor = Color.MidnightBlue;
            label4.Location = new Point(582, 231);
            label4.Margin = new Padding(6, 0, 6, 0);
            label4.Name = "label4";
            label4.Size = new Size(242, 50);
            label4.TabIndex = 10;
            label4.Text = "Çalışan Giriş";
            // 
            // FrmGiris
            // 
            AutoScaleDimensions = new SizeF(13F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackgroundImage = Properties.Resources.images__3_;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(912, 548);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(txtYoneticiSifre);
            Controls.Add(txtYoneticiGir);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            Margin = new Padding(6);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmGiris";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtYoneticiGir;
        private TextBox txtYoneticiSifre;
        private TextBox textBox3;
        private TextBox textBox4;
        private Button button3;
        private Button button4;
        private Label label3;
        private Label label4;
    }
}
