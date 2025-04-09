using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Expenses_WebApp.Data.DataModels
{
    [Table("Receipts", Schema = "public")]
    public class Receipt
    {
        [Key]
        public int Receipt_ID { get; set; }
        
        public int User_ID { get; set; }
        [ForeignKey("User_ID")]
        public User? User { get; set; }

        public float Amount { get; set; }
        public DateTime? Date_Purchased { get; set; }
        public string? Description { get; set; }
        
        public int Status_ID { get; set; }
        [ForeignKey("Status_ID")]
        public Status? Status { get; set; }

        public int Receipt_File_ID { get; set; }
        [ForeignKey("Receipt_File_ID")]
        public Receipt_File? Receipt_File { get; set; }

        public DateTime Submitted_At { get; set; }
        public int Checked_By { get; set; }
        public DateTime Checked_At { get; set; }
    }
}
