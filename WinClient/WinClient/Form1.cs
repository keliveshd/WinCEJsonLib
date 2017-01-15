﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WinClient.connectLib;

namespace WinClient
{
    public partial class Form1 : Form
    {
        private string baseAddress = "http://localhost:51127/Service1.svc";

        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// GetリクエストでJSONを取得する
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            var url = string.Format("{0}/SendData", baseAddress);
            this.textBox1.Text = HttpConnectLib.Get(url);
        }

        /// <summary>
        /// テキストボックスの値をPOSTリクエストで送信する
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            var url = string.Format("{0}/GetDataCount", baseAddress);
            this.label1.Text = HttpConnectLib.Post(url, this.textBox1.Text);
        }
    }
}