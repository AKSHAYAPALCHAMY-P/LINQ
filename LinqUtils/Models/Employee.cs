using LinqUtils.Common;

namespace LinqUtils.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string EmailAddress {  get; set; } = string.Empty;
        public DateOnly DateOfJoining { get; set; }
        public Team Team { get; set; }

        public Employee(int id,string name,  string emailAddress,DateOnly dateOfJoining,Team team)
        {
            Id = id;
            Name = name;
            EmailAddress = emailAddress;
            DateOfJoining = dateOfJoining;
            Team = team;
        }
    }
}
