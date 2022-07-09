using Galaxy.School.Domain.Entities.Shared;

namespace Galaxy.School.Domain.Entities;

public class Student : Entity
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Address { get; set; }
    public string Gender { get; set; }
    public int Age { get; set; }
}