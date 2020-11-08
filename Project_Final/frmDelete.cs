using DataObjects;
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
    public partial class frmDelete : Form, ICategoryView, IProductsView, IProductView, IProductGroupsView {

        private CategorysPresenter categorysPresenter;
        private ProductGroupsPresenter productGroupsPresenter;
        private ProductsPresenter productsPresenter;
        private ProductPresenter productPresenter;

        private List<ProductModel> listProducts;
        private List<CategoryModel> listCategories;
        private List<ProductGroupModel> listProductGroups;

        public string Type { get; set; }

        public frmDelete() {
            InitializeComponent();
            categorysPresenter = new CategorysPresenter(this);
            productGroupsPresenter = new ProductGroupsPresenter(this);
            productPresenter = new ProductPresenter(this);
            productsPresenter = new ProductsPresenter(this);
        }

        public string ProductGroupId => GetProductGroupID();

        public string ProductID => GetProductID();

        #region Unessecary fields
        public int Quantity => throw new NotImplementedException();

        public double ImportPrice => throw new NotImplementedException();

        public double SalePrice => throw new NotImplementedException();

        public string Description => throw new NotImplementedException();

        public string ProductImage => throw new NotImplementedException();

        public bool Status => throw new NotImplementedException();
        #endregion

        public IList<ProductModel> Products {
            set {
                listProducts = (List<ProductModel>)value;
            }
        }
        public IList<CategoryModel> Categories {
            set {
                listCategories = (List<CategoryModel>)value;
            }
        }
        public IList<ProductGroupModel> ProductGroups {
            set {
                listProductGroups = (List<ProductGroupModel>)value;
            }
        }

        private void ClassifyType() {
            if (Type.Equals("Product Group")) {
                cboProductName.Hide();
                lblProduct.Hide();
            }
            else if (Type.Equals("Category")) {
                cboProductName.Hide();
                lblProduct.Hide();
                cboProductGroup.Hide();
                lblProductGroup.Hide();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e) {
            DialogResult confirm = MessageBox.Show("Do you really want to delete?", "Delete Cofirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (confirm == DialogResult.OK) {

                if (Type.Equals("Product")) {
                    bool result = productPresenter.Delete();
                    if (result) {
                        bool isStocking = productPresenter.CheckStocking();
                        productPresenter.UpdateStocking(isStocking);
                        MessageBox.Show("Delete Success.", "Delete Status");
                        this.Dispose();
                    }
                    else {
                        MessageBox.Show("Delete Fail.", "Delete Status");
                    }
                }

                else if (Type.Equals("Product Group")) {

                }
                else if (Type.Equals("Category")) {

                }
            }
        }

        #region Extend method to get ID
        private string GetProductID() {
            string productItem = cboProductName.SelectedItem.ToString();
            return productItem.Split(new char[] { '-' })[0].Trim();
        }

        private string GetProductGroupID() {
            string productGroupItem = cboProductGroup.SelectedItem.ToString();
            return productGroupItem.Split(new char[] { '-' })[0].Trim();
        }
        #endregion

        private void frmDeleteProduct_Load(object sender, EventArgs e) {
            categorysPresenter.Display();
            LoadCategoryCombobox();

            cboProductGroup.Enabled = false;
            cboProductName.Enabled = false;
            ClassifyType();
        }

        #region Load combo box
        private void LoadCategoryCombobox() {
            foreach (var item in listCategories) {
                cboCategory.Items.Add(item.Id + " - " + item.Name);
            }
        }
        private void LoadProductGroupCombobox() {
            foreach (var productGroup in listProductGroups) {
                cboProductGroup.Items.Add(productGroup.Id + " - " + productGroup.Name);
            }
        }

        private void LoadProductCombobox() {
            foreach (var product in listProducts) {
                cboProductName.Items.Add(product.Id + " - " + product.Name);
            }
        }
        #endregion

        private void cboCategory_SelectedIndexChanged(object sender, EventArgs e) {
            cboProductGroup.Items.Clear();
            cboProductName.Items.Clear();
            cboProductName.Text = "";
            cboProductGroup.Text = "";

            string categoryItem = cboCategory.SelectedItem.ToString();
            string categoryId = categoryItem.Split(new char[] { '-' })[0].Trim();
            cboProductGroup.Items.Clear();

            foreach (var item in listCategories) {

                // Load list product group
                if (item.Id == int.Parse(categoryId)) {
                    productGroupsPresenter.DisplayBaseCategory(item.Id);

                    LoadProductGroupCombobox();

                    cboProductGroup.Enabled = true;
                }
            }
        }

        private void cboProductGroup_SelectedIndexChanged(object sender, EventArgs e) {
            cboProductName.Items.Clear();
            cboProductName.Text = "";

            string productGroupItem = cboProductGroup.SelectedItem.ToString();
            string productGroupId = productGroupItem.Split(new char[] { '-' })[0].Trim();

            foreach (var item in listProductGroups) {

                // Load list product
                if (item.Id.Equals(productGroupId)) {
                    productsPresenter.Display(item.Id);

                    LoadProductCombobox();

                    cboProductName.Enabled = true;
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e) {
            this.Dispose();
        }

        private void cboProductName_SelectedIndexChanged(object sender, EventArgs e) {
            btnDelete.Enabled = true;
        }
    }
}
