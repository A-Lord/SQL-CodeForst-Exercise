

namespace Store.Models
{
    public class Departments
    {

        public int DepartmentId
        {
            get; set;
        }
        public string Name
        {
            get; set;
        }
        public virtual ICollection<Products>? products { get; set; }
        public int StaffId
        {
            get; set;
        }
        public virtual Staff Owner { get; set; }

    }
}
