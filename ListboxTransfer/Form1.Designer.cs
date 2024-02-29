namespace ListboxTransfer
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
            lboxSehirler = new ListBox();
            button1 = new Button();
            tboxSehir = new TextBox();
            button2 = new Button();
            button3 = new Button();
            lboxOburu = new ListBox();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            SuspendLayout();
            // 
            // lboxSehirler
            // 
            lboxSehirler.FormattingEnabled = true;
            lboxSehirler.ItemHeight = 25;
            lboxSehirler.Items.AddRange(new object[] { "Ankara", "İstanbul", "İzmir", "Eskişehir", "Muğla", "Bursa" });
            lboxSehirler.Location = new Point(32, 113);
            lboxSehirler.Name = "lboxSehirler";
            lboxSehirler.SelectionMode = SelectionMode.MultiExtended;
            lboxSehirler.Size = new Size(150, 179);
            lboxSehirler.TabIndex = 0;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button1.Location = new Point(535, 345);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 1;
            button1.Text = "Çıkış";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // tboxSehir
            // 
            tboxSehir.Location = new Point(32, 24);
            tboxSehir.Name = "tboxSehir";
            tboxSehir.Size = new Size(150, 31);
            tboxSehir.TabIndex = 2;
            // 
            // button2
            // 
            button2.Location = new Point(32, 61);
            button2.Name = "button2";
            button2.Size = new Size(112, 34);
            button2.TabIndex = 3;
            button2.Text = "Ekle";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(32, 310);
            button3.Name = "button3";
            button3.Size = new Size(112, 34);
            button3.TabIndex = 4;
            button3.Text = "Sil";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // lboxOburu
            // 
            lboxOburu.FormattingEnabled = true;
            lboxOburu.ItemHeight = 25;
            lboxOburu.Location = new Point(324, 113);
            lboxOburu.Name = "lboxOburu";
            lboxOburu.SelectionMode = SelectionMode.MultiExtended;
            lboxOburu.Size = new Size(157, 179);
            lboxOburu.TabIndex = 5;
            // 
            // button4
            // 
            button4.Location = new Point(194, 130);
            button4.Name = "button4";
            button4.Size = new Size(112, 34);
            button4.TabIndex = 6;
            button4.Text = ">";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(194, 170);
            button5.Name = "button5";
            button5.Size = new Size(112, 34);
            button5.TabIndex = 7;
            button5.Text = ">>";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.Location = new Point(194, 210);
            button6.Name = "button6";
            button6.Size = new Size(112, 34);
            button6.TabIndex = 8;
            button6.Text = "<";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button7
            // 
            button7.Location = new Point(194, 250);
            button7.Name = "button7";
            button7.Size = new Size(112, 34);
            button7.TabIndex = 9;
            button7.Text = "<<";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(659, 391);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(lboxOburu);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(tboxSehir);
            Controls.Add(button1);
            Controls.Add(lboxSehirler);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lboxSehirler;
        private Button button1;
        private TextBox tboxSehir;
        private Button button2;
        private Button button3;
        private ListBox lboxOburu;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
    }
}
