using Project_Final.Model.Models;
using Project_Final.Presenters;
using Project_Final.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Final {
    public partial class frmAddCatogory : Form, ICategoryView {

        private CategoryPresenter categoryPresenter;

        public frmAddCatogory() {
            InitializeComponent();
            categoryPresenter = new CategoryPresenter(this);
        }

        public int CategoryId => CategorySelected.Id;

        public string CategoryName => txtCategory.Text;

        public bool Status => chkStatus.Checked;

        public CategoryModel CategorySelected { get; set; }

        private bool ValidateName() {
            if (txtCategory.Text.Length <= 0 || txtCategory.Text.Length > 50) {
                MessageBox.Show("Category name can contain maximum 50 characters and can't be empty.");
                return false;
            }
            return true;
        }

        private void btnSave_Click(object sender, EventArgs e) {
            if (CategorySelected == null) {
                if (ValidateName()) {
                    bool existed = categoryPresenter.CheckCategoryName();
                    if (!existed) {
                        bool result = categoryPresenter.Insert();
                        if (result) {
                            MessageBox.Show("Add Success.", "Insert Status");
                            this.Dispose();
                        }
                        else {
                            MessageBox.Show("Add Fail.", "Insert Status");
                        }
                    }
                    else {
                        MessageBox.Show("This category is already existed. Please choose another.", "Insert Status");
                    }
                }
            }
            else {
                bool result = categoryPresenter.Update();
                if (result) {
                    MessageBox.Show("Update Success.", "Update Status");
                    this.Dispose();
                }
                else {
                    MessageBox.Show("Update Fail.", "Update Status");
                }
            }
        }

        private void frmAddCatogory_Load(object sender, EventArgs e) {
            if (CategorySelected != null) {
                LoadFields();
            }
        }

        private void LoadFields() {
            txtCategory.Text = CategorySelected.Name;
            chkStatus.Checked = CategorySelected.Status;
        }
    }
}
