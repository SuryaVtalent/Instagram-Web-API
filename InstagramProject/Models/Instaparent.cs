using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace InstagramProject.Models
{
    [Table("Instaparent")]
    public class Instaparent
    {
        [Key]
        public int PId { get; set; }
        public string PName { get; set; }

        public ICollection<Instachild>Instachild {  get; set; } 
       
    }
}
