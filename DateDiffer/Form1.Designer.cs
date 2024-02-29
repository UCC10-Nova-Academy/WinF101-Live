namespace DateDiffer
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
            button1 = new Button();
            dtpStart = new DateTimePicker();
            dtpEnd = new DateTimePicker();
            button2 = new Button();
            lbSonuc = new ListBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button1.Location = new Point(587, 404);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 0;
            button1.Text = "Çıkış";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // dtpStart
            // 
            dtpStart.Location = new Point(161, 48);
            dtpStart.Name = "dtpStart";
            dtpStart.Size = new Size(300, 31);
            dtpStart.TabIndex = 1;
            // 
            // dtpEnd
            // 
            dtpEnd.CustomFormat = "dd.MM.yyyy HH:mm";
            dtpEnd.Format = DateTimePickerFormat.Custom;
            dtpEnd.Location = new Point(161, 126);
            dtpEnd.Name = "dtpEnd";
            dtpEnd.Size = new Size(300, 31);
            dtpEnd.TabIndex = 2;
            // 
            // button2
            // 
            button2.Location = new Point(161, 179);
            button2.Name = "button2";
            button2.Size = new Size(112, 34);
            button2.TabIndex = 3;
            button2.Text = "Hesapla";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // lbSonuc
            // 
            lbSonuc.FormattingEnabled = true;
            lbSonuc.ItemHeight = 25;
            lbSonuc.Location = new Point(161, 234);
            lbSonuc.Name = "lbSonuc";
            lbSonuc.Size = new Size(300, 129);
            lbSonuc.TabIndex = 4;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(711, 450);
            Controls.Add(lbSonuc);
            Controls.Add(button2);
            Controls.Add(dtpEnd);
            Controls.Add(dtpStart);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private DateTimePicker dtpStart;
        private DateTimePicker dtpEnd;
        private Button button2;
        private ListBox lbSonuc;
    }
}
