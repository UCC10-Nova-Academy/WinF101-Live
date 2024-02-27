namespace HareketliButon
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
            btonExit = new Button();
            btonKutu = new Button();
            btonA = new Button();
            btonW = new Button();
            btonD = new Button();
            btonS = new Button();
            SuspendLayout();
            // 
            // btonExit
            // 
            btonExit.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btonExit.Location = new Point(716, 491);
            btonExit.Name = "btonExit";
            btonExit.Size = new Size(112, 34);
            btonExit.TabIndex = 0;
            btonExit.Text = "Çıkış";
            btonExit.UseVisualStyleBackColor = true;
            btonExit.Click += btonExit_Click;
            // 
            // btonKutu
            // 
            btonKutu.BackColor = Color.FromArgb(255, 128, 0);
            btonKutu.Location = new Point(479, 211);
            btonKutu.Name = "btonKutu";
            btonKutu.Size = new Size(54, 49);
            btonKutu.TabIndex = 1;
            btonKutu.UseVisualStyleBackColor = false;
            // 
            // btonA
            // 
            btonA.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btonA.Location = new Point(31, 377);
            btonA.Name = "btonA";
            btonA.Size = new Size(51, 51);
            btonA.TabIndex = 2;
            btonA.Text = "A";
            btonA.UseVisualStyleBackColor = true;
            btonA.Click += btonA_Click;
            // 
            // btonW
            // 
            btonW.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btonW.Location = new Point(88, 317);
            btonW.Name = "btonW";
            btonW.Size = new Size(51, 51);
            btonW.TabIndex = 3;
            btonW.Text = "W";
            btonW.UseVisualStyleBackColor = true;
            btonW.Click += btonW_Click;
            // 
            // btonD
            // 
            btonD.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btonD.Location = new Point(145, 377);
            btonD.Name = "btonD";
            btonD.Size = new Size(51, 51);
            btonD.TabIndex = 4;
            btonD.Text = "D";
            btonD.UseVisualStyleBackColor = true;
            btonD.Click += btonD_Click;
            // 
            // btonS
            // 
            btonS.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btonS.Location = new Point(88, 377);
            btonS.Name = "btonS";
            btonS.Size = new Size(51, 51);
            btonS.TabIndex = 5;
            btonS.Text = "S";
            btonS.UseVisualStyleBackColor = true;
            btonS.Click += btonS_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(837, 534);
            Controls.Add(btonS);
            Controls.Add(btonD);
            Controls.Add(btonW);
            Controls.Add(btonA);
            Controls.Add(btonKutu);
            Controls.Add(btonExit);
            KeyPreview = true;
            Name = "Form1";
            Text = "Form1";
            KeyDown += Form1_KeyDown;
            ResumeLayout(false);
        }

        #endregion

        private Button btonExit;
        private Button btonKutu;
        private Button btonA;
        private Button btonW;
        private Button btonD;
        private Button btonS;
    }
}
