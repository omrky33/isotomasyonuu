namespace isOtomasyon
{
    partial class FrmKayit
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
            txtAd = new TextBox();
            label1 = new Label();
            label2 = new Label();
            txtMail = new TextBox();
            label3 = new Label();
            txtSif = new TextBox();
            label4 = new Label();
            label5 = new Label();
            cbxDepartmen = new ComboBox();
            button2 = new Button();
            cbxMeslek = new ComboBox();
            SuspendLayout();
            // 
            // txtAd
            // 
            txtAd.Location = new Point(29, 96);
            txtAd.Margin = new Padding(5);
            txtAd.Name = "txtAd";
            txtAd.Size = new Size(155, 33);
            txtAd.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(54, 66);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(97, 25);
            label1.TabIndex = 1;
            label1.Text = "Ad Soyad";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(54, 154);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(50, 25);
            label2.TabIndex = 3;
            label2.Text = "Mail";
            // 
            // txtMail
            // 
            txtMail.Location = new Point(29, 184);
            txtMail.Margin = new Padding(5);
            txtMail.Name = "txtMail";
            txtMail.Size = new Size(155, 33);
            txtMail.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(54, 244);
            label3.Margin = new Padding(5, 0, 5, 0);
            label3.Name = "label3";
            label3.Size = new Size(53, 25);
            label3.TabIndex = 5;
            label3.Text = "Sifre";
            // 
            // txtSif
            // 
            txtSif.Location = new Point(29, 274);
            txtSif.Margin = new Padding(5);
            txtSif.Name = "txtSif";
            txtSif.Size = new Size(155, 33);
            txtSif.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(54, 330);
            label4.Margin = new Padding(5, 0, 5, 0);
            label4.Name = "label4";
            label4.Size = new Size(113, 25);
            label4.TabIndex = 7;
            label4.Text = "Departman";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(54, 422);
            label5.Margin = new Padding(5, 0, 5, 0);
            label5.Name = "label5";
            label5.Size = new Size(74, 25);
            label5.TabIndex = 9;
            label5.Text = "Meslek";
            // 
            // cbxDepartmen
            // 
            cbxDepartmen.FormattingEnabled = true;
            cbxDepartmen.Location = new Point(43, 374);
            cbxDepartmen.Name = "cbxDepartmen";
            cbxDepartmen.Size = new Size(121, 33);
            cbxDepartmen.TabIndex = 10;
            // 
            // button2
            // 
            button2.Location = new Point(29, 542);
            button2.Name = "button2";
            button2.Size = new Size(139, 44);
            button2.TabIndex = 13;
            button2.Text = "Kayıt Yap";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // cbxMeslek
            // 
            cbxMeslek.FormattingEnabled = true;
            cbxMeslek.Location = new Point(43, 473);
            cbxMeslek.Name = "cbxMeslek";
            cbxMeslek.Size = new Size(121, 33);
            cbxMeslek.TabIndex = 14;
            // 
            // FrmKayit
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(227, 650);
            Controls.Add(cbxMeslek);
            Controls.Add(button2);
            Controls.Add(cbxDepartmen);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(txtSif);
            Controls.Add(label2);
            Controls.Add(txtMail);
            Controls.Add(label1);
            Controls.Add(txtAd);
            Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            Margin = new Padding(5);
            Name = "FrmKayit";
            Text = "FrmKayit";
            Load += FrmKayit_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtAd;
        private Label label1;
        private Label label2;
        private TextBox txtMail;
        private Label label3;
        private TextBox txtSif;
        private Label label4;
        private Label label5;
        private ComboBox cbxDepartmen;
        private Button button2;
        private ComboBox cbxMeslek;
    }
}