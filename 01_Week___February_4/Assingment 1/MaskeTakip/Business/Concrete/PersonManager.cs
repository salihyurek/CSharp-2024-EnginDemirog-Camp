using System.Collections.Generic;
using Business.Abstract;
using Business.KPSPublic;
using Entities.Concrete;

namespace Business.Concrete
{
    // Çıplak class kalmasın 
    public class PersonManager: IApplicentService
    {
        // encapsulation
        public void ApplyForMask(Person person)
        {
            
        }

        public List<Person> GetList()
        {
            return null;
        }

        public bool CheckPerson(Person person)
        {
            // Mernis kontrolü
            KPSPublicSoapClient client =
                new KPSPublicSoapClient(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap);

            return client
                .TCKimlikNoDogrulaAsync(person.NationalIdentity, person.FirstName, person.LastName,
                    person.DateOfBirthYear).Result.Body.TCKimlikNoDogrulaResult;
        }
    }
}