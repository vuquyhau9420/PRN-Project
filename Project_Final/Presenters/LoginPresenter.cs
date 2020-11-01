using BusinessObject;
using Project_Final.Model.Models;
using Project_Final.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Final.Presenters {
    public class LoginPresenter : Presenter<ILoginView> {
        public LoginPresenter(ILoginView view) : base(view) {

        }

        public StaffModel Login() {
            string username = View.Username;
            string password = View.Password;

            return Model.Login(username, password);
        }
    }
}
