namespace isOtomasyon
{
    partial class FrmYonetici
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
            dataGridView1 = new DataGridView();
            button1 = new Button();
            button2 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            txtDepartmanSil = new TextBox();
            label2 = new Label();
            button3 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(27, 27);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(891, 296);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // button1
            // 
            button1.Location = new Point(12, 339);
            button1.Name = "button1";
            button1.Size = new Size(254, 57);
            button1.TabIndex = 1;
            button1.Text = "Departmanlar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(272, 339);
            button2.Name = "button2";
            button2.Size = new Size(254, 57);
            button2.TabIndex = 2;
            button2.Text = "Meslekler";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button4
            // 
            button4.Location = new Point(12, 402);
            button4.Name = "button4";
            button4.Size = new Size(254, 57);
            button4.TabIndex = 4;
            button4.Text = "Çalışanlar";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(272, 402);
            button5.Name = "button5";
            button5.Size = new Size(254, 57);
            button5.TabIndex = 5;
            button5.Text = "Eklemeler";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.Location = new Point(161, 465);
            button6.Name = "button6";
            button6.Size = new Size(203, 47);
            button6.TabIndex = 6;
            button6.Text = "Kullanıcı kayıt";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button7
            // 
            button7.Location = new Point(597, 558);
            button7.Name = "button7";
            button7.Size = new Size(274, 36);
            button7.TabIndex = 9;
            button7.Text = "Meslek Silme İşlemleri";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // txtDepartmanSil
            // 
            txtDepartmanSil.Location = new Point(689, 408);
            txtDepartmanSil.Name = "txtDepartmanSil";
            txtDepartmanSil.Size = new Size(100, 36);
            txtDepartmanSil.TabIndex = 10;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(667, 366);
            label2.Name = "label2";
            label2.Size = new Size(150, 30);
            label2.TabIndex = 11;
            label2.Text = "Departman Sil";
            // 
            // button3
            // 
            button3.Location = new Point(665, 450);
            button3.Name = "button3";
            button3.Size = new Size(152, 36);
            button3.TabIndex = 12;
            button3.Text = "Sil";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // FrmYonetici
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.images__3_;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(930, 633);
            Controls.Add(button3);
            Controls.Add(label2);
            Controls.Add(txtDepartmanSil);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(5, 6, 5, 6);
            Name = "FrmYonetici";
            Text = "FrmYonetici";
            Load += FrmYonetici_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private TextBox txtDepartmanSil;
        private Label label2;
    }
}