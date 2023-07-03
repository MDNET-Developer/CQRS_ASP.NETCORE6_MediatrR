using CQRS_ASP.NETCore6.CQRS.Commads;
using CQRS_ASP.NETCore6.Data;

namespace CQRS_ASP.NETCore6.CQRS.Handlers
{
    public class DeleteStudentCommandHandler
    {
        private readonly StudentContext _context;

        public DeleteStudentCommandHandler(StudentContext context)
        {
            _context = context;
        }

        public async Task HandlerAsync(DeleteStudentCommand command)
        {
            var id = await _context.Set<Student>().FindAsync(command.Id);
            _context.Set<Student>().Remove(id);
            await _context.SaveChangesAsync();
        }
    }
}
