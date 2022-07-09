namespace Galaxy.School.Infrastructure.EntityFramework.Exceptions
{
    public class EntityNotFoundException : Exception
    {
        public EntityNotFoundException(Type entityType) : base(
            $"No value found for entity {entityType.Name}")
        {

        }
    }
}
