using System.ComponentModel.DataAnnotations;

namespace MongoDbCore.Service.ViewModels
{
    public class UserViewModel
    {
        [Required, StringLength(50)]
        public string Username { get; set; }

        [Required, StringLength(200)]
        public string Name { get; set; }

        [Required, StringLength(200)]
        public string Email { get; set; }
    }
}
