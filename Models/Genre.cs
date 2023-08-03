using System.ComponentModel.DataAnnotations;

namespace SampleQuestionApp.Models
{
    public class Genre
    {
        public int Id { get; set; }

        [Display(Name ="教科")]
        [MaxLength(10)]
        public string Name { get; set; } = string.Empty;
    }
}
