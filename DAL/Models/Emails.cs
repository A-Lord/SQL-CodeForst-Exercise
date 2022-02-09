

namespace Store.Models
{
    public class Emails
    {
        
        public int EmailId { get; set; }
        public string Email { get; set; }

        public int StaffId { get; set; }
        public virtual Staff Staff { get; set; }

    }
}
