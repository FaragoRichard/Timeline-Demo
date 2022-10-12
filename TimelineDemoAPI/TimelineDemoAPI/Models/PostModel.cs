using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TimelineDemoAPI.Models
{
    public class PostModel
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey("User")]
        public int UserRefId { get; set; }
        public UserModel? User { get; set; }

        public string? Text { get; set; }


    }
}
