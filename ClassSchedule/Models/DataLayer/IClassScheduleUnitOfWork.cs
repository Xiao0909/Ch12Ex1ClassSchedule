using System.Collections.Generic;

namespace ClassSchedule.Models
{
    public interface IClassScheduleUnitOfWork<T> where T : class
    {
        public Repository<Class> classes { get;}
        public Repository<Teacher> teachers { get;  }
        public Repository<Day> days { get;}

        public void Save();
    }
}
