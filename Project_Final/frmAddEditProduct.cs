using Project_Final.Model.Models;
using Project_Final.Presenters;
using Project_Final.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Final {
    public partial class frmAddEditProduct : Form, IProductView, ICategoryView, IProductGroupsView {

        private ProductPresenter productPresenter;
        private CategorysPresenter categorysPresenter;
        private ProductGroupsPresenter productGroupsPresenter;

        public ProductModel ProductSelected { get; set; }

        public IList<ProductGroupModel> ProductGroups { get; set; }

        public IList<CategoryModel> Categories { get; set; }

        public int CurrentCategoryId { get; set; }

        public string ProductGroupId => GetProductGroupID().Trim();

        public string ProductID => GetProductID().Trim();

        public new string ProductName => txtProductName.Text.Trim();

        public int Quantity => int.Parse(txtQuantity.Text.Trim());

        public double ImportPrice => double.Parse(txtImportPrice.Text.Trim());

        public double SalePrice => double.Parse(txtSalePrice.Text.Trim());

        public string Description => txtDesciption.Text.Trim();

        public string ProductImage => txtImage.Text.Trim();

        public bool Status => chkStatus.Checked;

        public frmAddEditProduct() {
            InitializeComponent();
            productPresenter = new ProductPresenter(this);
            categorysPresenter = new CategorysPresenter(this);
            productGroupsPresenter = new ProductGroupsPresenter(this);
        }

        private void frmAddEditProduct_Load(object sender, EventArgs e) {
            if (Categories == null) {
                categorysPresenter.Display();
                LoadCategories();
            }
            else {
                LoadCategories();
            }

            if (ProductSelected != null) {
                cboCategory.Enabled = false;
                LoadProductToFields();
                txtProductID.Enabled = false;
                btnSave.Text = "Save";
            }
        }

        #region Load combo box
        private void LoadCategories() {
            foreach (var item in Categories) {
                cboCategory.Items.Add(item.Id + " - " + item.Name);
                if (item.Id == CurrentCategoryId) {
                    cboCategory.SelectedItem = item.Id + " - " + item.Name;
                }
            }
        }

        private void LoadProductGroups() {
            foreach (var item in ProductGroups) {
                cboProductGroup.Items.Add(item.Id + " - " + item.Name);
                if (ProductSelected != null) {
                    if (item.Id.Equals(ProductSelected.ProductGroupId)) {
                        cboProductGroup.SelectedItem = item.Id + " - " + item.Name;
                    }
                }
            }
        }
        #endregion

        #region Extend method get nessescary ID
        private string GetProductGroupID() {
            string productGroupItem = cboProductGroup.SelectedItem.ToString();
            return productGroupItem.Split(new char[] { '-' })[0].Trim();
        }

        private string GetCategoryID() {
            string categoryItem = cboCategory.SelectedItem.ToString();
            return categoryItem.Split(new char[] { '-' })[0].Trim();
        }

        private string GetProductID() {
            return lblProductGroupId.Text + txtProductID.Text;
        }
        #endregion

        #region Load product selected to fields
        private void LoadProductToFields() {
            txtProductName.Text = ProductSelected.Name;
            txtQuantity.Text = ProductSelected.Quantity.ToString();
            string viewId = ProductSelected.Id.Split(new char[] { '_' })[1].Trim();
            txtProductID.Text = viewId;
            txtImportPrice.Text = ProductSelected.ImportPrice.ToString();
            txtSalePrice.Text = ProductSelected.SalePrice.ToString();
            txtDesciption.Text = ProductSelected.Description;
            txtImage.Text = ProductSelected.Image;
            chkStatus.Checked = ProductSelected.Status;

            if (File.Exists(ProductSelected.Image)) {
                pbProductImage.Image = Image.FromFile(ProductSelected.Image);
                pbProductImage.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }
        #endregion

        #region Click save button
        private void btnSave_Click(object sender, EventArgs e) {
            if (ValidateDetail()) {
                if (ProductSelected != null) {
                    try {
                        bool result = productPresenter.Update();
                        if (result) {
                            UpdateStocking();
                            MessageBox.Show("Update Success.", "Update Status");
                            this.Dispose();
                        }
                        else {
                            MessageBox.Show("Update Fail.", "Update Status");
                        }
                    }
                    catch (SqlException ex) {
                        MessageBox.Show(ex.Message, "Update status");
                    }
                }
                else {
                    try {
                        bool result = productPresenter.Insert();
                        if (result) {
                            UpdateStocking();
                            MessageBox.Show("Add Success.", "Insert Status");
                            this.Dispose();
                        }
                        else {
                            MessageBox.Show("Add Fail.", "Insert Status");
                        }
                    }
                    catch (SqlException ex) {
                        if (ex.Message.Contains("duplicate")) {
                            MessageBox.Show("Product ID is already existed. Please choose another.", "Insert Status");
                        }
                        else {
                            MessageBox.Show(ex.Message, "Insert status");
                        }
                    }
                }
            }
        }
        #endregion

        #region Update stocking
        private void UpdateStocking() {
            bool isStocking = productPresenter.CheckStocking();
            productPresenter.UpdateStocking(isStocking);
        }
        #endregion

        #region Validate fields
        private bool ValidateDetail() {
            bool valid = true;
            string errors = "";

            // Check product id
            string productId = GetProductID();
            if (productId.Length <= lblProductGroupId.Text.Length || productId.Length > 50) {
                valid = false;
                errors += "Product ID can contain maximum 50 characters and can't be empty.";
            }

            // Check product name
            string productName = txtProductName.Text.Trim();
            if (productName.Length <= 0 || productName.Length > 100) {
                valid = false;
                errors += "Product name can contain maximum 100 characters and can't be empty.";
            }

            // Check quantity
            if (!txtQuantity.Text.Trim().All(char.IsDigit) || txtQuantity.Text.Equals("")) {
                valid = false;
                errors += "Quantity is invalid.";
            }
            else {
                int check = int.Parse(txtQuantity.Text.Trim());
                if (check > 10000000) {
                    valid = false;
                    errors += "Quantity can't be larger than 10000000.";
                }
            }

            // Check import price
            if (!txtImportPrice.Text.Trim().All(char.IsDigit) || txtImportPrice.Text.Equals("")) {
                valid = false;
                errors += "Import price is invalid.";
            }
            else {
                double check = double.Parse(txtImportPrice.Text.Trim());
                if (check > Double.MaxValue) {
                    valid = false;
                    errors += "Import price can't be large like that.";
                }
            }

            // Check sale price
            if (!txtSalePrice.Text.Trim().All(char.IsDigit) || txtSalePrice.Text.Equals("")) {
                valid = false;
                errors += "Sale price is invalid.";
            }
            else {
                double check = double.Parse(txtSalePrice.Text.Trim());
                if (check > Double.MaxValue) {
                    valid = false;
                    errors += "Sale price can't be large like that.";
                }
            }

            // Check image
            if (txtImage.Text.Trim().Equals("")) {
                valid = false;
                errors += "Image can't be empty.";
            }

            if (!valid) {
                MessageBox.Show(errors, "Warning");
            }
            return valid;
        }
        #endregion

        #region Choose image
        private void btnChooseImg_Click(object sender, EventArgs e) {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Image Files(*.BMP;*.JPG;*.JPEG;*.PNG)|*.BMP;*.JPG;*.JPEG;*.PNG";
            dialog.RestoreDirectory = true;
            if (dialog.ShowDialog() == DialogResult.OK) {
                txtImage.Text = dialog.FileName;
                pbProductImage.Image = Image.FromFile(dialog.FileName);
                pbProductImage.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }
        #endregion

        private void btnCancel_Click(object sender, EventArgs e) {
            this.Dispose();
        }

        #region Allow digit key char in fields
        private void txtImportPrice_KeyPress(object sender, KeyPressEventArgs e) {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) {
                e.Handled = true;
            }
        }

        private void txtSalePrice_KeyPress(object sender, KeyPressEventArgs e) {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) {
                e.Handled = true;
            }
        }

        private void txtQuantity_KeyPress(object sender, KeyPressEventArgs e) {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) {
                e.Handled = true;
            }
        }
        #endregion

        #region Combobox product group select
        private void cboProductGroup_SelectedIndexChanged(object sender, EventArgs e) {
            string productGroupItem = cboProductGroup.SelectedItem.ToString();
            string productGroupId = productGroupItem.Split(new char[] { '-' })[0].Trim();
            if (!productGroupId.Equals("")) {
                lblProductGroupId.Text = productGroupId + "_";
                txtProductID.Mask = "aaaaaaaaaa";
                txtProductID.Enabled = true;
            }
        }
        #endregion

        #region Combobox category select
        private void cboCategory_SelectedIndexChanged(object sender, EventArgs e) {
            int categoryId = int.Parse(GetCategoryID());
            cboProductGroup.Items.Clear();
            productGroupsPresenter.DisplayBaseCategory(categoryId);
            cboProductGroup.Enabled = true;
            if (ProductGroups != null) {
                LoadProductGroups();
            }
        }
        #endregion
    }
}
