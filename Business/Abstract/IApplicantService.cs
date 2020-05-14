using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IApplicantService
    {
        void ApplyForMask(Person person);
        List<Person> Getlist();
        bool CheckPerson(Person person);

    }
}

