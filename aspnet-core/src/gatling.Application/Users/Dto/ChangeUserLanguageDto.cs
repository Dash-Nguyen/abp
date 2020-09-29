using System.ComponentModel.DataAnnotations;

namespace gatling.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}