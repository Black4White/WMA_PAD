using eUseControl.Domain.Entities.User;
using System.Data.Entity;

namespace eUseControl.BusinessLogic.DBmodel
{
    class SessionContext : DbContext
    {
        public SessionContext() :
            base("name=DataBase")
        {

        }

        public virtual DbSet<Session> Session { get; set; }
    }
}
