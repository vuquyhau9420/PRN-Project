﻿using BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataObjects {
    public interface ICategoryDao {
        string GetCategoryName(string categoryId);

        List<Category> GetCategorys();
    }
}