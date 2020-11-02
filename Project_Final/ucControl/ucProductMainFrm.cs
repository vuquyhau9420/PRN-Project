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
    public partial class ucProductMainFrm : UserControl, ICategoryView {

        private CategoryPresenter categoryPresenter;

        public ucProductMainFrm() {
            InitializeComponent();

            categoryPresenter = new CategoryPresenter(this);
        }
        public int CategoryId { get; set; }

        private void ucProductMainFrm_Load(object sender, EventArgs e) {
            categoryPresenter.Display();
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

        private TreeNode AddCategoryToTree(CategoryModel category) {
            var node = new TreeNode();
            node.Text = category.Name;
            node.Tag = category;
            //node.ImageIndex = 1;
            //node.SelectedImageIndex = 1;
            this.treeViewCategory.Nodes[0].Nodes.Add(node);

            return node;
        }
    }
}
