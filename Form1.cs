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
        public Form1()
        {
            InitializeComponent();

            Keys keys = new Keys();

            keys.CreateKeys(panel1, 10);
        }

        private void KeysCount_ValueChanged(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            Keys keys = new Keys();

            keys.whiteKeyHeight = 120;
            keys.whiteKeyWidth = 60;

            keys.blackKeyWidth = keys.whiteKeyWidth / 2;
            keys.blackKeyHeight = keys.whiteKeyHeight / 2;

            keys.CreateKeys(panel1, KeysCount.Value);
        }
    }
}
