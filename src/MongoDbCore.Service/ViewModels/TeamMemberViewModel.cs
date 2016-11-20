using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MongoDbCore.Service.ViewModels
{
    public class TeamMemberViewModel
    {
        [Required, StringLength(200)]
        public string Name { get; set; }

        public ICollection<TeamViewModel> Teams { get; set; }
    }
}
