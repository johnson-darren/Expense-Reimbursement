using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Expenses_WebApp.Data.DataModels
{
    [Table("Users", Schema = "public")]
    public class User
    {
        [Key]
        public int User_ID { get; set; }
        public string? First_Name { get; set; }
        public string? Last_Name { get; set; }
        public string? Email { get; set; }

        public int Department_ID { get; set; }
        [ForeignKey("Department_ID")]
        public Department? Department { get; set; }

        public int Role_ID { get; set; }
        [ForeignKey("Role_ID")]
        public Role? Role { get; set; }

        public override string ToString()
        {
            return $"{First_Name} {Last_Name}";
        }

        public override bool Equals(object? obj)
        {
            return obj is User other && this.User_ID == other.User_ID;
        }

        public override int GetHashCode()
        {
            return User_ID.GetHashCode();
        }


    }
}
