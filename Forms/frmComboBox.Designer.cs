namespace Forms
{
    partial class frmComboBox
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
            btonClose = new Button();
            cboxSayilar = new ComboBox();
            label1 = new Label();
            button1 = new Button();
            tboxAdet = new TextBox();
            label2 = new Label();
            SuspendLayout();
            // 
            // btonClose
            // 
            btonClose.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btonClose.Location = new Point(257, 288);
            btonClose.Name = "btonClose";
            btonClose.Size = new Size(112, 34);
            btonClose.TabIndex = 0;
            btonClose.Text = "Kapat";
            btonClose.UseVisualStyleBackColor = true;
            btonClose.Click += btonClose_Click;
            // 
            // cboxSayilar
            // 
            cboxSayilar.FormattingEnabled = true;
            cboxSayilar.Location = new Point(169, 188);
            cboxSayilar.Name = "cboxSayilar";
            cboxSayilar.Size = new Size(182, 33);
            cboxSayilar.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(64, 191);
            label1.Name = "label1";
            label1.Size = new Size(63, 25);
            label1.TabIndex = 2;
            label1.Text = "Sayılar";
            // 
            // button1
            // 
            button1.Location = new Point(169, 120);
            button1.Name = "button1";
            button1.Size = new Size(182, 34);
            button1.TabIndex = 3;
            button1.Text = "Comboyu Oluştur";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // tboxAdet
            // 
            tboxAdet.Location = new Point(169, 53);
            tboxAdet.Name = "tboxAdet";
            tboxAdet.Size = new Size(54, 31);
            tboxAdet.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(67, 57);
            label2.Name = "label2";
            label2.Size = new Size(50, 25);
            label2.TabIndex = 5;
            label2.Text = "Adet";
            // 
            // frmComboBox
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(381, 334);
            Controls.Add(label2);
            Controls.Add(tboxAdet);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(cboxSayilar);
            Controls.Add(btonClose);
            Name = "frmComboBox";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmComboBox";
            Load += frmComboBox_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btonClose;
        private ComboBox cboxSayilar;
        private Label label1;
        private Button button1;
        private TextBox tboxAdet;
        private Label label2;
    }
}