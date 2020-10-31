using Project_Final.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Final.Presenters {
    public class Presenter<T> where T : Views.IView {
        protected static IModel Model { get; private set; }

        static Presenter() {
            Model = new Model.Model();
        }

        public Presenter(T view) {
            View = view;
        }

        protected T View { get; private set; }
    }
}
