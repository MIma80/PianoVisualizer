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

        public Keys(int width, int height)
        {
            whiteKeyHeight = height;
            whiteKeyWidth = width;

            blackKeyWidth = whiteKeyWidth / 2;
            blackKeyHeight = whiteKeyHeight / 2;
        }

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


                blackKey.Text = blackKeysNotes[j % 7] + (j / 7).ToString();
                blackKey.Name = blackKeysNotes[j % 7] + (j / 7).ToString();

                //size and location
                blackKey.Size = new Size(this.blackKeyWidth, this.blackKeyHeight);
                blackKey.Location = new Point((j * whiteKeyWidth) + blackKeyWidth / 2 + whiteKeyWidth / 2 + 15, panel.Size.Height);


                blackKey.MouseDown += (sender, e) => foo(sender, e, panel);
                blackKey.MouseUp += backState;

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
                whiteKey.Name = whiteKeysNotes[i % 7] + (i / 7).ToString();
                whiteKey.Text = whiteKeysNotes[i % 7] + (i / 7).ToString();

                //size and location
                whiteKey.Size = new Size(this.whiteKeyWidth, this.whiteKeyHeight);
                whiteKey.Location = new Point(whiteKey.Location.X + (i * this.whiteKeyWidth) + 15, panel.Size.Height);


                whiteKey.MouseDown += (sender, e) => foo(sender, e, panel);
                whiteKey.MouseUp += backState;

                //
                panel.Controls.Add(whiteKey);
            }
        }

        private void backState(object sender, EventArgs e)
        {
            var btn = (Button)sender;

            if (btn.Name.Contains("#"))
                btn.BackColor = Color.Black;
            else btn.BackColor = Color.White;
        }

        public void foo(object sender, EventArgs e, Panel panel)
        {
            var btn = (Button)sender;
            btn.BackColor = Color.Blue;

            PictureBox pictureBox = new PictureBox();

            pictureBox.Name = btn.Name;
            pictureBox.Width = btn.Width;
            pictureBox.Height = btn.Height;
            pictureBox.Location = new Point(btn.Location.X, btn.Location.Y);

            pictureBox.Image = new Bitmap(pictureBox.Width, pictureBox.Height);
            Graphics graphics = Graphics.FromImage(pictureBox.Image);
            graphics.FillRectangle(Brushes.Green, 0, 0, pictureBox.Width, pictureBox.Height);


            panel.Controls.Add(pictureBox);
        }
    }
}
