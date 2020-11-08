using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Project_Final.Views;
using Project_Final.Presenters;
using Project_Final.Model.Models;

namespace Project_Final.ucControl
{
    public partial class ucStaff : UserControl, IStaffView
    {

        private StaffPresenter staffPresenter;
        private List<StaffModel> listStaff;
        public ucStaff()
        {
            InitializeComponent();

            staffPresenter = new StaffPresenter(this);
        }

        public IList<StaffModel> ListStaff
        {
            set
            {
                var staffs = value;
                listStaff = (List<StaffModel>)staffs;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {

        }

        private void ucStaff_Load(object sender, EventArgs e)
        {
            staffPresenter.Display();
            dgvStaff.DataSource = listStaff;
        }
    }
}
