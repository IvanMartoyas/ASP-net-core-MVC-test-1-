using System.ComponentModel.DataAnnotations;

namespace test_1.Domains
{
    public class Article
    {
        [Required]
        public Guid Id { get; set; }

        [Required]
        [Display(Name = "Название страници")]
        public string Title { get; set; }

        [Display(Name = "Содержание страници")]
        public string Text { get; set; }
    }
}
