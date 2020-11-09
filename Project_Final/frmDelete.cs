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
    public partial class frmDelete : Form, ICategoriesView, IProductsView, IProductView, IProductGroupsView, IProductGroupView, ICategoryView {

        private CategoriesPresenter categoriesPresenter;
        private ProductGroupsPresenter productGroupsPresenter;
        private ProductsPresenter productsPresenter;
        private ProductPresenter productPresenter;
        private ProductGroupPresenter productGroupPresenter;
        private CategoryPresenter categoryPresenter;

        private List<ProductModel> listProducts;
        private List<CategoryModel> listCategories;
        private List<ProductGroupModel> listProductGroups;

        public string Type { get; set; }

        public frmDelete() {
            InitializeComponent();
            categoriesPresenter = new CategoriesPresenter(this);
            productGroupsPresenter = new ProductGroupsPresenter(this);
            productPresenter = new ProductPresenter(this);
            productsPresenter = new ProductsPresenter(this);
            productGroupPresenter = new ProductGroupPresenter(this);
            categoryPresenter = new CategoryPresenter(this);
        }

        public string GroupId => GetProductGroupID();

        public string ProductID => GetProductID();

        public int CategoryId => GetCategoryID();

        #region Unessecary fields
        public int Quantity => throw new NotImplementedException();

        public double ImportPrice => throw new NotImplementedException();

        public double SalePrice => throw new NotImplementedException();

        public string Description => throw new NotImplementedException();

        public string ProductImage => throw new NotImplementedException();

        public bool Status => throw new NotImplementedException();

        public string ProductGroupName => throw new NotImplementedException();

        public int ProductGroupSupplier => throw new NotImplementedException();

        public int ProductGroupCategory => throw new NotImplementedException();

        public bool IsStocking => throw new NotImplementedException();

        public string CategoryName { get => throw new NotImplementedException(); }

        bool ICategoryView.Status { get => throw new NotImplementedException(); }
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
                    bool result = productGroupPresenter.Delete();
                    if (result) {
                        bool clean = productGroupPresenter.DeleteProducts();
                        if (clean) {
                            MessageBox.Show("Delete Success.", "Delete Status");
                            this.Dispose();
                        }
                    }
                    else {
                        MessageBox.Show("Delete Fail.", "Delete Status");
                    }
                }
                else if (Type.Equals("Category")) {
                    bool result = categoryPresenter.Delete();
                    if (result) {
                        MessageBox.Show("Delete Success.", "Delete Status");
                        this.Dispose();
                    }
                    else {
                        MessageBox.Show("Delete Fail.", "Delete Status");
                    }
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

        private int GetCategoryID() {
            string categoryItem = cboCategory.SelectedItem.ToString();
            return int.Parse(categoryItem.Split(new char[] { '-' })[0].Trim());
        }
        #endregion

        private void frmDeleteProduct_Load(object sender, EventArgs e) {
            categoriesPresenter.DisplayActiveCategories();
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
            if (Type.Equals("Product Group")) {
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
                        productGroupsPresenter.DisplayActiveGroupsBaseCategory(item.Id);

                        LoadProductGroupCombobox();

                        cboProductGroup.Enabled = true;
                    }
                }
            }

            if (Type.Equals("Category")) {
                btnDelete.Enabled = true;
            }
        }

        private void cboProductGroup_SelectedIndexChanged(object sender, EventArgs e) {
            if (Type.Equals("Product")) {
                cboProductName.Items.Clear();
                cboProductName.Text = "";

                string productGroupItem = cboProductGroup.SelectedItem.ToString();
                string productGroupId = productGroupItem.Split(new char[] { '-' })[0].Trim();

                foreach (var item in listProductGroups) {

                    // Load list product
                    if (item.Id.Equals(productGroupId)) {
                        productsPresenter.DisplayActiveProducts(item.Id);

                        LoadProductCombobox();

                        cboProductName.Enabled = true;
                    }
                }
            }

            if (Type.Equals("Product Group")) {
                btnDelete.Enabled = true;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e) {
            this.Dispose();
        }

        private void cboProductName_SelectedIndexChanged(object sender, EventArgs e) {
            if (Type.Equals("Product")) {
                btnDelete.Enabled = true;
            }
        }
    }
}
