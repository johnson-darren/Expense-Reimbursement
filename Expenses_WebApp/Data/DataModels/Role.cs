using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Expenses_WebApp.Data.DataModels
{
    [Table("Roles", Schema = "public")]
    public class Role
    {
        [Key]
        public int Role_ID { get; set; }
        public string Role_Name { get; set; }
        public string Role_Description { get; set; }
    }
}
