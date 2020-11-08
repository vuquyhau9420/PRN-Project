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
using System.Collections;

namespace Project_Final.ucControl {
    public partial class ucProductMainFrm : UserControl, ICategoryView, IProductGroupsView, IProductsView, ISuppliersView {

        private CategorysPresenter categoryPresenter;
        private ProductGroupsPresenter productGroupPresenter;
        private ProductsPresenter productPresenter;
        private SuppliersPresenter suppliersPresenter;

        private CategoryModel currentCategory;
        private ProductGroupModel currentProductGroup;
        private SupplierModel currentSupplier;

        private List<CategoryModel> listCategories;
        private List<ProductGroupModel> listProductGroups;
        private List<ProductModel> listsProducts;
        private List<SupplierModel> listSuppliers;

        public ucProductMainFrm() {
            InitializeComponent();

            categoryPresenter = new CategorysPresenter(this);
            productGroupPresenter = new ProductGroupsPresenter(this);
            productPresenter = new ProductsPresenter(this);
            suppliersPresenter = new SuppliersPresenter(this);
        }

        private void ucProductMainFrm_Load(object sender, EventArgs e) {
            // Hien thi cac category tren tree view
            StartUp();
        }

        private void StartUp() {
            categoryPresenter.Display();
            currentCategory = listCategories[0];
            LoadDataFromDBBaseCategory(currentCategory);
            dgvProduct.DataSource = null;
            dgvProduct.Rows.Clear();
            dgvProductGroup.DataSource = null;
            dgvProductGroup.Rows.Clear();

            suppliersPresenter.Display();
        }

        #region List cac model tu view
        // List Categories
        public IList<CategoryModel> Categories {
            set {
                var categories = value;
                listCategories = (List<CategoryModel>)categories;
                var root = treeViewCategory.Nodes[0];
                root.Nodes.Clear();

                foreach (var item in categories) {
                    // Add tung Category vao Tree View
                    AddCategoryToTree(item);
                }
                treeViewCategory.ExpandAll();
            }
        }

        // List Product Group theo tung Category
        public IList<ProductGroupModel> ProductGroups {
            set {
                var productGroups = value;
                listProductGroups = (List<ProductGroupModel>)productGroups;
                currentCategory.ProductGroups = productGroups;
                currentProductGroup = productGroups[0];

                BindingProductGroup(productGroups);
            }
        }

        // List Product theo tung Product Group
        public IList<ProductModel> Products {
            set {
                var products = value;
                listsProducts = (List<ProductModel>)products;
                foreach (var item in currentCategory.ProductGroups) {
                    if (item.Id.Equals(currentProductGroup.Id)) {
                        item.ListProducts = products;

                        BindingProduct(products);
                    }
                }
            }
        }

        public IList<SupplierModel> Suppliers {
            set {
                var suppliers = value;
                listSuppliers = (List<SupplierModel>)suppliers;

                var root = treeViewSupplier.Nodes[0];
                root.Nodes.Clear();

                foreach (var item in suppliers) {
                    // Add tung Category vao Tree View
                    AddSupplierToTree(item);
                }
                treeViewSupplier.ExpandAll();
            }
        }
        #endregion

