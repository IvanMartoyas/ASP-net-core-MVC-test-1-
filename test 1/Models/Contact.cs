using System.ComponentModel.DataAnnotations;

namespace test_1.Models
{
    public class Contact
    {
        [Display (Name="Имя")]
        [Required(ErrorMessage = "Введите имя")]
        public string Name { get; set; }

        [Display(Name = "Фамилия")]
        [Required(ErrorMessage = "Введите фамилию")]
        public string SurName { get; set; }

        [Display(Name = "Почта")]
        [Required(ErrorMessage = "Введите почту")]
        public string Mail { get; set; }

        [Display(Name = "Возраст")]
        [Required(ErrorMessage = "Введите возраст")]
        public int Age { get; set; }

        [Display(Name = "Сообщение")]
        [Required(ErrorMessage = "Введите сообщение")]
        [StringLength(30, ErrorMessage = "Количество символов дложно быть больше 30")]
        public string Massage { get; set; }

    }
}
