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

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            var pic = sender as PictureBox;
            pic.Location = new Point(pic.Location.X + 5, pic.Location.Y);
        }
    }
}
