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
    public partial class ucProductMainFrm : UserControl, ICategoryView, IProductGroupView {

        private CategoryPresenter categoryPresenter;
        private ProductGroupPresenter productGroupPresenter;

        private CategoryModel currentCategory;
        private ProductGroupModel currentProductGroup;

        public ucProductMainFrm() {
            InitializeComponent();

            categoryPresenter = new CategoryPresenter(this);
            productGroupPresenter = new ProductGroupPresenter(this);
        }

        private void ucProductMainFrm_Load(object sender, EventArgs e) {
            categoryPresenter.Display();
            //productGroupPresenter.Display(1);
        }

        public IList<CategoryModel> Categories {
            set {
                var category = value;
                var root = treeViewCategory.Nodes[0];
                root.Nodes.Clear();

                foreach (var item in category) {
                    AddCategoryToTree(item);
                }
            }
        }

        public IList<ProductGroupModel> ProductGroups {
            set {
                var productGroups = value;
                var category = treeViewCategory.SelectedNode.Tag as CategoryModel;
                category.ProductGroups = productGroups;

                BindingProductGroup(productGroups);
            }
        }

        private void BindingProductGroup(IList<ProductGroupModel> productGroups) {
            if (productGroups != null) {
                dgvProductGroup.DataSource = productGroups;
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

        public IList<ProductModel> Products {
            set {
                var products = value;
                string productGroupId = dgvProductGroup.SelectedRows[0].Cells[0].Value.ToString();
                foreach (var item in currentCategory.ProductGroups) {
                    if (item.Id.Equals(productGroupId)) {
                        currentProductGroup = item;
                        item.ListProducts = products;

                        BindingProduct(products);
                    }
                }
            }
        }

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

        private TreeNode AddCategoryToTree(CategoryModel category) {
            var node = new TreeNode();
            node.Text = category.Name;
            node.Tag = category;
            this.treeViewCategory.Nodes[0].Nodes.Add(node);

            return node;
        }

        private void treeViewCategory_AfterSelect(object sender, TreeViewEventArgs e) {
            var category = treeViewCategory.SelectedNode.Tag as CategoryModel;

            if (category != null) {
                currentCategory = category;
                if (category.ProductGroups != null) {
                    if (category.ProductGroups.Count > 0) {
                        BindingProductGroup(category.ProductGroups);
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
    }
}
