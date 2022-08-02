﻿using System;
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

        private string[] whiteKeysNotes = { "C", "D", "E", "F", "G", "A", "B" };
        private string[] blackKeysNotes = { "C#", "D#", string.Empty, "F#", "G#", "A#", string.Empty };

        public void CreateKeys(Panel panel)
        {
            for (int i = 0, j = 0; i < 36; i++, j++)
            {
                //skips unwanted black keys
                if (blackKeysNotes[j % 7] == string.Empty)
                {
                    i--;
                    continue;
                }

                Button blackKey = new Button();
                
                //color
                blackKey.BackColor = Color.Black;
                blackKey.ForeColor = Color.White;


                blackKey.Text = blackKeysNotes[j % 7];
                blackKey.Name = blackKeysNotes[j % 7];

                //size and location
                blackKey.Size = new Size(this.blackKeyWidth, this.blackKeyHeight);
                blackKey.Location = new Point((j * whiteKeyWidth) + blackKeyWidth / 2 + whiteKeyWidth / 2 + 15, blackKey.Location.Y);

                //
                panel.Controls.Add(blackKey);
            }
            for (int i = 0; i < 52; i++)
            {
                Button whiteKey = new Button();
                
                //color
                whiteKey.BackColor = Color.White;
                whiteKey.ForeColor = Color.Black;

                //name and text
                whiteKey.Name = whiteKeysNotes[i % 7];
                whiteKey.Text = whiteKeysNotes[i % 7];

                //size and location
                whiteKey.Size = new Size(this.whiteKeyWidth, this.whiteKeyHeight);
                whiteKey.Location = new Point(whiteKey.Location.X + (i * this.whiteKeyWidth) + 15, whiteKey.Location.Y);

                //
                panel.Controls.Add(whiteKey);
            }
        }
    }
}
