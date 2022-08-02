using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace Piano
{
    internal class Keys
    {
        public int blackKeyWidth { get; set; }
        public int blackKeyHeight { get; set; }

        public int whiteKeyWidth { get; set; }
        public int whiteKeyHeight { get; set; }

        public void CreateKeys(Panel panel, int count)
        {
            int blackKeyCount = count;
            for (int i = 0; i < blackKeyCount; i++)
            {
                if (i % 7 == 0 && i != 0)
                    continue;

                Button blackKey = new Button();
                blackKey.BackColor = Color.Black;
                blackKey.ForeColor = Color.White;
                blackKey.Size = new Size(this.blackKeyWidth, this.blackKeyHeight);
                int B = (i * whiteKeyWidth) + blackKeyWidth / 2 + whiteKeyWidth / 2;
                blackKey.Location = new Point(B, blackKey.Location.Y);
                panel.Controls.Add(blackKey);
            }
            for (int i = 0; i < count; i++)
            {
                Button whiteKey = new Button();
                whiteKey.BackColor = Color.White;
                whiteKey.ForeColor = Color.Black;
                whiteKey.Size = new Size(this.whiteKeyWidth, this.whiteKeyHeight);
                int B = whiteKey.Location.X + (i * this.whiteKeyWidth);
                whiteKey.Location = new Point(B, whiteKey.Location.Y);
                panel.Controls.Add(whiteKey);
            }
        }
    }
}
