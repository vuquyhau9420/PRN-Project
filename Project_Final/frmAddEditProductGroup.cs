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
        public string ProductGroupName => txtGroupName.Text.Trim();
        public int Supplier { get => int.Parse(GetSupplierId().Trim()); }
        public int ProductGroupCategory { get => int.Parse(GetCategoryId().Trim()); }
        public bool IsStocking { get => chkStock.Checked; }
        public bool Status { get => chkStatus.Checked; }
        public ProductGroupModel ProductGroupSelected { get; set; }

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
            LoadSupplierCombobox();
            if (ProductGroupSelected != null) {
                cboCategory.Enabled = false;
                txtGroupID.Enabled = false;
                LoadFields();
                chkStock.Enabled = true;
            }
        }

        private void LoadCategoryCombobox() {
            foreach (var item in listCategories) {
                cboCategory.Items.Add(item.Id + " - " + item.Name);
                if (ProductGroupSelected != null) {
                    if (item.Name.Equals(ProductGroupSelected.ProductGroupCategory)) {
                        cboCategory.SelectedItem = item.Id + " - " + item.Name;
                    }
                }
            }
        }

        private void LoadSupplierCombobox() {
            foreach (var item in listSupplier) {
                cboSupplier.Items.Add(item.Id + " - " + item.Name);
                if (ProductGroupSelected != null) {
                    if (item.Name.Equals(ProductGroupSelected.SupplierName)) {
                        cboSupplier.SelectedItem = item.Id + " - " + item.Name;
                    }
                }
            }
        }

        private void LoadFields() {
            txtGroupID.Text = LoadIdField();
            txtGroupName.Text = ProductGroupSelected.Name;
            chkStock.Checked = ProductGroupSelected.IsStocking;
            chkStatus.Checked = ProductGroupSelected.Status;
        }

        private string LoadIdField() {
            string field = string.Empty;
            string id = ProductGroupSelected.Id;
            bool contain = id.Contains(lblId.Text);
            if (contain) {
                for (int i = 0; i < id.Length; i++) {
                    if (Char.IsDigit(id[i]))
                        field += id[i];
                }
            }
            return field;
        }

        private bool ValidateFields() {
            bool valid = true;
            string errors = "";

            // Check product group id
            string productGroupId = GetProductGroupId();
            if (productGroupId.Length <= lblId.Text.Length || productGroupId.Length > 10) {
                valid = false;
                errors += "Product Group ID can contain maximum 10 characters and can't be empty.";
            }

            // Check product group name
            string productGroupName = txtGroupName.Text.Trim();
            if (productGroupName.Length <= 0 || productGroupName.Length > 50) {
                valid = false;
                errors += "Product Group name can contain maximum 50 characters and can't be empty.";
            }

            if (!valid) {
                MessageBox.Show(errors, "Warning");
            }
            return valid;
        }

        private void cboCategory_SelectedIndexChanged(object sender, EventArgs e) {
            string categoryItem = cboCategory.SelectedItem.ToString();
            string categoryName = categoryItem.Split(new char[] { '-' })[1].Trim();
            if (!categoryName.Equals("")) {
                if (categoryName.Contains(" ")) {
                    lblId.Text = RemoveUnicode(categoryName[0] + GetFirstCharacter(categoryName)).ToUpper();
                }
                else {
                    lblId.Text = RemoveUnicode(categoryName).ToUpper();
                }

                txtGroupID.Enabled = true;
            }
        }

        private string GetFirstCharacter(string src) {
            string result = "";
            int index = src.IndexOf(" ");
            char firstChar = src[index + 1];
            result += firstChar;
            string subString = src.Substring(index + 1);
            if (subString.Contains(" ")) {
                GetFirstCharacter(subString);
            }
            return result;
        }

        private void btnSave_Click(object sender, EventArgs e) {
            if (ValidateFields()) {
                if (ProductGroupSelected == null) {
                    bool result = productGroupPresenter.Insert();
                    if (result) {
                        MessageBox.Show("Add Success.", "Insert Status");
                        this.Dispose();
                    }
                    else {
                        MessageBox.Show("Add Fail.", "Insert Status");
                    }
                }
                else {

                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e) {
            this.Dispose();
        }

        public string RemoveUnicode(string text) {
            string[] arr1 = new string[] { "á", "à", "ả", "ã", "ạ", "â", "ấ", "ầ", "ẩ", "ẫ", "ậ", "ă", "ắ", "ằ", "ẳ", "ẵ", "ặ",
                                            "đ",
                                            "é","è","ẻ","ẽ","ẹ","ê","ế","ề","ể","ễ","ệ",
                                            "í","ì","ỉ","ĩ","ị",
                                            "ó","ò","ỏ","õ","ọ","ô","ố","ồ","ổ","ỗ","ộ","ơ","ớ","ờ","ở","ỡ","ợ",
                                            "ú","ù","ủ","ũ","ụ","ư","ứ","ừ","ử","ữ","ự",
                                            "ý","ỳ","ỷ","ỹ","ỵ",};
            string[] arr2 = new string[] { "a", "a", "a", "a", "a", "a", "a", "a", "a", "a", "a", "a", "a", "a", "a", "a", "a",
                                            "d",
                                            "e","e","e","e","e","e","e","e","e","e","e",
                                            "i","i","i","i","i",
                                            "o","o","o","o","o","o","o","o","o","o","o","o","o","o","o","o","o",
                                            "u","u","u","u","u","u","u","u","u","u","u",
                                            "y","y","y","y","y",};
            for (int i = 0; i < arr1.Length; i++) {
                text = text.Replace(arr1[i], arr2[i]);
                text = text.Replace(arr1[i].ToUpper(), arr2[i].ToUpper());
            }
            return text;
        }

        private void txtGroupID_KeyPress(object sender, KeyPressEventArgs e) {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) {
                e.Handled = true;
            }
        }
    }
}