        #region Load data grid view Product, ProductGroup
        // Rang buoc List Product Group vao Data Grid View
        private void BindingProductGroup(IList<ProductGroupModel> productGroups) {
            if (productGroups != null) {
                dgvProductGroup.DataSource = productGroups;

                // Add tag vao tung row cua Data Grid View
                for (int i = 0; i < dgvProductGroup.Rows.Count; i++) {
                    dgvProductGroup.Rows[i].Tag = productGroups[i];
                }
                dgvProductGroup.ReadOnly = true;

                dgvProductGroup.Columns["Supplier"].Visible = false;
                dgvProductGroup.Columns["Category"].Visible = false;
                dgvProductGroup.Columns["ListProducts"].Visible = false;

                dgvProductGroup.Columns["Id"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                dgvProductGroup.Columns["Name"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                dgvProductGroup.Columns["SupplierName"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                dgvProductGroup.Columns["SupplierName"].HeaderText = "Supplier";
                dgvProductGroup.Columns["ProductGroupCategory"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                dgvProductGroup.Columns["ProductGroupCategory"].HeaderText = "Category";
                dgvProductGroup.Columns["IsStocking"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                dgvProductGroup.Columns["IsStocking"].HeaderText = "Stocking";
                dgvProductGroup.Columns["Status"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            }
        }

        // Rang buoc List Product vao Data Grid View
        private void BindingProduct(IList<ProductModel> products) {
            if (products != null) {
                dgvProduct.DataSource = products;
                dgvProduct.ReadOnly = true;

                // Add tag vao tung row cua Data Grid View
                for (int i = 0; i < dgvProduct.Rows.Count; i++) {
                    dgvProduct.Rows[i].Tag = products[i];
                }

                dgvProduct.Columns["ProductGroupId"].Visible = false;
                dgvProduct.Columns["Image"].Visible = false;
                dgvProduct.Columns["ProductGroup"].Visible = false;

                dgvProduct.Columns["Id"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                dgvProduct.Columns["Name"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                dgvProduct.Columns["Quantity"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                dgvProduct.Columns["ImportPrice"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                dgvProduct.Columns["ImportPrice"].HeaderText = "Import Price";
                dgvProduct.Columns["SalePrice"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                dgvProduct.Columns["SalePrice"].HeaderText = "Sale Price";
                dgvProduct.Columns["Description"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                dgvProduct.Columns["Status"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            }
        }
        #endregion

        #region Them 1 Category vao Tree View
        private TreeNode AddCategoryToTree(CategoryModel category) {
            var node = new TreeNode();
            node.Text = category.Name;
            // Set obj cho node

            if (category.Status) {
                node.ImageIndex = 1;
            }
            else {
                node.ImageIndex = 2;
            }
            node.Tag = category;
            this.treeViewCategory.Nodes[0].Nodes.Add(node);
            return node;
        }

        private TreeNode AddSupplierToTree(SupplierModel supplier) {
            var node = new TreeNode();
            node.Text = supplier.Name;
            // Set obj cho node

            if (supplier.Status) {
                node.ImageIndex = 1;
            }
            else {
                node.ImageIndex = 2;
            }
            node.Tag = supplier;
            this.treeViewSupplier.Nodes[0].Nodes.Add(node);
            return node;
        }
        #endregion

        #region Su kien sau khi chon node tren tree view
        private void treeViewCategory_AfterSelect(object sender, TreeViewEventArgs e) {
            treeViewCategory.SelectedImageIndex = treeViewCategory.SelectedNode.ImageIndex;
            var category = treeViewCategory.SelectedNode.Tag as CategoryModel;
            if (category != null) {
                currentCategory = category;
                LoadDataFromDBBaseCategory(currentCategory);
            }
        }
        #endregion

        #region Lay du lieu tu DB va load len usercontrol
        private void LoadDataFromDBBaseCategory(CategoryModel category) {
            this.Cursor = Cursors.WaitCursor;
            productGroupPresenter.DisplayBaseCategory(category.Id);
            BindingProductGroup(category.ProductGroups);

            // Load Product Data Grid View theo Product Group dau tien trong list
            productPresenter.Display(currentProductGroup.Id);
            BindingProduct(currentProductGroup.ListProducts);
            this.Cursor = Cursors.Default;
        }

        private void LoadDataFromDBBaseSupplier(SupplierModel supplier) {
            this.Cursor = Cursors.WaitCursor;
            productGroupPresenter.DisplayBaseSupplier(supplier.Id);
            BindingProductGroup(supplier.ProductGroups);

            // Load Product Data Grid View theo Product Group dau tien trong list
            productPresenter.Display(currentProductGroup.Id);
            BindingProduct(currentProductGroup.ListProducts);
            this.Cursor = Cursors.Default;
        }
        #endregion

        #region Su kien click vao cell cua Data Grod View Product Group 
        private void dgvProductGroup_CellClick(object sender, DataGridViewCellEventArgs e) {
            int index = dgvProductGroup.SelectedCells[0].RowIndex;
            var productGroup = dgvProductGroup.Rows[index].Tag as ProductGroupModel;

            if (productGroup != null) {
                currentProductGroup = productGroup;

                this.Cursor = Cursors.WaitCursor;
                productPresenter.Display(productGroup.Id);
                BindingProduct(productGroup.ListProducts);
                this.Cursor = Cursors.Default;
            }
        }
        #endregion

        #region Su kien double clik vao Data Grid View Product
        private void dgvProduct_CellDoubleClick(object sender, DataGridViewCellEventArgs e) {
            int index = dgvProduct.SelectedCells[0].RowIndex;
            var product = dgvProduct.Rows[index].Tag as ProductModel;

            using (frmAddEditProduct frmProductDetail = new frmAddEditProduct() { ProductSelected = product, Categories = listCategories, CurrentCategoryId = currentCategory.Id }) {
                frmProductDetail.ShowDialog();

                if (currentCategory != null) {
                    LoadDataFromDBBaseCategory(currentCategory);
                }
            }
        }
        #endregion

        private void btnAddProduct_Click(object sender, EventArgs e) {
            using (frmAddEditProduct frmProductDetail = new frmAddEditProduct() { Categories = listCategories, CurrentCategoryId = currentCategory.Id }) {
                frmProductDetail.ShowDialog();

                LoadDataFromDBBaseCategory(currentCategory);
            }
        }

        private void btnDeleteProduct_Click(object sender, EventArgs e) {
            using (frmDelete formDeleteProduct = new frmDelete() { Type = "Product" }) {
                formDeleteProduct.ShowDialog();

                StartUp();
            }
        }

        private void dgvProductGroup_CellDoubleClick(object sender, DataGridViewCellEventArgs e) {
            int index = dgvProductGroup.SelectedCells[0].RowIndex;
            var productGroup = dgvProductGroup.Rows[index].Tag as ProductGroupModel;

            if (productGroup != null) {

            }
        }

        private void btnDeleteProductGroup_Click(object sender, EventArgs e) {
            using (frmDelete formDeleteProduct = new frmDelete() { Type = "Product Group" }) {
                formDeleteProduct.ShowDialog();

                StartUp();
            }
        }

        private void btnDeleteCategory_Click(object sender, EventArgs e) {
            using (frmDelete formDeleteProduct = new frmDelete() { Type = "Category" }) {
                formDeleteProduct.ShowDialog();

                StartUp();
            }
        }

        private void treeViewSupplier_AfterSelect(object sender, TreeViewEventArgs e) {
            treeViewSupplier.SelectedImageIndex = treeViewSupplier.SelectedNode.ImageIndex;
            var supplier = treeViewSupplier.SelectedNode.Tag as SupplierModel;
            if (supplier != null) {
                currentSupplier = supplier;
                LoadDataFromDBBaseSupplier(currentSupplier);
            }
        }
    }
}
