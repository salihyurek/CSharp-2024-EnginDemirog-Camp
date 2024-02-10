using System;
using Business.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class PttManager : ISupplierService
    {

        private IApplicentService _applicentService;

        public PttManager(IApplicentService applicentService) // Constructor // new yapıldğında çalışır // oluşturucu, yapıcı
        {
            _applicentService = applicentService;
        }
        
        public void GiveMask(Person person)
        {
            if (_applicentService.CheckPerson(person))
            {
                Console.WriteLine(person.FirstName + " için maske verildi.");
            }
            else
            {
                Console.WriteLine(person.FirstName + " için maske verilemedi.");
            }
        }
    }
}