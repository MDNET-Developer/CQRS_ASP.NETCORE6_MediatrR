using CQRS_ASP.NETCore6.CQRS.Queries;
using CQRS_ASP.NETCore6.CQRS.Results;
using CQRS_ASP.NETCore6.Data;
using MediatR;
using Microsoft.EntityFrameworkCore;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace CQRS_ASP.NETCore6.CQRS.Handlers
{
    public class GetStudentByIdQueryHandler : IRequestHandler<GetStudentByIdQuery, GetStudentByIdQueryResult>
    {
        private readonly StudentContext _studentContext;
        private readonly DbSet<Student> _setContext;

        public GetStudentByIdQueryHandler(StudentContext studentContext)
        {
            _studentContext = studentContext;
            _setContext = _studentContext.Set<Student>();
        }

        public async Task<GetStudentByIdQueryResult> Handle(GetStudentByIdQuery request, CancellationToken cancellationToken)
        {
            var data = await _setContext.FindAsync(request.Id);
            GetStudentByIdQueryResult getStudent = new()
            {
                Age = data.Age,
                Degree = data.Degree,
                Name = data.Name,
                Surname = data.Surname,
                University = data.University
            };
            return getStudent;
        }

        //public async Task<GetStudentByIdQueryResult> HandlerAsync(GetStudentByIdQuery query)
        //{
        //    var data = await _setContext.FindAsync(query.Id);
        //    GetStudentByIdQueryResult getStudent = new()
        //    {
        //        Age = data.Age,
        //        Degree = data.Degree,
        //        Name = data.Name,
        //        Surname = data.Surname,
        //        University = data.University
        //    };
        //    return getStudent;
        //}
    }
}
