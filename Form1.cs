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
        KeyBoard keyBoard;
        Graphics graphics;


        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            keyBoard = new KeyBoard(37, 220, 52, keyBoardPanel, pictureBoxPanel);
        }

        private void KeyPressedTimer_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < 52; i++)
            {
                keyBoard.Keys[i].pictureBox.Image = new Bitmap(keyBoard.Keys[i].pictureBox.Width, keyBoard.Keys[i].pictureBox.Height);
                graphics = Graphics.FromImage(keyBoard.Keys[i].pictureBox.Image);
                if (keyBoard.Keys[i].Notes.Count > 0)
                {
                    for (int j = 0; j < keyBoard.Keys[i].Notes.Count; j++)
                    {
                        keyBoard.Keys[i].Notes[j].Move();
                        graphics.FillRectangle(Brushes.Green, 0, keyBoard.Keys[i].pictureBox.Height - keyBoard.Keys[i].Notes[j].locationY, keyBoard.Keys[i].pictureBox.Width, keyBoard.Keys[i].Notes[j].scale);
                        if(keyBoard.Keys[i].Notes[j].locationY - keyBoard.Keys[i].Notes[j].scale > keyBoard.Keys[i].pictureBox.Height)
                        {
                            keyBoard.Keys[i].Notes.Remove(keyBoard.Keys[i].Notes[j]);
                        }
                    }
                }
            }
        }

        private void NoteTimer_Tick(object sender, EventArgs e)
        {
            foreach(var i in keyBoard.Keys)
            {
                foreach(var j in i.Notes)
                {
                    if (!j.isDone)
                        j.Scale();
                }
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
