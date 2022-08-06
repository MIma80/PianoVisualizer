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
        private PianoKeys keys;
        public Form1()
        {
            InitializeComponent();

            panel1.Controls.Clear();
            keys = new PianoKeys(KeysCount.Value, 200);
            keys.CreateKeys(panel1);
        }

        private void KeysCount_ValueChanged(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            keys = new PianoKeys(KeysCount.Value, 200);
            keys.CreateKeys(panel1);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            foreach(Control c in panel1.Controls)
            {
                if(c.GetType() == typeof(PictureBox))
                {
                    if (c.Location.Y < 100)
                        panel1.Controls.Remove(c);
                    c.Location = new Point(c.Location.X, c.Location.Y - 5);
                }
            }
        }
    }
}
