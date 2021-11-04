using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorPOC.Data
{
    public class Employee
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string CountryCode { get; set; }
        public string Number { get; set; }
        public string EmailAddress { get; set; }

    }
}
