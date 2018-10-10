using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace OnlineShop.Areas.Admin.Models
{
    public class LoginModel
    {
        [Required(ErrorMessage = "Mời Bạn Nhập UserName")]
        public string UserName { get; set; }
        [Required(ErrorMessage = "Mời Bạn Nhập Password")]
        public string Password { get; set; }
        public bool RememberMe { get; set; }

    }
}
