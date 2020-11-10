using Project_Final.Model.Models;
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

        public bool InsertStaff()
        {
            StaffModel staffModel = new StaffModel
            {
                Address = View.Address,
                BirthDay = View.BirthDay,
                CitizenIdentification = View.CitizenIdentification,
                FullName = View.FullName,
                Image = View.Images,
                Password = View.Password,
                Phone = View.Phone,
                Role = View.Role,
                Sex = View.Sex,
                Status = View.Status,
                UserName = View.UserName,
            };

            return Model.InsertStaff(staffModel);
        }
    }
}
