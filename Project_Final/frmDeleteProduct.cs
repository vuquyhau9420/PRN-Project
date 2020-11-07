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
    public partial class frmDeleteProduct : Form, ICategoryView, IProductsView, IProductView, IProductGroupsView {

        private CategorysPresenter categorysPresenter;
        private ProductGroupsPresenter productGroupsPresenter;
        private ProductsPresenter productsPresenter;
        private ProductPresenter productPresenter;

        private List<ProductModel> listProducts;
        private List<CategoryModel> listCategries;
        private List<ProductGroupModel> listProductGroups;

        public frmDeleteProduct() {
            InitializeComponent();
            categorysPresenter = new CategorysPresenter(this);
            productGroupsPresenter = new ProductGroupsPresenter(this);
            productPresenter = new ProductPresenter(this);
            productsPresenter = new ProductsPresenter(this);
        }

        public string ProductGroupId => throw new NotImplementedException();

        public string ProductID => GetProductID();

        public int Quantity => throw new NotImplementedException();

        public double ImportPrice => throw new NotImplementedException();

        public double SalePrice => throw new NotImplementedException();

        public string Description => throw new NotImplementedException();

        public string ProductImage => throw new NotImplementedException();

        public bool Status => throw new NotImplementedException();

        public IList<ProductModel> Products {
            set {
                listProducts = (List<ProductModel>)value;
            }
        }
        public IList<CategoryModel> Categories {
            get => throw new NotImplementedException();
            set {
                listCategries = (List<CategoryModel>)value;
            }
        }
        public IList<ProductGroupModel> ProductGroups {
            get => throw new NotImplementedException();
            set {
                listProductGroups = (List<ProductGroupModel>)value;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e) {
            DialogResult confirm = MessageBox.Show("Do you really want to delete?", "Delete Cofirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (confirm == DialogResult.OK) {

                bool result = productPresenter.Delete();
                if (result) {
                    MessageBox.Show("Delete Success.", "Delete Status");
                    this.Dispose();
                }
                else {
                    MessageBox.Show("Delete Fail.", "Delete Status");
                }
            }
        }

        private string GetProductID() {
            string productItem = cboProductName.SelectedItem.ToString();
            return productItem.Split(new char[] { '-' })[0];
        }

        private void frmDeleteProduct_Load(object sender, EventArgs e) {
            categorysPresenter.Display();
            foreach (var item in listCategries) {
                cboCategory.Items.Add(item.Id + " - " + item.Name);
            }

            cboProductGroup.Enabled = false;
            cboProductName.Enabled = false;
        }

        private void cboCategory_SelectedIndexChanged(object sender, EventArgs e) {
            cboProductGroup.Items.Clear();
            cboProductName.Items.Clear();
            cboProductName.Text = "";
            cboProductGroup.Text = "";

            string categoryItem = cboCategory.SelectedItem.ToString();
            string categoryId = categoryItem.Split(new char[] { '-' })[0].Trim();
            cboProductGroup.Items.Clear();

            foreach (var item in listCategries) {

                if (item.Id == int.Parse(categoryId)) {
                    productGroupsPresenter.Display(item.Id);

                    foreach (var productGroup in listProductGroups) {
                        cboProductGroup.Items.Add(productGroup.Id + " - " + productGroup.Name);
                    }

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

                if (item.Id.Equals(productGroupId)) {
                    productsPresenter.Display(item.Id);

                    foreach (var product in listProducts) {
                        Console.WriteLine(product.Id + " - " + product.Name);
                        cboProductName.Items.Add(product.Id + " - " + product.Name);
                    }

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
