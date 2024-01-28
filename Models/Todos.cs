using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;

namespace TodoApplication.Models
{
    [PrimaryKey(nameof(Id))]
    public class Todos
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Task { get; set; }
        public string Category { get; set; }
        public string Status { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
