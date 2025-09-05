using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lotto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            // if (str == null || str.Length == 0 || str == string.Empty || str == "") return;

            string str = string.Empty;
            GetNum gn = new GetNum();
            gn.Gen();
            str = gn.GetStr();
            textBox1.Text = str;
        }
    }
}
