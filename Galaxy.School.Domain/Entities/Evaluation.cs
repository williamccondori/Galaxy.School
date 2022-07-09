using Galaxy.School.Domain.Entities.Shared;

namespace Galaxy.School.Domain.Entities
{
    public class Evaluation : Entity
    {
        public Guid CourseId { get; set; }
        public Guid StudentId { get; set; }
        public float Value { get; set; }

        public virtual Course Course { get; set; }
        public virtual Student Student { get; set; }

    }
}
