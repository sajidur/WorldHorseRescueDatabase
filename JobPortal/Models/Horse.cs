using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JobPortal.Models
{
    public class Horse
    {
        public int Id { get; set; }
        public string HorseName { get; set; }
        public string RegistrationNumber { get; set; }

        public string Color { get; set; }
        public string Gender { get; set; }
        public string RegistrationAssociation { get; set; }
        public string RegistrationAssociationNumber { get; set; }
        public string Sire { get; set; }
        public string SireRegistrationAssociation { get; set; }
        public string SireRegistrationNumber { get; set; }
        public string Dam { get; set; }
        public string DamAssociation { get; set; }
        public string DamNumber { get; set; }
        public string Email { get; set; }
        public string MembershipType { get; set; }
        public string MembershipStatus { get; set; }
        //public virtual List<Member> Members { get; set; }
        public virtual Member Member{ get; set; }
    }
}
