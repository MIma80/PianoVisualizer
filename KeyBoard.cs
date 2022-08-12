using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace Piano
{

    internal class KeyBoard
    {
        public List<Key> Keys = new List<Key>();
        

        static private int speed = 10;
        static public int Speed
        {
            get { return speed; }
            set { speed = value > 360? 360: speed; }
        }
        public class Key
        {
            #region MouseEvents
            #region Leave and Enter events
            private void MouseEnterEvent(object sender, EventArgs e, Key key)
            {
                key.Notes.Add(new Key.Note());
            }
            private void MouseLeaveEvent(object sender, EventArgs e, Key key)
            {
                key.Notes.Last().isDone = true;
            }
            #endregion

            #region Down and Up events
            private void MouseDownEvent(object sender, MouseEventArgs e, Key key)
            {
                key.Notes.Add(new Key.Note());
            }
            private void MouseUpEvent(object sender, MouseEventArgs e, Key key)
            {
                key.Notes.Last().isDone = true;
            }
            #endregion
            #endregion

            private string[] whiteKeysNotes = { "C", "D", "E", "F", "G", "A", "B" };
            private string[] blackKeysNotes = { "C#", "D#", string.Empty, "F#", "G#", "A#", string.Empty };
            public Button button;

            public List<Note> Notes = new List<Note>();

            public static int Count { get; private set; }
            public string Name { get; internal set; }
            public int width { get; set; }
            public int height { get; set; }

            public class Note
            {
                public bool isDone { get; set; } = false;
                public int scale { get; private set; } = 0;
                public int locationY { get; private set; } = 0;
                
                public void Move() { locationY += Speed; }
                public void Scale() { scale += Speed; }
            }

            public Key(int width, int height, int x)
            {
                Count++;
                this.width = width;
                this.height = height;
                Name = whiteKeysNotes[(Count - 1) % 7] + (((Count - 1) / 7) + 1).ToString();

                button = new Button();
                button.BackColor = Color.White;
                button.ForeColor = Color.Black;
                button.Name = Name;
                button.Text = Name;
                button.Size = new Size(width, height);
                button.AutoSize = true;
                button.Location = new Point(0 + ((Count - 1) * width), 0);

                button.MouseDown += (sender, e) => MouseDownEvent(sender, e, this);
                button.MouseUp += (sender, e) => MouseUpEvent(sender, e, this);

                button.MouseEnter += (sender, e) => MouseEnterEvent(sender, e, this);
                button.MouseLeave += (sender, e) => MouseLeaveEvent(sender, e, this);
            }
        }

        public KeyBoard(int widthOfKey, int heightOfKey, int numberOfKeys, Panel keyBoardPanel)
        {
            for (int i = 0; i < numberOfKeys; i++)
            {
                Key key = new Key(widthOfKey, heightOfKey, i);
                Keys.Add(key);
            }
            keyBoardPanel.Controls.AddRange(Keys.Select(x => x.button).ToArray());
        }
    }
}
