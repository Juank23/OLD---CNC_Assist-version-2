﻿using System.Diagnostics;
using System.Windows.Forms;

namespace CNCImporterGkode
{
    public partial class About : Form
    {
        public About()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("http://selenur.ru");
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://money.yandex.ru/to/41001112863318");

        }
    }
}
