using System;
using System.Collections.Generic;
using Business.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class ForeignerManager : IApplicentService
    {
        public void ApplyForMask(Person person)
        {
            throw new NotImplementedException();
        }

        public List<Person> GetList()
        {
            throw new NotImplementedException();
        }

        public bool CheckPerson(Person person)
        {
            throw new System.NotImplementedException();
        }
    }
}