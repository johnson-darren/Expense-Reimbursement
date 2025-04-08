using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Expenses_WebApp.Data.DataModels
{
    [Table("Users", Schema = "public")]
    public class User
    {
        [Key]
        public int User_ID { get; set; }
        public string First_Name { get; set; }
        public string Last_Name { get; set; }
        public string Email { get; set; }

        public int Department_ID { get; set; }
        public Department Department { get; set; }

        public int Role_ID { get; set; }
        public Role Role { get; set; }
    }
}
