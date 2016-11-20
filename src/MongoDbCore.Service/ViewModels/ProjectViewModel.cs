using System.ComponentModel.DataAnnotations;

namespace MongoDbCore.Service.ViewModels
{
    public class ProjectViewModel
    {
        [Required, StringLength(200)]
        public string Name { get; set; }
    }
}
