using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Shop.Models
{
    public class Order
    {
        [BindNever]
        public int Id { get; set; }
        [Display(Name = "Введите имя")]
        [StringLength(25)]
        [Required(ErrorMessage ="Длинна имени не менее 2 символов")]
        public string Name { get; set; }
        [Display(Name = "Введите фамилию")]
        public string LastName { get; set; }
        [Display(Name = "Введите адресс")]
        public string Adress { get; set; }
        [Display(Name = "Введите номер телефона")]
        [DataType(DataType.PhoneNumber)]
        public string Phone { get; set; }
        [Display(Name = "Введите email")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [BindNever]
        [ScaffoldColumn(false)]
        public DateTime orderTime{ get; set; }
        public List<OrderDetail> OrderDetails { get; set; }


    }
}
