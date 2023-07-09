using CQRS_ASP.NETCore6.CQRS.Commads;
using CQRS_ASP.NETCore6.Data;
using MediatR;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace CQRS_ASP.NETCore6.CQRS.Handlers
{
    public class UpdateStudentCommandHandler : IRequestHandler<UpdateStudentCommand>
    {
        private readonly StudentContext _studentContext;

        public UpdateStudentCommandHandler(StudentContext studentContext)
        {
            _studentContext = studentContext;
        }

        public async Task<Unit> Handle(UpdateStudentCommand request, CancellationToken cancellationToken)
        {
            Student student = new()
            {
                Age = request.Age,
                Name = request.Name,
                Surname = request.Surname,
                Degree = request.Degree,
                University = request.University,
            };

            _studentContext.Set<Student>().Update(student);
            await _studentContext.SaveChangesAsync();
            return Unit.Value;
        }

        //public async Task HandlerAsync(UpdateStudentCommand command)
        //{
        //    Student student = new()
        //    {
        //        Age = command.Age,
        //        Name = command.Name,
        //        Surname = command.Surname,
        //        Degree = command.Degree,
        //        University = command.University,
        //    };

        //    _studentContext.Set<Student>().Update(student);
        //    await _studentContext.SaveChangesAsync();
        //}
    }
}
