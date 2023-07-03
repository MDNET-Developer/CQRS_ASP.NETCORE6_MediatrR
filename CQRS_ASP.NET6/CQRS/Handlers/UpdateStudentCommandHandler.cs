using CQRS_ASP.NETCore6.CQRS.Commads;
using CQRS_ASP.NETCore6.Data;

namespace CQRS_ASP.NETCore6.CQRS.Handlers
{
    public class UpdateStudentCommandHandler
    {
        private readonly StudentContext _studentContext;

        public UpdateStudentCommandHandler(StudentContext studentContext)
        {
            _studentContext = studentContext;
        }

        public async Task HandlerAsync(UpdateStudentCommand command)
        {
            Student student = new()
            {
                Age = command.Age,
                Name = command.Name,
                Surname = command.Surname,
                Degree = command.Degree,
                University = command.University,
            };

            _studentContext.Set<Student>().Update(student);
            await _studentContext.SaveChangesAsync();
        }
    }
}
