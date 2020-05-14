using Business.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class PttManager : ISuplierService 
    {
        //Dependency injection 
        private IApplicantService _applicantService;

        public PttManager(IApplicantService applicantService)  //constructordır. new yapıldığında çalışır.
        {
            _applicantService = applicantService;
        }

        public void GiveMask(Person person)
        {
          //  PttManager pttManager = new PttManager(new PersonManager());
            if (_applicantService.CheckPerson(person))
            {
                Console.WriteLine(person.FirstName + "için maske verildi.");
            }
            else
            {
                Console.WriteLine(person.FirstName + "için maske verilemedi.");

            }

        }
    }
}
