using System.ComponentModel.DataAnnotations;

namespace TimelineDemoAPI.Models
{
    public class UserModel
    {
        [Key]
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Email { get; set; }
        public int PhoneNumber { get; set; }
        public int UserGroup { get; set; }

        public ICollection<PostModel> Posts { get; set; }
        public ICollection<CommentModel> Comments { get; set; }
    }
}
