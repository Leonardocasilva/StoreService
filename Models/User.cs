using System.ComponentModel.DataAnnotations;

namespace StoreService.Models
{
    public class User
    {
        [Key]
        public int id { get; set; }
        public string nome { get; set; }
        public string email { get; set; }
        public string user_login { get; set; }
        public string user_password { get; set; }
    }
}
