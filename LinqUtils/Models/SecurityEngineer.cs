using LinqUtils.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace LinqUtils.Models
{
    public class SecurityEngineer : Employee
    {
        public SecurityTeam SecurityTeam { get; set; }

        //public SecurityEngineer()
        //{

        //}

        public SecurityEngineer(int id,string name,string emailAddress,DateOnly dateOfJoining, Team team, SecurityTeam securityTeam) :
            base(id, name, emailAddress, dateOfJoining, team)
        {

        }
    }
}