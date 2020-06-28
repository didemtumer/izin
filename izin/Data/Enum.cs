using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace izin.Data
{
    public class Enum
    {
        public enum RolEnum
        {
            [Description("Hepsi")]
            Hepsi = 1,
            [Description("Admin")]
            Admin = 2,
            [Description("Yonetici")]
            [Display(Name = "Yönetici")]
            Yonetici = 3,
            [Description("Personel")]
            Personel = 4,

        }
    }
}