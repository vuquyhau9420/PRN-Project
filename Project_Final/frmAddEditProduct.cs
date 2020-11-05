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
    public partial class frmAddEditProduct : Form, IProductGroupView {

        private ProductGroupPresenter productGroupPresenter;

        public ProductModel Product { get; set; }

        public IList<ProductGroupModel> ProductGroups { get; set; }

        public frmAddEditProduct() {
            InitializeComponent();
            productGroupPresenter = new ProductGroupPresenter(this);
        }

        private void LoadProduct() {

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
        }

        private void LoadProductToComponent() {
            txtProductName.Text = Product.Name;
            txtQuantity.Text = Product.Quantity.ToString();
            txtProductID.Text = Product.Id;
            txtImportPrice.Text = Product.ImportPrice.ToString();
            txtSalePrice.Text = Product.SalePrice.ToString();
            txtDesciption.Text = Product.Description;
            txtImage.Text = Product.Image;
            chkStatus.Checked = Product.Status;
        }

    }
}
