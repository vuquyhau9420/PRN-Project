﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows;

namespace Project_Final {
    public partial class frmMain : Form {
        public frmMain() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {

        }
        private void EnabledFunctionForSpecificRole(int role) {
            button2.Show();
            button3.Show();
            button4.Show();

            if (role == 1)//Owner
            {

            }
            else if (role == 2)//Admin
           {
                button2.Enabled = false;
            }
            else if (role == 3)//Staff
           {
                button2.Enabled = false;
                button3.Enabled = false;
            }
            btnLogin.Hide();
        }
        private void btnLogin_Click(object sender, EventArgs e) {
            frmLogin frmLogin = new frmLogin();
            frmLogin.ShowDialog();

            int role = frmLogin.Role; // return the role number from frmLogin
            if (role == 1)// 1 for Owner
            {
                EnabledFunctionForSpecificRole(1);
            }
            else if (role == 2)// 2 for Admin
            {
                EnabledFunctionForSpecificRole(2);
            }
            else if (role == 3)// 3 for normal staff
            {
                EnabledFunctionForSpecificRole(3);
            }

        }
    }
}