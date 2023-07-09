using CQRS_ASP.NETCore6.CQRS.Commads;
using CQRS_ASP.NETCore6.Data;
using MediatR;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace CQRS_ASP.NETCore6.CQRS.Handlers
{
    public class DeleteStudentCommandHandler : IRequestHandler<DeleteStudentCommand>
    {
        private readonly StudentContext _context;

        public DeleteStudentCommandHandler(StudentContext context)
        {
            _context = context;
        }

        public async Task<Unit> Handle(DeleteStudentCommand request, CancellationToken cancellationToken)
        {
            var id = await _context.Set<Student>().FindAsync(request.Id);
            _context.Set<Student>().Remove(id);
            await _context.SaveChangesAsync();
            return Unit.Value;
        }

        //public async Task HandlerAsync(DeleteStudentCommand command)
        //{
        //    var id = await _context.Set<Student>().FindAsync(command.Id);
        //    _context.Set<Student>().Remove(id);
        //    await _context.SaveChangesAsync();
        //}
    }
}
