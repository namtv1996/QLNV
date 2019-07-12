using System.ComponentModel.DataAnnotations;

namespace CRM.Authorization.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}
