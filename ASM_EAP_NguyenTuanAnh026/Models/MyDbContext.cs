using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.Identity.EntityFramework;

namespace ASM_EAP_NguyenTuanAnh026.Models
{
    public class MyDbContext : IdentityDbContext<Account>
    {
        public MyDbContext() : base("name=MyDbContext")
        {
        }

        public static MyDbContext Create()
        {
            return new MyDbContext();
        }

        public System.Data.Entity.DbSet<ASM_EAP_NguyenTuanAnh026.Models.Market> Markets { get; set; }

        public System.Data.Entity.DbSet<ASM_EAP_NguyenTuanAnh026.Models.Coin> Coins { get; set; }
    }
}