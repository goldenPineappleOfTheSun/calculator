using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebCalc.Models
{
    public class RegistrationModel
    {
        [Display(Name = "Логин")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "!!!")]
        public string Login { get; set; }

        [Display(Name = "Пароль")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "!!!")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Display(Name = "Имя")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "!!!")]
        public string Name { get; set; }

        [Display(Name = "Дата рождения")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "!!!")]
        public DateTime BirthDay { get; set; }

    }
}