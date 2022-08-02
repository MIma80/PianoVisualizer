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

            keys = new Keys();
            keys.whiteKeyWidth = 36;
            keys.whiteKeyHeight = 190;

            keys.blackKeyWidth = keys.whiteKeyWidth / 2;
            keys.blackKeyHeight = keys.whiteKeyHeight / 2;
            keys.CreateKeys(panel1);
        }

        private void KeysCount_ValueChanged(object sender, EventArgs e)
        {
            panel1.Controls.Clear();

            keys.whiteKeyWidth = KeysCount.Value;
            keys.blackKeyWidth = keys.whiteKeyWidth / 2;
            keys.whiteKeyHeight = 200;

            keys.CreateKeys(panel1);
        }
    }
}
