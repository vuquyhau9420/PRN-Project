using Project_Final.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Final.Presenters
{
    class StaffPresenter : Presenter<IStaffView>
    {
        public StaffPresenter(IStaffView view) : base(view)
        {

        }

        public void Display()
        {
            View.ListStaff = Model.GetAllStaff();
        }
    }
}
