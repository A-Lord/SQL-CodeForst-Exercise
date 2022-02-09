

namespace Store.Models
{
    public class Mentor

    {
        public int ID { get; set; }
        public virtual Staff staff { get; set; }
        public DateTime MentorEnd { get; set; }
    }
}
