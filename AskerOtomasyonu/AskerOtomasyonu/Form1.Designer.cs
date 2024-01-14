namespace AskerOtomasyonu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            listBox1 = new ListBox();
            listBox2 = new ListBox();
            listBox3 = new ListBox();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            temizle = new Button();
            askerdagit = new Button();
            sehirekle = new Button();
            askerekle = new Button();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(27, 22);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(141, 199);
            listBox1.TabIndex = 0;
            // 
            // listBox2
            // 
            listBox2.FormattingEnabled = true;
            listBox2.ItemHeight = 15;
            listBox2.Location = new Point(253, 22);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(141, 199);
            listBox2.TabIndex = 0;
            // 
            // listBox3
            // 
            listBox3.FormattingEnabled = true;
            listBox3.ItemHeight = 15;
            listBox3.Location = new Point(514, 37);
            listBox3.Name = "listBox3";
            listBox3.Size = new Size(194, 289);
            listBox3.TabIndex = 0;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(39, 256);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(141, 23);
            textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(265, 256);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(141, 23);
            textBox2.TabIndex = 1;
            // 
            // temizle
            // 
            temizle.Location = new Point(566, 351);
            temizle.Name = "temizle";
            temizle.Size = new Size(118, 49);
            temizle.TabIndex = 4;
            temizle.Text = "Temizle";
            temizle.UseVisualStyleBackColor = true;
            temizle.Click += temizle_Click;
            // 
            // askerdagit
            // 
            askerdagit.Location = new Point(172, 362);
            askerdagit.Name = "askerdagit";
            askerdagit.Size = new Size(106, 49);
            askerdagit.TabIndex = 5;
            askerdagit.Text = "Asker Dağıt";
            askerdagit.UseVisualStyleBackColor = true;
            askerdagit.Click += askerdagit_Click;
            // 
            // sehirekle
            // 
            sehirekle.Location = new Point(300, 301);
            sehirekle.Name = "sehirekle";
            sehirekle.Size = new Size(93, 33);
            sehirekle.TabIndex = 6;
            sehirekle.Text = "Şehir Ekle";
            sehirekle.UseVisualStyleBackColor = true;
            sehirekle.Click += sehirekle_Click;
            // 
            // askerekle
            // 
            askerekle.Location = new Point(75, 301);
            askerekle.Name = "askerekle";
            askerekle.Size = new Size(92, 33);
            askerekle.TabIndex = 7;
            askerekle.Text = "Asker Ekle";
            askerekle.UseVisualStyleBackColor = true;
            askerekle.Click += askerekle_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(listBox1);
            groupBox1.Controls.Add(listBox2);
            groupBox1.Controls.Add(pictureBox1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(421, 399);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            groupBox1.Text = "Veri Ekleme";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(pictureBox2);
            groupBox2.Location = new Point(469, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(319, 399);
            groupBox2.TabIndex = 9;
            groupBox2.TabStop = false;
            groupBox2.Text = "Listeleme";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-12, -13);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(806, 456);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(-469, -13);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(806, 456);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(temizle);
            Controls.Add(askerdagit);
            Controls.Add(sehirekle);
            Controls.Add(askerekle);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(listBox3);
            Controls.Add(groupBox1);
            Controls.Add(groupBox2);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBox1;
        private ListBox listBox2;
        private ListBox listBox3;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button temizle;
        private Button askerdagit;
        private Button sehirekle;
        private Button askerekle;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
    }
}
