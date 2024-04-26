using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NugetMetroApp
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        public Form1()
        {
            InitializeComponent();
            this.StyleManager = metroStyleManager1;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void metroCheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(metroCheckBox1.Checked) 
            {
            metroComboBox1.Visible = false;
            metroScrollBar1.Visible = false;
                metroButton1.Visible = false;
             
            }
            else
            {
                metroComboBox1.Visible = true;
                metroScrollBar1.Visible = true;
                metroButton1.Visible = true;
            }
        }

        private void metroTrackBar1_Scroll(object sender, ScrollEventArgs e)
        {

        }
    }
}
