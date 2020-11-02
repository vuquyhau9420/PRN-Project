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

        public ucProductMainFrm() {
            InitializeComponent();

            categoryPresenter = new CategoryPresenter(this);
            productGroupPresenter = new ProductGroupPresenter(this);
        }
        public int CategoryId { get; set; }

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
            Console.WriteLine(productGroups == null);
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

        private TreeNode AddCategoryToTree(CategoryModel category) {
            var node = new TreeNode();
            node.Text = category.Name;
            node.Tag = category;
            this.treeViewCategory.Nodes[0].Nodes.Add(node);

            return node;
        }

        private void treeViewCategory_AfterSelect(object sender, TreeViewEventArgs e) {
            Console.WriteLine("hello");
            var category = treeViewCategory.SelectedNode.Tag as CategoryModel;
            Console.WriteLine(category == null);
            if (category != null) {
                Console.WriteLine("alo");
                if (category.ProductGroups != null) {
                    if (category.ProductGroups.Count > 0) {
                        Console.WriteLine("Binding");
                        BindingProductGroup(category.ProductGroups);
                    }
                }
                else {
                    Console.WriteLine("pause");
                    this.Cursor = Cursors.WaitCursor;
                    productGroupPresenter.Display(category.Id);
                    BindingProductGroup(category.ProductGroups);

                    this.Cursor = Cursors.Default;
                }

            }
        }
    }
}
