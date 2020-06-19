using MusicShop.Domain.Entities.User;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicShop.BusinessLogic.DBModel
{
    class UserContext : DbContext
    {
        public UserContext() : base ("name=MusicShopDB")
        {

        }
        public virtual DbSet<UDbTable> Users { get; set; }
    }
}
