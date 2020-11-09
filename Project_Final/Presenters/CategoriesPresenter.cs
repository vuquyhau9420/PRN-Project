using Project_Final.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Final.Presenters {
    class CategoriesPresenter : Presenter<ICategoriesView> {

        public CategoriesPresenter(ICategoriesView view) : base(view) {

        }

        public void Display() {
            View.Categories = Model.GetAllCategories();
        }

        public void DisplayActiveCategories() {
            View.Categories = Model.GetCategoriesActive();
        }
    }
}
