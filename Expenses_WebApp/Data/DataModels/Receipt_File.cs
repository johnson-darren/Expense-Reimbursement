using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Expenses_WebApp.Data.DataModels
{
    [Table("Receipt_Files", Schema = "public")]
    public class Receipt_File
    {
        [Key]
        public int Receipt_File_ID { get; set; }
        public string File_Name { get; set; }
        public byte[] File_Data { get; set; }
        public DateTime Uploaded_At { get; set; }
    }
}
