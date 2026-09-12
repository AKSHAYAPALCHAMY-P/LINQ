using LinqUtils.Common;

namespace LinqUtils.Models
{
    public class Manager : Employee
    {
        //public Manager()
        //{
        //}                

        public Manager(int id, string name,     string emailAddress, DateOnly dateOfJoining, Team team)
            : base(id, name, emailAddress, dateOfJoining, team)
        {
        }
    }
}
