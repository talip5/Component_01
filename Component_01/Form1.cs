using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Component_01
{
    public partial class Form1 : Form
    {
        public Color color1;
        public Form1()
        {
            InitializeComponent();
            hScrollBar1.ValueChanged+=HScrollBar1_ValueChanged;
            

        }

        private void HScrollBar1_ValueChanged(object sender, EventArgs e)
        {
            label1.Text = hScrollBar1.Value.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            groupBox1.BackColor = Color.Orange;
            groupBox1.Visible = false;
            
            //label1.Text = hScrollBar1.Value.ToString();
            
            checkBox1.Checked = false;
            
            color1 = label1.ForeColor;
            label2.BackColor = Color.Orange; 
            label2.AutoSize = false;
            label2.Width = 150;
            label2.Height = 50;
            textBox1.Focus();
            //Font = new Font(Font.FontFamily, 12);
            //Font = new Font(Font, FontStyle.Bold);
           label1.Font = new Font(label1.Font, FontStyle.Bold);
            label1.Font = new Font(label1.Font.FontFamily, 18);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //groupBox1.Visible=true;
            //groupBox1.Text = "";
            //label1.Text = numericUpDown1.Value.ToString();
            //label1.Text = e.ToString();
            label1.AutoSize = false;
            label1.Width = 100;
            label1.Height = 50;
            label2.Font = new Font(label2.Font.FontFamily,18);
            
        }

        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            //label1.Text= e.NewValue.ToString();
            //numericUpDown1.Value = e.NewValue;
            label1.Text += numericUpDown1.Value.ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                label1.ForeColor = color1;
                label1.Text ="OK";
                label1.BackColor = Color.Orange;
               
            }
            else
            { 
                label1.Text = "No";
                label1.BackColor = Color.DarkBlue;
                label1.ForeColor = Color.White;
            }
           //if(e.Equals(checkBox1.Checked))
           // {
           //     label1.Text =checkBox1.Checked.ToString();
           // }
        }
    }
}
