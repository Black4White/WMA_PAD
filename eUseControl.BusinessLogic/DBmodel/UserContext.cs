using eUseControl.Domain.Entities.User;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eUseControl.BusinessLogic.DBmodel
{
    class UserContext : DbContext
    {
        public UserContext() :
         base("name=DataBase")
        {

        }

        public virtual DbSet<UDbTable> Users { get; set; }
    }
}
