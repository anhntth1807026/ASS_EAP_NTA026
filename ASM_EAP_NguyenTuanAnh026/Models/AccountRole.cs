using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.Identity.EntityFramework;

namespace ASM_EAP_NguyenTuanAnh026.Models
{
    public class AccountRole : IdentityRole
    {
        public string Description { get; set; }

        public DateTime CreatedAt { get; set; }
    }
}