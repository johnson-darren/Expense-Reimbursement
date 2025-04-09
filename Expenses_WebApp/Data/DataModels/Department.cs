using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Expenses_WebApp.Data.DataModels
{
    [Table("Departments", Schema = "public")]
    public class Department
    {
        
        [Key]
        public int Department_ID { get; set; }
        public string? Department_Name { get; set; }
    }
}
