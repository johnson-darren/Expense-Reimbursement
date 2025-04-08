using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Expenses_WebApp.Data.DataModels
{
    [Table("Statuses", Schema = "public")]
    public class Status
    {
        [Key]
        public int Status_ID { get; set; }
        public string Status_Name { get; set; }
        public string Status_Description { get; set; }
    }
}
