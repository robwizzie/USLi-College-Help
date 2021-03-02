﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Custom_Browser
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            string WebPage = txtAddress.Text.Trim();

            webBrowser1.Navigate(WebPage);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if(webBrowser1.CanGoBack)
            {
                webBrowser1.GoBack();

            }
        }

        private void btnForward_Click(object sender, EventArgs e)
        {
            if(webBrowser1.CanGoForward)
            {
                webBrowser1.GoForward();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            webBrowser1.Stop();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            webBrowser1.GoHome();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            webBrowser1.Refresh();
        }

        private void btnBack_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(btnBack, "Undo");
        }

        private void btnForward_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(btnForward, "Redo");
        }

        private void btnHome_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(btnHome, "Home");
        }

        private void btnClose_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(btnClose, "Close");
        }

        private void btnRefresh_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(btnRefresh, "Refresh");
        }
    }
}
