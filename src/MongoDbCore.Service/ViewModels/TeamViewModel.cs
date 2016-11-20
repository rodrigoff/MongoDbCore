using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MongoDbCore.Service.ViewModels
{
    public class TeamViewModel
    {
        [Required, StringLength(200)]
        public string Name { get; set; }

        public ICollection<TeamMemberViewModel> TeamMembers { get; set; }
    }
}
