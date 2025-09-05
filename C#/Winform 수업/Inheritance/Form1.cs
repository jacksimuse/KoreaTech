﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inheritance
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == string.Empty || textBox2.Text == string.Empty) return;
            Person p = new Person(textBox1.Text, int.Parse(textBox2.Text));

            p.Info();
            p.Info(1.23, 4.56);
            p.Info("한기대");

            p.Run(100);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == string.Empty || textBox2.Text == string.Empty 
                || textBox3.Text == string.Empty) return;

            TaxiDriver td = new TaxiDriver(textBox1.Text, int.Parse(textBox2.Text), textBox3.Text);

            td.CarInfo(td.CarNum, "포르쉐");
            td.Run(1000);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (textBox1.Text == string.Empty || textBox2.Text == string.Empty) return;

            Worker w = new Worker(textBox1.Text, int.Parse(textBox2.Text), checkBox1.Checked);

            w.ShowWorkplace(w.isWork);
            w.Run(5);
        }
    }
}
