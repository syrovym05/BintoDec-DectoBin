using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BintoDec_DectoBin
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.CenterToScreen();
            this.ShowIcon = false;
            this.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(BintoDec(numericUpDown1.Value.ToString()));
        }

        private void button2_Click(object sender, EventArgs e)
        {           
             listBox1.Items.Add(DectoBin((int)numericUpDown1.Value));           
        }



        private int BintoDec(string s)//1101
        {           
            int vys = 0;            

            for (int i = 0; i < s.Length; i++)
            {
                int znak = (s[i] - '0');
                if (znak != 0 && znak != 1) return int.Parse(s);

                if (znak == 1)
                {
                    vys += (int)Math.Pow(2, s.Length - i - 1);
                }
            }

            return vys;
        }

       

        private string DectoBin(int i)
        {
            StringBuilder vys = new StringBuilder();            

            while(i > 0)
            {
                vys.Insert(0, (i % 2).ToString());               
                i /= 2;
            }

            return vys + "";

        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }
    }
}
