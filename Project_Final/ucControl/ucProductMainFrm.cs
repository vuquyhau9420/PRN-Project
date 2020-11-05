using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Project_Final.Presenters;
using Project_Final.Views;
using Project_Final.Model.Models;

namespace Project_Final.ucControl {
    public partial class ucProductMainFrm : UserControl, ICategoryView, IProductGroupView, IProductView {

        private CategoryPresenter categoryPresenter;
        private ProductGroupPresenter productGroupPresenter;
        private ProductPresenter productPresenter;

        private CategoryModel currentCategory;
        private ProductGroupModel currentProductGroup;

        public ucProductMainFrm() {
            InitializeComponent();

            categoryPresenter = new CategoryPresenter(this);
            productGroupPresenter = new ProductGroupPresenter(this);
            productPresenter = new ProductPresenter(this);
        }

        private void ucProductMainFrm_Load(object sender, EventArgs e) {
            // Hien thi cac category tren tree view
            categoryPresenter.Display();
            //productGroupPresenter.Display(1);
        }

        #region List cac model tu view
        // List Categories
        public IList<CategoryModel> Categories {
            set {
                var category = value;
                var root = treeViewCategory.Nodes[0];
                root.Nodes.Clear();

                foreach (var item in category) {
                    // Add tung Category vao Tree View
                    AddCategoryToTree(item);
                }
            }
        }

        // List Product Group theo tung Category
        public IList<ProductGroupModel> ProductGroups {
            set {
                var productGroups = value;
                var category = treeViewCategory.SelectedNode.Tag as CategoryModel;
                category.ProductGroups = productGroups;

                BindingProductGroup(productGroups);
            }
        }

        // List Product theo tung Product Group
        public IList<ProductModel> Products {
            set {
                var products = value;
                int index = dgvProductGroup.SelectedCells[0].RowIndex;
                var productGroup = dgvProductGroup.Rows[index].Tag as ProductGroupModel;
                foreach (var item in currentCategory.ProductGroups) {
                    if (item.Id.Equals(productGroup.Id)) {
                        currentProductGroup = item;
                        item.ListProducts = products;

                        BindingProduct(products);
                    }
                }
            }
        }
        #endregion

        #region Load data grid view Product, ProductGroup
        // Rang buoc List Product Group vao Data Grid View
        private void BindingProductGroup(IList<ProductGroupModel> productGroups) {
            if (productGroups != null) {
                dgvProductGroup.DataSource = productGroups;
                for (int i = 0; i < dgvProductGroup.Rows.Count; i++) {
                    dgvProductGroup.Rows[i].Tag = productGroups[i];
                }
                dgvProductGroup.ReadOnly = true;

                dgvProductGroup.Columns["Supplier"].Visible = false;
                dgvProductGroup.Columns["Category"].Visible = false;
                dgvProductGroup.Columns["Id"].Visible = false;

                dgvProductGroup.Columns["Name"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                dgvProductGroup.Columns["SupplierName"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                dgvProductGroup.Columns["SupplierName"].HeaderText = "Supplier";
                dgvProductGroup.Columns["ProductGroupCategory"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                dgvProductGroup.Columns["ProductGroupCategory"].HeaderText = "Category";
                dgvProductGroup.Columns["IsStocking"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                dgvProductGroup.Columns["IsStocking"].HeaderText = "Stocking";
            }
        }

        // Rang buoc List Product vao Data Grid View
        private void BindingProduct(IList<ProductModel> products) {
            if (products != null) {
                dgvProduct.DataSource = products;
                dgvProduct.ReadOnly = true;

                dgvProduct.Columns["ProductGroupId"].Visible = false;
                dgvProduct.Columns["Id"].Visible = false;
                dgvProduct.Columns["Image"].Visible = false;
                dgvProduct.Columns["ProductGroup"].Visible = false;

                dgvProduct.Columns["Name"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                dgvProduct.Columns["Quantity"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                dgvProduct.Columns["ImportPrice"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                dgvProduct.Columns["ImportPrice"].HeaderText = "Import Price";
                dgvProduct.Columns["SalePrice"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                dgvProduct.Columns["SalePrice"].HeaderText = "Sale Price";
                dgvProduct.Columns["Description"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            }
        }
        #endregion

        #region Them 1 Category vao Tree View
        private TreeNode AddCategoryToTree(CategoryModel category) {
            var node = new TreeNode();
            node.Text = category.Name;
            // Set obj cho node
            node.Tag = category;
            this.treeViewCategory.Nodes[0].Nodes.Add(node);
            return node;
        }
        #endregion

        #region Su kien sau khi chon node tren tree view
        private void treeViewCategory_AfterSelect(object sender, TreeViewEventArgs e) {
            var category = treeViewCategory.SelectedNode.Tag as CategoryModel;

            if (category != null) {
                currentCategory = category;

                // Kiem tra xem List Product Group cua Category co ton tai chua
                if (category.ProductGroups != null) {
                    if (category.ProductGroups.Count > 0) {
                        BindingProductGroup(category.ProductGroups);

                        currentProductGroup = category.ProductGroups[0];
                        // Load Product Data Grid View theo Product Group dau tien trong list
                        productPresenter.Display(currentProductGroup.Id);
                        BindingProduct(currentProductGroup.ListProducts);
                    }
                }
                else {
                    this.Cursor = Cursors.WaitCursor;
                    productGroupPresenter.Display(category.Id);
                    BindingProductGroup(category.ProductGroups);
                    this.Cursor = Cursors.Default;
                }
            }
        }
        #endregion

        #region Su kien click vao cell cua Data grid view Product Group 
        private void dgvProductGroup_CellClick(object sender, DataGridViewCellEventArgs e) {
            int index = dgvProductGroup.SelectedCells[0].RowIndex;
            var productGroup = dgvProductGroup.Rows[index].Tag as ProductGroupModel;

            if (productGroup != null) {
                currentProductGroup = productGroup;

                // Kiem tra xem List Product cua Product Group co ton tai chua
                if (productGroup.ListProducts != null) {
                    if (productGroup.ListProducts.Count > 0) {
                        BindingProduct(productGroup.ListProducts);
                    }
                }
                else {
                    this.Cursor = Cursors.WaitCursor;
                    productPresenter.Display(productGroup.Id);
                    BindingProduct(productGroup.ListProducts);
                    this.Cursor = Cursors.Default;
                }
            }
        }
        #endregion
    }
}
