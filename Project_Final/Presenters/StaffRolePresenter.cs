using Project_Final.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Final.Presenters
{
    class StaffRolePresenter : Presenter<IStaffRoleView>
    {
        public StaffRolePresenter(IStaffRoleView view) : base(view)
        {

        }

        public void Display()
        {
            View.GetStaffRole = Model.GetAllStaffRole();
        }
    }
}
