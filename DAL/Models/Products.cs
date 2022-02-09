using System;
using System.Collections.Generic;



namespace Store.Models
{
    public class Products
    {

        public int ArticleNumber { get; set; } 

        public string Name { get; set; }

        public int Price { get; set; }

        public int stock { get; set; }

        public DateTime ExpDate { get; set; }

        public int StaffId { get; set; }

        public virtual Staff StaffInventory { get; set; }

        public DateTime Inventory { get; set; }

        public virtual ICollection<ContentLists>? Contents { get; set; }
        public virtual ICollection<Departments>? Departments { get; set; }

        public virtual Campaigns? Campaigns { get; set; }
       

        




    }
}
