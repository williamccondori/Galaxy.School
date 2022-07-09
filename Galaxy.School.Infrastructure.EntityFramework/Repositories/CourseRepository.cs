using Galaxy.School.Domain.Entities;
using Galaxy.School.Domain.Repositories.Shared;
using Galaxy.School.Infrastructure.EntityFramework.Contexts;
using Galaxy.School.Infrastructure.EntityFramework.Exceptions;
using Microsoft.EntityFrameworkCore;

namespace Galaxy.School.Infrastructure.EntityFramework.Repositories
{
    internal class CourseRepository : IBaseRepository<Course>
    {
        private readonly SchoolContext _context;
        public CourseRepository(SchoolContext context)
        {
            _context = context;
        }

        public IEnumerable<Course> GetAll()
        {
            return _context.Courses
                .AsNoTracking()
                .ToList();
        }

        public async Task<IEnumerable<Course>> GetAllAsync()
        {
            return await _context.Courses.ToListAsync();
        }

        public Course GetById(Guid id)
        {
            var course = _context.Courses.Find(id);
            if (course == null)
                throw new EntityNotFoundException(typeof(Course));
            return course;
        }

        public async Task<Course> GetByIdAsync(Guid id)
        {
            var course = await _context.Courses.FindAsync(id);
            if (course == null)
                throw new EntityNotFoundException(typeof(Course));
            return course;
        }
    }
}
