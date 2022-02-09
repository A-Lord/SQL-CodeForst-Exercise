
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
    public class DepartmentsService
    {
        private static DepartmentsService _instance;
        public static DepartmentsService Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new DepartmentsService();
                }
                return _instance;
            }
        }
        private DepartmentsService() { }

        public Dictionary<string, List<string>>  DepartmentsList()
        {

           var result = new Dictionary<string,List<string>>();
            using (var context = new StoreContext())
            {
                var department = context.Departments
                    .Include(x => x.Owner.Emails);


                foreach (var item in department)
                {

                    var mail =item.Owner.Emails.Select(x => x.Email).ToList();
                    result.Add(item.Name, mail);
                    

                }

            }
            return result;
        }
       

    }
}
