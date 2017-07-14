using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using HomeWorkMVC.ValidateAttribute;

namespace HomeWorkMVC.Models.ViewModels
{
    public class LogonViewModel
    {
        [DataType(DataType.EmailAddress)]
        [RegularExpression(@"\w.+\@\w.+")]
        [NoIs("skilltree,demo,twMVC", ErrorMessage = "請使用別的名稱")]
        public string Account { set; get; }
        [StringLength(20,MinimumLength =4)]
        [Display(Name ="密碼")]
        public string Password { set; get; }
        
        public string Message { set; get; }
    }
}