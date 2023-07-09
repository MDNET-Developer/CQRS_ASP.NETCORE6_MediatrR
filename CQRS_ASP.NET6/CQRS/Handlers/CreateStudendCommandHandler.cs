using CQRS_ASP.NETCore6.CQRS.Commads;
using CQRS_ASP.NETCore6.Data;
using MediatR;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace CQRS_ASP.NETCore6.CQRS.Handlers
{
    public class CreateStudendCommandHandler : IRequestHandler<CreateStudentCommand>
    {
        private readonly StudentContext _context;

        public CreateStudendCommandHandler(StudentContext context)
        {
            _context = context;
        }

        public  async Task<Unit> Handle(CreateStudentCommand request, CancellationToken cancellationToken)
        {
            Student student = new()
            {
                Age = request.Age,
                Name = request.Name,
                Surname = request.Surname,
                Degree = request.Degree,
                University = request.University,
            };
            await _context.AddAsync(student);
            await _context.SaveChangesAsync();
            return Unit.Value;
        }

        //public async Task HandlerAsync(CreateStudentCommand command)
        //{
        //    Student student = new()
        //    {
        //        Age = command.Age,
        //        Name = command.Name,
        //        Surname = command.Surname,
        //        Degree = command.Degree,
        //        University = command.University,
        //    };
        //    await _context.AddAsync(student);
        //    await _context.SaveChangesAsync();
        //}
    }
}
