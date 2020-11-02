using BusinessObject;
using DataObjects;
using DataObjects.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActionService {
    public class Service : IService {

        static readonly IStaffDao staffDao = new StaffDao();
        static readonly ICategoryDao categoryDao = new CategoryDao();

        // Login
        public Staff CheckLogin(string username, string password) {
            return staffDao.CheckLogin(username, password);
        }

        public List<Category> GetCategories() {
            return categoryDao.GetCategories();
        }
    }
}
