using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AutoItX3Lib;

namespace AutoIT
{
    public partial class Form1 : Form
    {
        AutoItX3 au3 = new AutoItX3();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            au3.MouseMove(0, 0, 10);
        }
    }
}
