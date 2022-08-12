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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // keyBoardPanel
            // 
            this.keyBoardPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.keyBoardPanel.Location = new System.Drawing.Point(0, 302);
            this.keyBoardPanel.Name = "keyBoardPanel";
            this.keyBoardPanel.Size = new System.Drawing.Size(888, 220);
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
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(888, 412);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(888, 522);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.keyBoardPanel);
            this.Name = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Panel keyBoardPanel;
        private System.Windows.Forms.Timer KeyPressedTimer;
        private System.Windows.Forms.Timer NoteTimer;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

