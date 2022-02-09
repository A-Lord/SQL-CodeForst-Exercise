

namespace Store.Models
{
    public class Staff
    {

        public int StaffId { get; set; }

        public string FirstName { get; set;}

        public string LastName { get; set; }

        public string PhoneNumber { get; set; }

        public string PersonalNumber { get; set; }

        public virtual ICollection<Emails> Emails { get; set; }

        //public Mentor? Mentor { get; set; }
        //public virtual ICollection<Mentor>? Pubils { get; set; }

        public virtual Staff? Mentor { get; set; } 

        public DateTime? MentorEndTime { get; set; }
        public virtual ICollection<Departments>? Departments { get; set; }

        public virtual ICollection<Products>? Inventory { get; set; }
    }
}
