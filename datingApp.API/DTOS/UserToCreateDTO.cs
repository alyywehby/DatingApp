using System.ComponentModel.DataAnnotations;

namespace datingApp.API.DTOS
{
    public class UserToCreateDTO
    {
        [Required]
        public string UserName { get; set; }
        [Required]
        [StringLength(8,MinimumLength=4, ErrorMessage="Password must be between 8 and 4 chars")]
        public string Password { get; set; }
    }
}