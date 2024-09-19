using System.ComponentModel.DataAnnotations;

namespace Resumification.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}