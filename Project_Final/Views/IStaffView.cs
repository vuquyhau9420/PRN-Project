using Project_Final.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Final.Views
{
    public interface IStaffView : IView
    {
        IList<StaffModel> ListStaff { set; }

        string UserName { get; }
        string Password { get; }
        string FullName { get; }
        string CitizenIdentification { get; }
        bool Sex { get; }
        string Phone { get; }
        string Address { get; }
        DateTime BirthDay { get; }
        string Role { get; }
        bool Status { get; }
        string Images { get; }
    }
}
