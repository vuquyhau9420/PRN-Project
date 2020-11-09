using Project_Final.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Final.Presenters {
    class CategoryPresenter : Presenter<ICategoryView> {

        public CategoryPresenter(ICategoryView view) : base(view) {

        }

        public bool Insert() {
            string name = View.CategoryName;
            bool status = View.Status;
            return Model.AddCategory(name, status);
        }

        public bool CheckCategoryName() {
            string name = View.CategoryName;
            return Model.CheckCategoryName(name);
        }

        public bool Delete() {
            int id = View.CategoryId;
            return Model.DeleteCategory(id);
        }

        public bool Update() {
            int id = View.CategoryId;
            bool status = View.Status;
            return Model.UpdateCategory(id, status);
        }
    }
}
