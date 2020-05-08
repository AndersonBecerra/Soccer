using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Soccer.Web.Data.Entities
{
    public class TeamEntity
    {
        public int Id { get; set; }

        [MaxLength(100, ErrorMessage = "The {0} field can not have more than {1} characters.")]
        [Required(ErrorMessage = "The field {0} is mandatory.")]
        public string Name { get; set; }

        [Display(Name = "Logo")]
        public string LogoPath { get; set; }
        public string LogoFullPath => string.IsNullOrEmpty(LogoPath)
            ? "https://soccerwebandzerotox.azurewebsites.net//images/noimage.png"
            : $"https://soccerwebandzerotox.azurewebsites.net{LogoPath.Substring(1)}";


        public ICollection<GroupDetailEntity> GroupDetails { get; set; }

        public ICollection<UserEntity> Users { get; set; }
    }
}
