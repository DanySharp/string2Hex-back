using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace string2Hex
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox2.Text = tohex(textBox1.Text);

        }
      
        string Hextost(string hexSt)
        {
            
            if (hexSt == null || (hexSt.Length & 1) == 1)
            {
                // throw new ArgumentException();
                MessageBox.Show("Input Fields");
                return hexSt;
            }
            var sb = new StringBuilder();
            for (var i = 0; i < hexSt.Length; i += 2)
            {
                var hexChar = hexSt.Substring(i, 2);
                sb.Append((char)Convert.ToByte(hexChar, 16));
            }
            return sb.ToString();
        }
        public string tohex(string inp)
        {

            string uptp = string.Empty;
            char[] Value = inp.ToCharArray();
            foreach (char L in Value)
            {
                int v = Convert.ToInt32(L);
                uptp += string.Format("{0:x}", v);

            }
            return uptp;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = Hextost(textBox2.Text);
        }
    }
}
