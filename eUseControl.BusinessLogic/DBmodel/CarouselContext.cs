using eUseControl.Domain.Entities.User;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eUseControl.BusinessLogic.DBmodel
{
    class CarouselContext : DbContext
    {
        public CarouselContext() :
            base("name=DataBase")
        {

        }

        public virtual DbSet<UDbTable> CarouselItems { get; set; }
    }
}
