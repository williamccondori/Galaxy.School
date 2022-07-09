using Galaxy.School.Domain.Entities.Shared;

namespace Galaxy.School.Domain.Entities;

public class Course : Entity
{
    public string Name { get; set; }
    public string Description { get; set; }
}