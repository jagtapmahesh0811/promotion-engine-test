using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessRuleEngine.Models
{
    public enum MembershipType
    {
        New,
        Upgrade
    }
    public class Membership
    {
        public int Id { get; set; }
        public MembershipType MembershipType { get; set; }

        public Membership(int id, MembershipType type)
        {
            Id = id;
            MembershipType = type;
        }
    }
}
