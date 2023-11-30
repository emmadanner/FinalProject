namespace ProductWebMVC.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string bd { get; set; }
        public string name { get; set; }

        public string program { get; set; }

        public string year { get; set; }
        public string GetText()
        {
            return $"{Id} \t {year} \t {name} \t {program} \t {bd} ";
        }
    }
}
