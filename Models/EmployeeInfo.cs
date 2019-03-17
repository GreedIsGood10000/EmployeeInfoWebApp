using System.ComponentModel.DataAnnotations;

namespace EmployeeInfoWebApp.Models
{
    public enum City
    {
        [Display(Name = "Москва")]
        Moscow = 0,
        [Display(Name = "Новосибирск")]
        Novosibirsk = 1,
        [Display(Name = "Санкт Петербург")]
        SaintPetersburg = 2,
        [Display(Name = "Омск")]
        Omsk = 3
    }

    [Display(Name = "Данные о сотруднике")]
    public class EmployeeInfo
    {
        public int ID { get; set; }

        [MaxLength(255)]
        [RegularExpression(@"^[\sа-яА-Я]{1,}$", ErrorMessage = "Необходимо ввести ФИО, используя только кириллицу")]
        [Display(Name = "ФИО")]
        public string FullName { get; set; }

        [DataType(DataType.PhoneNumber)]
        [RegularExpression(@"^[+7]*[(]{1}[0-9]{3}[)]{1}[0-9]{3}[\s]{1}[0-9]{2}[\s]{1}[0-9]{2}$", ErrorMessage = "Необходимо ввести номер в формате: +7(ххх)ххх хх хх")]
        [Display(Name = "Телефон")]
        public string Phone { get; set; }

        [DataType(DataType.EmailAddress, ErrorMessage = "Введите корректный e-mail")]
        [Display(Name = "E-mail")]
        public string Email { get; set; }

        [Display(Name = "Город")]
        public City City { get; set; }
    }
}
