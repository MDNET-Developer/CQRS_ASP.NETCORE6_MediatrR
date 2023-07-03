using CQRS_ASP.NETCore6.CQRS.Commads;
using CQRS_ASP.NETCore6.Data;

namespace CQRS_ASP.NETCore6.CQRS.Handlers
{
    public class CreateStudendCommandHandler
    {
        private readonly StudentContext _context;

        public CreateStudendCommandHandler(StudentContext context)
        {
            _context = context;
        }

        public async Task HandlerAsync(CreateStudentCommand command)
        {
            Student student = new()
            {
                Age = command.Age,
                Name = command.Name,
                Surname = command.Surname,
                Degree = command.Degree,
                University = command.University,
            };
            await _context.AddAsync(student);
            await _context.SaveChangesAsync();
        }
    }
}
