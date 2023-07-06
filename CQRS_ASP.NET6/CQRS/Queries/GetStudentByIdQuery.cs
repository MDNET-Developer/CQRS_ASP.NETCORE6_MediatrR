using CQRS_ASP.NETCore6.CQRS.Results;
using MediatR;

namespace CQRS_ASP.NETCore6.CQRS.Queries
{
    public class GetStudentByIdQuery:IRequest<GetStudentByIdQueryResult>
    {
        public int Id { get; set; }

        public GetStudentByIdQuery(int ıd)
        {
            Id = ıd;
        }
    }
}
