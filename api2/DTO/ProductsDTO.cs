namespace API.DTO
{
    public class ProductsDTO
    {
        private string _name;
        public string Name
        {
            get { return _name; }
            set
            {
                if (value.Length == 0)
                {
                    throw new Exception("Products name is required");
                }
                _name = value;
            }
        }

        public int Stock { get; set; }

        public string Status { get; set; }


       



    }
}
