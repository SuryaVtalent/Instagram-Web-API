using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace InstagramProject.Models
{
    [Table("Instachild")]
    public class Instachild
    {
        [Key]
        public int InstaId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string PhoneNumber { get; set; }
        public string UserName { get; set; }
        public string FullName { get; set; }
        [ForeignKey("Instaparent")]
        public int PId { get; set; }

        public Instaparent Instaparent { get; set; }
    }
}
