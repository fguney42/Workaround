﻿using Business.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class ForeignerManager : IApplicantService
    {
        public void ApplyForMask(Person person)
        {
            throw new NotImplementedException();
        }

        public bool CheckPerson(Person person)
        {
            
            return true;
        }

        public bool CheckPerson()
        {
            throw new NotImplementedException();
        }

        public List<Person> GetList()
        {
            return null;
        }
    }
}
