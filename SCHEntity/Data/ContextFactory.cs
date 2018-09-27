using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SCHEntity.Data
{
    public class ContextFactory
    {
        private readonly static Dictionary<Type, IUnitOfWork> objContextDictionary = new Dictionary<Type, IUnitOfWork>();

        static ContextFactory()
        {
            IUnitOfWork unitofwork_School = new UnitOfWork<School>(new SchoolContext<School>());
            objContextDictionary.Add(typeof(School), unitofwork_School);

            IUnitOfWork unitofwork_AdminUser = new UnitOfWork<AdminUser>(new AdminUserContext<AdminUser>());
            objContextDictionary.Add(typeof(AdminUser), unitofwork_AdminUser);

            IUnitOfWork unitofwork_Student = new UnitOfWork<Student>(new StudentContext<Student>());
            objContextDictionary.Add(typeof(Student), unitofwork_Student);

            IUnitOfWork unitofwork_Vehicle = new UnitOfWork<Vehicle>(new VehicleContext<Vehicle>());
            objContextDictionary.Add(typeof(Vehicle), unitofwork_Vehicle);

            IUnitOfWork unitofwork_VehicleLocation = new UnitOfWork<VehicleLocation>(new VehicleLocationContext<VehicleLocation>());
            objContextDictionary.Add(typeof(VehicleLocation), unitofwork_VehicleLocation);

        }
        public static IUnitOfWork CreateContext(Type type)
        {
            return objContextDictionary[type];
        }
    }
}
