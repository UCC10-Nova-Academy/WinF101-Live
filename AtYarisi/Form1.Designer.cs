namespace AtYarisi
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            pictureBox1 = new PictureBox();
            label1 = new Label();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            label2 = new Label();
            button1 = new Button();
            btonAt1 = new Button();
            btonAt2 = new Button();
            btonAt3 = new Button();
            button2 = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.ButtonFace;
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Location = new Point(36, 29);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(988, 67);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(1030, 123);
            label1.Name = "label1";
            label1.Size = new Size(51, 25);
            label1.TabIndex = 1;
            label1.Text = "BİTİŞ";
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = SystemColors.ButtonFace;
            pictureBox2.BorderStyle = BorderStyle.FixedSingle;
            pictureBox2.Location = new Point(36, 102);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(988, 67);
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = SystemColors.ButtonFace;
            pictureBox3.BorderStyle = BorderStyle.FixedSingle;
            pictureBox3.Location = new Point(36, 175);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(988, 67);
            pictureBox3.TabIndex = 3;
            pictureBox3.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(36, 274);
            label2.Name = "label2";
            label2.Size = new Size(85, 25);
            label2.TabIndex = 4;
            label2.Text = "Seçiminiz";
            // 
            // button1
            // 
            button1.Location = new Point(781, 274);
            button1.Name = "button1";
            button1.Size = new Size(243, 34);
            button1.TabIndex = 5;
            button1.Text = "Yarış Başlasın";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // btonAt1
            // 
            btonAt1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btonAt1.Image = (Image)resources.GetObject("btonAt1.Image");
            btonAt1.Location = new Point(36, 29);
            btonAt1.Name = "btonAt1";
            btonAt1.Size = new Size(85, 67);
            btonAt1.TabIndex = 6;
            btonAt1.Text = "1";
            btonAt1.UseVisualStyleBackColor = true;
            btonAt1.Click += btonAt1_Click;
            // 
            // btonAt2
            // 
            btonAt2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btonAt2.Image = Properties.Resources.At;
            btonAt2.Location = new Point(36, 102);
            btonAt2.Name = "btonAt2";
            btonAt2.Size = new Size(85, 67);
            btonAt2.TabIndex = 7;
            btonAt2.Text = "2";
            btonAt2.UseVisualStyleBackColor = true;
            btonAt2.Click += btonAt2_Click;
            // 
            // btonAt3
            // 
            btonAt3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btonAt3.Image = Properties.Resources.At;
            btonAt3.Location = new Point(36, 175);
            btonAt3.Name = "btonAt3";
            btonAt3.Size = new Size(85, 67);
            btonAt3.TabIndex = 8;
            btonAt3.Text = "3";
            btonAt3.UseVisualStyleBackColor = true;
            btonAt3.Click += btonAt3_Click;
            // 
            // button2
            // 
            button2.Location = new Point(1030, 375);
            button2.Name = "button2";
            button2.Size = new Size(112, 34);
            button2.TabIndex = 9;
            button2.Text = "Çıkış";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(1154, 421);
            Controls.Add(button2);
            Controls.Add(btonAt3);
            Controls.Add(btonAt2);
            Controls.Add(btonAt1);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "At Yarışı";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private Label label2;
        private Button button1;
        private Button btonAt1;
        private Button btonAt2;
        private Button btonAt3;
        private Button button2;
        private System.Windows.Forms.Timer timer1;
    }
}
