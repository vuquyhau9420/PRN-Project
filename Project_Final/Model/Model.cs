using ActionService;
using AutoMapper;
using BusinessObject;
using Project_Final.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Final.Model {
    public class Model : IModel {
        static Service service = new Service();

        static Model() {
            Mapper.CreateMap<Staff, StaffModel>();
            Mapper.CreateMap<StaffModel, Staff>();
        }

        #region Login
        public StaffModel Login(string username, string password) {
            return Mapper.Map<Staff, StaffModel>(service.CheckLogin(username, password));
        }
        #endregion
    }
}
