using System.ComponentModel.DataAnnotations;

namespace Dash-ABP.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}