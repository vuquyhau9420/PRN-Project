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
    public partial class frmAddEditProductGroup : Form, IProductGroupView, ICategoryView, ISuppliersView {

        private CategorysPresenter categorysPresenter;
        private ProductGroupsPresenter productGroupsPresenter;
        private ProductGroupPresenter productGroupPresenter;
        private SuppliersPresenter suppliersPresenter;

        private List<CategoryModel> listCategories;
        private List<SupplierModel> listSupplier;

        public frmAddEditProductGroup() {
            InitializeComponent();
            categorysPresenter = new CategorysPresenter(this);
            productGroupPresenter = new ProductGroupPresenter(this);
            suppliersPresenter = new SuppliersPresenter(this);

        }

        public string Id { get => GetProductGroupId(); }
        public string SupplierName { get => GetSupplierId(); }
        public string ProductGroupCategory { get => GetCategoryId(); }
        public bool IsStocking { get => chkStock.Checked; }
        public bool Status { get => chkStatus.Checked; }

        public IList<CategoryModel> Categories {
            set {
                listCategories = (List<CategoryModel>)value;
            }
        }

        public IList<SupplierModel> Suppliers {
            set {
                listSupplier = (List<SupplierModel>)value;
            }
        }

        #region Extend method get id
        private string GetProductGroupId() {
            return lblId.Text + txtGroupID.Text;
        }

        private string GetCategoryId() {
            string categoryItem = cboCategory.SelectedItem.ToString();
            return categoryItem.Split(new char[] { '-' })[0].Trim();
        }

        private string GetSupplierId() {
            string supplierItem = cboSupplier.SelectedItem.ToString();
            return supplierItem.Split(new char[] { '-' })[0].Trim();
        }
        #endregion

        private void frmAddEditProductGroup_Load(object sender, EventArgs e) {
            categorysPresenter.Display();
            suppliersPresenter.Display();
            LoadCategoryCombobox();
        }

        private void LoadCategoryCombobox() {
            foreach (var item in listCategories) {
                cboCategory.Items.Add(item.Id + " - " + item.Name);
            }
        }

        private void LoadSupplierCombobox() {
            foreach (var item in listSupplier) {
                cboSupplier.Items.Add(item.Id + " - " + item.Name);
            }
        }

        private void cboCategory_SelectedIndexChanged(object sender, EventArgs e) {

        }
    }
}
