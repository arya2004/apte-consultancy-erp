using Microsoft.AspNetCore.Identity;

namespace ApteConsultancyWEB.Models
{
    public class Architect
    {
        public string EmployeeCode { get; set; }
        public string EmployeeName { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set;}
        public string AddressLine3 { get; set;}
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public int PostalCode { get; set; }
        public string ContactPerson1 { get; set; }
        public string Relation1 { get; set; }
        public int MobileNumber1 { get; set; }
        public string ContactPerson2 { get; set; }
        public string Relation2 { get; set; }
        public int MobileNumber2 { get; set; }


    }
}
