using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Project_Final.Views;
using Project_Final.Presenters;
using Project_Final.Model.Models;

namespace Project_Final.ucControl
{
    public partial class ucStaff : UserControl, IStaffView, IStaffRoleView
    {

        private StaffPresenter staffPresenter;
        private StaffRolePresenter staffRolePresenter;
        private List<StaffModel> listStaff;
        private List<StaffRoleModel> listStaffRole;

        private int action = 0; // 0 = No action is ready
                                // 1 = Add action is ready
                                // 2 = Update action is ready
                                // 3 = Delete button is ready
        public ucStaff()
        {
            InitializeComponent();

            staffPresenter = new StaffPresenter(this);
            staffRolePresenter = new StaffRolePresenter(this);
        }

        public IList<StaffModel> ListStaff
        {
            set
            {
                var staffs = value;
                listStaff = (List<StaffModel>)staffs;
            }
        }

        public IList<StaffRoleModel> GetStaffRole
        {
            set
            {
                var StaffRoles = value;
                listStaffRole = (List<StaffRoleModel>)StaffRoles;
            }

        }

        private void ucStaff_Load(object sender, EventArgs e)
        {
            loadStaff();
        }

        private void loadStaff()
        {
            //Load list staff from DB
            staffPresenter.Display();
            //Clear dgvStaff DataSource before Binding with listStaff
            dgvStaff.DataSource = null;
            dgvStaff.DataSource = listStaff;

            //Load list staff from DB
            staffRolePresenter.Display();
            //Clear cboStaffRole DataSource before Binding with listStaffRole
            cboRole.DataSource = null;
            cboRole.DataSource = listStaffRole;
            cboRole.DisplayMember = "Name";

            //Clear Binding
            ClearBindingForText();
            //Add Binding
            BindingDataForText();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (action != 0)
            {
                action = 0;
                SetActionForLabel(action);
                SetEnableButtonForAction(action);
                BindingDataForText();
                return;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if(action != 1)
            {
                action = 1;
                SetActionForLabel(action);
                SetEnableButtonForAction(action);
                ClearBindingForText();
                ClearAllTextField();
                return;
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (action != 2)
            {
                action = 2;
                SetActionForLabel(action);
                SetEnableButtonForAction(action);
                return;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (action != 3)
            {
                action = 3;
                SetActionForLabel(action);
                SetEnableButtonForAction(action);
                return;
            }
        }
        private void ClearBindingForText()
        {
            //Clear Binding data
            txtStaffID.DataBindings.Clear();
            txtStaffName.DataBindings.Clear();
            txtUsername.DataBindings.Clear();
            txtPassword.DataBindings.Clear();
            txtPhoneNumber.DataBindings.Clear();
            txtAddress.DataBindings.Clear();
            txtCiti_Iden.DataBindings.Clear();
            txtImage.DataBindings.Clear();
            txtBirthday.DataBindings.Clear();
            chkSex.DataBindings.Clear();
            chkStatus.DataBindings.Clear();
        }

        private void BindingDataForText()
        {
            //Binding Data
            txtStaffID.DataBindings.Add("Text", dgvStaff.DataSource, "Id");
            txtStaffName.DataBindings.Add("Text", dgvStaff.DataSource, "FullName");
            txtUsername.DataBindings.Add("Text", dgvStaff.DataSource, "UserName");
            txtPassword.DataBindings.Add("Text", dgvStaff.DataSource, "Password");
            txtPhoneNumber.DataBindings.Add("Text", dgvStaff.DataSource, "Phone");
            txtAddress.DataBindings.Add("Text", dgvStaff.DataSource, "Address");
            txtCiti_Iden.DataBindings.Add("Text", dgvStaff.DataSource, "CitizenIdentification");
            txtImage.DataBindings.Add("Text", dgvStaff.DataSource, "Image");
            txtBirthday.DataBindings.Add("Text", dgvStaff.DataSource, "BirthDay");
            chkSex.DataBindings.Add("Checked", dgvStaff.DataSource, "Sex");
            chkStatus.DataBindings.Add("Checked", dgvStaff.DataSource, "Status");

        }

        private void SetActionForLabel(int action)
        {
            if (action == 0)
            {
                lbActionStatus.Text = "No action is ready !";
            }
            if (action == 1)
            {
                lbActionStatus.Text = "Add action is ready !";
            }
            if (action == 2)
            {
                lbActionStatus.Text = "Update action is ready !";
            }
            if (action == 3)
            {
                lbActionStatus.Text = "Delete action is ready !";
            }
        }
        private void SetEnableButtonForAction(int action)
        {
            if (action == 0)
            {
                btnCancel.Enabled = false;
                btnAdd.Enabled = true;
                btnDelete.Enabled = true;
                btnUpdate.Enabled = true;
                btnChooseImage.Enabled = false;
            }
            if (action == 1)
            {
                btnCancel.Enabled = true;
                btnDelete.Enabled = false;
                btnUpdate.Enabled = false;
                btnChooseImage.Enabled = true;
            }
            if (action == 2)
            {
                btnCancel.Enabled = true;
                btnAdd.Enabled = false;
                btnDelete.Enabled = false;
            }
            if (action == 3)
            {
                btnCancel.Enabled = true;
                btnAdd.Enabled = false;
                btnUpdate.Enabled = false;
                btnChooseImage.Enabled = false;
            }
        }

        private void ClearAllTextField()
        {
            txtAddress.Text = String.Empty;
            txtBirthday.Text = String.Empty;
            txtCiti_Iden.Text = String.Empty;
            txtImage.Text = String.Empty;
            txtPassword.Text = String.Empty;
            txtPhoneNumber.Text = String.Empty;
            txtStaffID.Text = String.Empty;
            txtStaffName.Text = String.Empty;
            txtUsername.Text = String.Empty;
        }

        private void btnChooseImage_Click(object sender, EventArgs e)
        {
            using(OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";

                if(openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    txtImage.Text = openFileDialog.FileName;
                }
            }
        }

        private void dgvStaff_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dgvStaff.Rows[e.RowIndex];
            string role = row.Cells[9].Value.ToString();
            foreach (StaffRoleModel item in cboRole.Items)
            {
                if (item.Id.Equals(role))
                {
                    cboRole.SelectedItem = item;
                    break;
                }
            }
            
        }
    }
}
