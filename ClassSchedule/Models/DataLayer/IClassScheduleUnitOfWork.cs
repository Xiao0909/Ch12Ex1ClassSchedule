using System.Collections.Generic;

namespace ClassSchedule.Models
{
    public interface IClassScheduleUnitOfWork<T> where T : class
    {
        public Repository<Class> Classes { get;}
        public Repository<Teacher> Teachers { get;  }
        public Repository<Day> Days { get;}

        public void Save();
    }
}
