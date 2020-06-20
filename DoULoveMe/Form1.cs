using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoULoveMe
{
    public partial class Form1 : Form
    {
        
        int ranX=0, ranY=0;
        bool loveMe = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            loveMe = true;
            MessageBox.Show("I love you too ,Babe.");
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            loveMe = true;
            MessageBox.Show("I love you too ,Babe.");
            this.Close();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(loveMe==false)   MessageBox.Show("Don't you love me?  QAQ");
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            if(loveMe==false)   MessageBox.Show("Fxxk you. Go to hell.  :P");
        }

        private void button3_MouseMove(object sender, MouseEventArgs e)
        {
            ranX= new Random(Guid.NewGuid().GetHashCode()).Next(1, 300);
            ranY= new Random(Guid.NewGuid().GetHashCode()).Next(1, 550);
            //控制控件改变位置
            button3.Top = ranX;
            button3.Left = ranY;
        }
    }
}
