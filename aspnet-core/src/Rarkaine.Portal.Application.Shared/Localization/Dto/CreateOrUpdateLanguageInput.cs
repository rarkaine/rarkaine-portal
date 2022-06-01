using System.ComponentModel.DataAnnotations;

namespace Rarkaine.Portal.Localization.Dto
{
    public class CreateOrUpdateLanguageInput
    {
        [Required]
        public ApplicationLanguageEditDto Language { get; set; }
    }
}