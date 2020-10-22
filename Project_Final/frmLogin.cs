using Project_Final.Ado;
using Project_Final.Bussiness;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Final
{
    public partial class frmLogin : Form
    {
        public int Role { get; set; }

        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnSumbit_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            //Show error dialog whether 1 or 2 field is empty
            if (username.Equals("") || password.Equals(""))
            {
                MessageBox.Show("Please input all the field !!!");
                return;
            }

            //Call DAO to check login
            StaffDAO staffDAO = new StaffDAO();

            StaffDTO staffDTO = staffDAO.CheckLogin(username, password);
            if(staffDTO != null)
            {
                this.Role = staffDTO.Role;
                this.Close();
            }
            else
            {
                MessageBox.Show("Wrong user !!");
            }
            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
