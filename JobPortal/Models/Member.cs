using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JobPortal.Models
{
    public class Member
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string MemberNumber { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string MembershipType { get; set; }
        public string MembershipStatus { get; set; }
        //public virtual Horse Horse { get; set; }
        public virtual List<Horse> Horses { get; set; }
    }
}
