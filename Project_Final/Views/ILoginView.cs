using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Final.Views {
    public interface ILoginView : IView {
        string Username { get; }
        string Password { get; }
    }
}
