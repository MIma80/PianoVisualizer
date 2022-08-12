namespace Piano
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.keyBoardPanel = new System.Windows.Forms.Panel();
            this.KeyPressedTimer = new System.Windows.Forms.Timer(this.components);
            this.NoteTimer = new System.Windows.Forms.Timer(this.components);
            this.pictureBoxPanel = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // keyBoardPanel
            // 
            this.keyBoardPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.keyBoardPanel.Location = new System.Drawing.Point(0, 297);
            this.keyBoardPanel.Name = "keyBoardPanel";
            this.keyBoardPanel.Size = new System.Drawing.Size(835, 220);
            this.keyBoardPanel.TabIndex = 0;
            this.keyBoardPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // KeyPressedTimer
            // 
            this.KeyPressedTimer.Enabled = true;
            this.KeyPressedTimer.Interval = 10;
            this.KeyPressedTimer.Tick += new System.EventHandler(this.KeyPressedTimer_Tick);
            // 
            // NoteTimer
            // 
            this.NoteTimer.Enabled = true;
            this.NoteTimer.Interval = 10;
            this.NoteTimer.Tick += new System.EventHandler(this.NoteTimer_Tick);
            // 
            // pictureBoxPanel
            // 
            this.pictureBoxPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pictureBoxPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pictureBoxPanel.Location = new System.Drawing.Point(0, -403);
            this.pictureBoxPanel.Name = "pictureBoxPanel";
            this.pictureBoxPanel.Size = new System.Drawing.Size(835, 700);
            this.pictureBoxPanel.TabIndex = 1;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(835, 517);
            this.Controls.Add(this.pictureBoxPanel);
            this.Controls.Add(this.keyBoardPanel);
            this.Name = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Panel keyBoardPanel;
        private System.Windows.Forms.Timer KeyPressedTimer;
        private System.Windows.Forms.Timer NoteTimer;
        private System.Windows.Forms.Panel pictureBoxPanel;
    }
}

