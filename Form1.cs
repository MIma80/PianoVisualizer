using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Piano
{
    public partial class Form1 : Form
    {
        private Keys keys;
        public Form1()
        {
            InitializeComponent();

            keys = new Keys(36, 200);
            keys.CreateKeys(panel1);
        }

        private void KeysCount_ValueChanged(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            keys = new Keys(KeysCount.Value, 200);
            keys.CreateKeys(panel1);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            panel1.Size = new Size(1000, 300);
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            foreach(Control c in panel1.Controls)
            {
                if(c.GetType() == typeof(PictureBox))
                    c.Location = new Point(c.Location.X, c.Location.Y - 5);
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
