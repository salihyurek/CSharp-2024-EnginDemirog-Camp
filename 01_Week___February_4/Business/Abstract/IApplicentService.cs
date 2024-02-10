using System.Collections.Generic;
using Entities.Concrete;

namespace Business.Abstract
{
    public interface IApplicentService
    {
        void ApplyForMask(Person person);

        List<Person> GetList();

        bool CheckPerson(Person person);

    }
}