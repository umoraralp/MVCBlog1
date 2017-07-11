﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MvcBlog1.Areas.Admin.Models.DTO
{
    public class LoginModel
    {
        [Required(ErrorMessage="Lütfen email adresini doldurunuz.")]
        [EmailAddress(ErrorMessage="Düzgün bir eail adresi giriniz.")]
        public string Email { get; set; }

        [Required(ErrorMessage="Lütfen parola kısmını doldurunuz.")]
        public string Password { get; set; }
    }
}