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
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_MouseMove(object sender, MouseEventArgs e)
        {
            ranX= new Random(Guid.NewGuid().GetHashCode()).Next(1, 550);
            ranY= new Random(Guid.NewGuid().GetHashCode()).Next(1, 300);
            //控制控件改变位置
        }
    }
}
