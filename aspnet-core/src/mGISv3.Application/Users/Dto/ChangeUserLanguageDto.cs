using System.ComponentModel.DataAnnotations;

namespace mGISv3.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}