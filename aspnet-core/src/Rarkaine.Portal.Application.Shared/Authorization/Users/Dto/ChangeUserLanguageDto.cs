using System.ComponentModel.DataAnnotations;

namespace Rarkaine.Portal.Authorization.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}
