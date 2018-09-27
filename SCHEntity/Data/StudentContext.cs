using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SCHEntity.Data
{
    public class StudentContext<T> : BaseDBContext<T> where T : class
    {
        public StudentContext() : base()
        {

        }
        public override System.Data.Entity.DbSet<T> dbSet
        {
            get
            {
                return base.dbSet;
            }
        }
        public override void SPMemberShipType(DbModelBuilder modelBuilder)
        {
            base.SPMemberShipType(modelBuilder);
        }
    }
}
