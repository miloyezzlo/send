using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1
{
    public partial class Form1 : Form
    {
        private int x = 12, y = 12;
        private Button[,] buttons = new Button[3, 3];
        private int p;
        public Form1()
        {
            InitializeComponent();
            this.Height = 700;
            this.Width = 900;
            this.MaximizeBox= false;
            p = 1;
            label1.Text = "ход 1 игрока";
            for (int i = 0; i < buttons.Length / 3; i++)
            {
                for (int j = 0; j < buttons.Length / 3; j++)
                {
                    buttons[i, j] = new Button();
                    buttons[i, j].Size = new Size(143, 139);
                }
            }
            setButtons();
        }
        private void setButtons()
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    buttons[i, j].Location = new Point(12 + 149 * j, 12 + 145 * i);
                    buttons[i, j].Click += button1_Click;
                    buttons[i, j].Font = new Font(new FontFamily("Microsoft Sans Serif"), 80);
                    buttons[i, j].Text = "";
                    this.Controls.Add(buttons[i, j]);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            switch(p)
            {
                case 1: 
                    sender.GetType().GetProperty("Text").SetValue(sender, "x");
                    p = 0;
                    label1.Text = "ход 2 игрока";
                    break;  
                case 0:
                    sender.GetType().GetProperty("Text").SetValue(sender, "o");
                    p = 1;
                    label1.Text = "ход 1 игрока";
                    break;
            }
            sender.GetType().GetProperty("Enabled").SetValue(sender, false);
            checkWin();
        }
        private void checkWin()
        {
            if (buttons[0, 0].Text == buttons[0, 1].Text && buttons[0, 1].Text == buttons[0, 2].Text)
            {

                if (buttons[0, 0].Text != "")
                {
                    MessageBox.Show("Вы победили!");
                    return;
                }
            }
            if (buttons[1, 0].Text == buttons[1, 1].Text && buttons[1, 1].Text == buttons[1, 2].Text)
            {
                if (buttons[1, 0].Text != "")
                    MessageBox.Show("Вы победили!");
            }
            if (buttons[2, 0].Text == buttons[2, 1].Text && buttons[2, 1].Text == buttons[2, 2].Text)
            {
                if (buttons[2, 0].Text != "")
                    MessageBox.Show("Вы победили!");
            }
            if (buttons[0, 0].Text == buttons[1, 0].Text && buttons[1, 0].Text == buttons[2, 0].Text)
            {
                if (buttons[0, 0].Text != "")
                    MessageBox.Show("Вы победили!");
            }
            if (buttons[0, 1].Text == buttons[1, 1].Text && buttons[1, 1].Text == buttons[2, 1].Text)
            {
                if (buttons[0, 1].Text != "")
                    MessageBox.Show("Вы победили!");
            }
            if (buttons[0, 2].Text == buttons[1, 2].Text && buttons[1, 2].Text == buttons[2, 2].Text)
            {
                if (buttons[0, 2].Text != "")
                    MessageBox.Show("Вы победили!");
            }
            if (buttons[0, 0].Text == buttons[1, 1].Text && buttons[1, 1].Text == buttons[2, 2].Text)
            {
                if (buttons[0, 0].Text != "")
                    MessageBox.Show("Вы победили!");
            }
            if (buttons[2, 0].Text == buttons[1, 1].Text && buttons[1, 1].Text == buttons[0, 2].Text)
            {
                if (buttons[2, 0].Text != "")
                    MessageBox.Show("Вы победили!");
            }
            //else if((buttons[0, 0].Text != buttons[0, 1].Text && buttons[0, 1].Text != buttons[0, 2].Text)&& (buttons[1, 0].Text != buttons[1, 1].Text && buttons[1, 1].Text != buttons[1, 2].Text)&& (buttons[2, 0].Text != buttons[2, 1].Text && buttons[2, 1].Text != buttons[2, 2].Text)&& (buttons[0, 0].Text != buttons[1, 0].Text && buttons[1, 0].Text != buttons[2, 0].Text)&& (buttons[0, 1].Text != buttons[1, 1].Text && buttons[1, 1].Text != buttons[2, 1].Text)&& (buttons[0, 2].Text != buttons[1, 2].Text && buttons[1, 2].Text != buttons[2, 2].Text)&& (buttons[0, 0].Text != buttons[1, 1].Text && buttons[1, 1].Text != buttons[2, 2].Text)&& (buttons[2, 0].Text != buttons[1, 1].Text && buttons[1, 1].Text != buttons[0, 2].Text))
            //{
               // if((buttons[1, 0].Text != "")&& (buttons[2, 0].Text != "") && (buttons[0, 0].Text != "")&& (buttons[0, 1].Text != "")&& (buttons[0, 2].Text != "")&& (buttons[0, 0].Text != "")&& (buttons[2, 0].Text != ""))
               // MessageBox.Show("Ничья!");
           // }
            
                
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    buttons[i, j].Text = "";
                    buttons[i, j].Enabled = true;
                }
            }
        }
    }
}
