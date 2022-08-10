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
            this.panel1 = new System.Windows.Forms.Panel();
            this.KeyPressedTimer = new System.Windows.Forms.Timer(this.components);
            this.NoteTimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 58);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(835, 459);
            this.panel1.TabIndex = 0;
            // 
            // KeyPressedTimer
            // 
            this.KeyPressedTimer.Enabled = true;
            this.KeyPressedTimer.Interval = 1;
            this.KeyPressedTimer.Tick += new System.EventHandler(this.KeyPressedTimer_Tick);
            // 
            // NoteTimer
            // 
            this.NoteTimer.Enabled = true;
            this.NoteTimer.Interval = 1;
            this.NoteTimer.Tick += new System.EventHandler(this.NoteTimer_Tick);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(835, 517);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Timer KeyPressedTimer;
        private System.Windows.Forms.Timer NoteTimer;
    }
}

