using System.ComponentModel.DataAnnotations;

namespace SampleQuestionApp.Models
{
    public class Question
    {
        public int Id { get; set; }
        [Display(Name = "問題")]
        public string? Title { get; set; }
        [Display(Name ="問題文")]
        public string? Contents { get; set; }
        [Display(Name ="教科")]
        public int GenreId { get; set; }
        public virtual Genre? Genre { get; set; }
    }
}
