namespace Forms
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
            menuStrip1 = new MenuStrip();
            comboBoxToolStripMenuItem = new ToolStripMenuItem();
            mesajFormToolStripMenuItem = new ToolStripMenuItem();
            comboboxFormToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            programCikisToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // btonExit
            // 
            btonExit.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btonExit.Location = new Point(593, 290);
            btonExit.Margin = new Padding(2, 2, 2, 2);
            btonExit.Name = "btonExit";
            btonExit.Size = new Size(78, 20);
            btonExit.TabIndex = 0;
            btonExit.Text = "Çıkış";
            btonExit.UseVisualStyleBackColor = true;
            btonExit.Click += button1_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { comboBoxToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(4, 1, 0, 1);
            menuStrip1.Size = new Size(680, 24);
            menuStrip1.TabIndex = 5;
            menuStrip1.Text = "menuStrip1";
            // 
            // comboBoxToolStripMenuItem
            // 
            comboBoxToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { mesajFormToolStripMenuItem, comboboxFormToolStripMenuItem, toolStripSeparator1, programCikisToolStripMenuItem });
            comboBoxToolStripMenuItem.Name = "comboBoxToolStripMenuItem";
            comboBoxToolStripMenuItem.Size = new Size(65, 22);
            comboBoxToolStripMenuItem.Text = "Program";
            // 
            // mesajFormToolStripMenuItem
            // 
            mesajFormToolStripMenuItem.Name = "mesajFormToolStripMenuItem";
            mesajFormToolStripMenuItem.Size = new Size(180, 22);
            mesajFormToolStripMenuItem.Text = "Mesaj Form";
            mesajFormToolStripMenuItem.Click += mesajFormToolStripMenuItem_Click;
            // 
            // comboboxFormToolStripMenuItem
            // 
            comboboxFormToolStripMenuItem.Name = "comboboxFormToolStripMenuItem";
            comboboxFormToolStripMenuItem.Size = new Size(180, 22);
            comboboxFormToolStripMenuItem.Text = "Combobox Form";
            comboboxFormToolStripMenuItem.Click += comboboxFormToolStripMenuItem_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(177, 6);
            // 
            // programCikisToolStripMenuItem
            // 
            programCikisToolStripMenuItem.Name = "programCikisToolStripMenuItem";
            programCikisToolStripMenuItem.Size = new Size(180, 22);
            programCikisToolStripMenuItem.Text = "Program Çıkış";
            programCikisToolStripMenuItem.Click += programCikisToolStripMenuItem_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(680, 317);
            ControlBox = false;
            Controls.Add(btonExit);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(2, 2, 2, 2);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            WindowState = FormWindowState.Maximized;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btonExit;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem comboBoxToolStripMenuItem;
        private ToolStripMenuItem comboboxFormToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem programCikisToolStripMenuItem;
        private ToolStripMenuItem mesajFormToolStripMenuItem;
    }
}
