
using DAL;
using Microsoft.EntityFrameworkCore;
using Store.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;




namespace Service
{
    public class StaffService
    {
        private static StaffService _instance;
        public static StaffService Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new StaffService();
                }
                return _instance;
            }
        }
        private StaffService() { }

        public Dictionary<string,bool> StaffList()
        {

           var result = new Dictionary<string, bool>();
            using (var context = new StoreContext())
            {
                var staff = context.Staffs
                    .Include(x => x.Departments);

                foreach (var item in staff)
                {
                    var sId = item.StaffId;
                    var test = item.Departments.Count;
                    var owner = false;
                    if (test > 0)
                    {
                        owner = true;
                    }
                    result.Add(item.FirstName + " " + item.LastName, owner);
                }
            }
            return result;
        }
       

    }
}
