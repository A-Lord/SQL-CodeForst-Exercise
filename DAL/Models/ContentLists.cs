

namespace Store.Models
{
    public class ContentLists
    {

        public int ContentId { get; set; }

        public int ArticleNumber { get; set; }
        public virtual Products Product { get; set; }
        public string Content { get; set; }
    }
}
