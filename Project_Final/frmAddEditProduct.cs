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
    public partial class frmAddEditProduct : Form, IProductView {

        private ProductPresenter productPresenter;

        public ProductModel ProductSelected { get; set; }

        public IList<ProductGroupModel> ProductGroups { get; set; }

        public string ProductGroupId => ProductSelected.ProductGroupId;

        public string ProductID => txtProductID.Text;

        public new string ProductName => txtProductName.Text;

        public int Quantity => int.Parse(txtQuantity.Text);

        public double ImportPrice => double.Parse(txtImportPrice.Text);

        public double SalePrice => double.Parse(txtSalePrice.Text);

        public string Description => txtDesciption.Text;

        public string ProductImage => txtImage.Text;

        public bool Status => chkStatus.Checked;

        public frmAddEditProduct() {
            InitializeComponent();
            productPresenter = new ProductPresenter(this);
        }

        private void btnAddProductGroup_Click(object sender, EventArgs e) {
            frmAddEditProductGroup frmAddEditProductGroup = new frmAddEditProductGroup();
            frmAddEditProductGroup.ShowDialog();
        }

        private void btnAddCategory_Click(object sender, EventArgs e) {
            frmAddCatogory frmAddCatogory = new frmAddCatogory();
            frmAddCatogory.ShowDialog();
        }

        private void frmAddEditProduct_Load(object sender, EventArgs e) {
            cboProductGroup.DataSource = ProductGroups;
            LoadProductToComponent();
        }

        private void LoadProductToComponent() {
            txtProductName.Text = ProductSelected.Name;
            txtQuantity.Text = ProductSelected.Quantity.ToString();
            txtProductID.Text = ProductSelected.Id;
            txtImportPrice.Text = ProductSelected.ImportPrice.ToString();
            txtSalePrice.Text = ProductSelected.SalePrice.ToString();
            txtDesciption.Text = ProductSelected.Description;
            txtImage.Text = ProductSelected.Image;
            chkStatus.Checked = ProductSelected.Status;

            pbProductImage.Image = Image.FromFile(ProductSelected.Image);
            pbProductImage.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void btnSave_Click(object sender, EventArgs e) {
            if (ValidateDetail()) {
                bool result = productPresenter.Update();
                if (result) {
                    MessageBox.Show("Update Success.", "Update Status");
                    this.Dispose();
                }
                else {
                    MessageBox.Show("Update Fail.", "Update Status");
                }
            }
        }

        private bool ValidateDetail() {
            bool valid = true;
            string errors = "";

            // Check product name
            string productName = txtProductName.Text;
            if (productName.Length <= 0 || productName.Length > 100) {
                valid = false;
                errors += "Product name can contain maximum 100 characters and can't be empty.";
            }

            // Check quantity
            if (!txtQuantity.Text.All(char.IsDigit)) {
                valid = false;
                errors += "Quantity is invalid.";
            }
            else {
                int check = int.Parse(txtQuantity.Text);
                if (check > 10000000) {
                    valid = false;
                    errors += "Quantity can't be larger than 10000000.";
                }
            }

            // Check import price
            if (!txtImportPrice.Text.All(char.IsDigit)) {
                valid = false;
                errors += "Import price is invalid.";
            }
            else {
                double check = double.Parse(txtImportPrice.Text);
                if (check > Double.MaxValue) {
                    valid = false;
                    errors += "Import price can't be large like that.";
                }
            }

            // Check image
            if (txtImage.Text.Equals("")) {
                valid = false;
                errors += "Image can't be empty.";
            }

            if (!valid) {
                MessageBox.Show(errors, "Update Status");
            }
            return valid;
        }

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

        private void btnCancel_Click(object sender, EventArgs e) {
            this.Dispose();
        }
    }
}
