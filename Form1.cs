﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AttendanceV1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            timerAtNow.Start();
        }

        private void timerAtNow_Tick(object sender, EventArgs e)
        {
            labelCurrentDate.Text = DateTime.Now.ToLongDateString();
            labelCurrentTime.Text = DateTime.Now.ToLongTimeString();
        }
    }
}
