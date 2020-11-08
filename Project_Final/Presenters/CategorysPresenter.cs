﻿using Project_Final.Model.Models;
using Project_Final.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Final.Presenters {
    class CategorysPresenter : Presenter<ICategoryView> {

        public CategorysPresenter(ICategoryView view) : base(view) {

        }

        public void Display() {
            View.Categories = Model.GetAllCategories();
        }
    }
}
