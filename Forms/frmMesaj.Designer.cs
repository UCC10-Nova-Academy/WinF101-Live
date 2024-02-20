namespace Forms
{
    partial class frmMesaj
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
            btnShow = new Button();
            label1 = new Label();
            tboxMesaj = new TextBox();
            SuspendLayout();
            // 
            // btonClose
            // 
            btonClose.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btonClose.Location = new Point(417, 200);
            btonClose.Name = "btonClose";
            btonClose.Size = new Size(112, 34);
            btonClose.TabIndex = 0;
            btonClose.Text = "Kapat";
            btonClose.UseVisualStyleBackColor = true;
            btonClose.Click += btonClose_Click;
            // 
            // btnShow
            // 
            btnShow.Location = new Point(389, 91);
            btnShow.Name = "btnShow";
            btnShow.Size = new Size(112, 34);
            btnShow.TabIndex = 6;
            btnShow.Text = "Göster";
            btnShow.UseVisualStyleBackColor = true;
            btnShow.Click += btnShow_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(47, 96);
            label1.Name = "label1";
            label1.Size = new Size(58, 25);
            label1.TabIndex = 5;
            label1.Text = "Mesaj";
            // 
            // tboxMesaj
            // 
            tboxMesaj.Location = new Point(129, 93);
            tboxMesaj.MaxLength = 20;
            tboxMesaj.Name = "tboxMesaj";
            tboxMesaj.Size = new Size(242, 31);
            tboxMesaj.TabIndex = 4;
            tboxMesaj.Text = "-- mesaj yazınız";
            tboxMesaj.MouseClick += tboxMesaj_MouseClick;
            tboxMesaj.TextChanged += tboxMesaj_TextChanged;
            // 
            // frmMesaj
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(541, 246);
            Controls.Add(btnShow);
            Controls.Add(label1);
            Controls.Add(tboxMesaj);
            Controls.Add(btonClose);
            Name = "frmMesaj";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmMesaj";
            Load += frmMesaj_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btonClose;
        private Button btnShow;
        private Label label1;
        private TextBox tboxMesaj;
    }
}