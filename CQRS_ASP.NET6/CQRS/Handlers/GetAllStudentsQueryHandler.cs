using CQRS_ASP.NETCore6.CQRS.Queries;
using CQRS_ASP.NETCore6.CQRS.Results;
using CQRS_ASP.NETCore6.Data;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace CQRS_ASP.NETCore6.CQRS.Handlers
{
    public class GetAllStudentsQueryHandler : IRequestHandler<GetAllStudentsQuery, IEnumerable<GetAllStudentsQueryResults>>
    {
        private readonly StudentContext _studentContext;
        private readonly DbSet<Student> _setContext;

        public GetAllStudentsQueryHandler(StudentContext studentContext)
        {
            _studentContext = studentContext;
            _setContext = _studentContext.Set<Student>();
        }

        public async Task<IEnumerable<GetAllStudentsQueryResults>> Handle(GetAllStudentsQuery request, CancellationToken cancellationToken)
        {
            var data = await _setContext.Select(x => new GetAllStudentsQueryResults() { Age = x.Age, Name = x.Name, Surname = x.Surname }).AsNoTracking().ToListAsync();
            return data;
        }

        //public async Task<IEnumerable<GetAllStudentsQueryResults>> HandlerAsync(GetAllStudentsQuery results)
        //{
        //    var data = await _setContext.Select(x=> new GetAllStudentsQueryResults() {Age=x.Age,Name=x.Name,Surname=x.Surname}).AsNoTracking().ToListAsync();
        //    return data;
        //}
    }
}
