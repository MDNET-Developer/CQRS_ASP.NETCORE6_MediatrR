using CQRS_ASP.NETCore6.CQRS.Results;
using MediatR;

namespace CQRS_ASP.NETCore6.CQRS.Queries
{
    public class GetAllStudentsQuery:IRequest<IEnumerable<GetAllStudentsQueryResults>>
    {
    }
}
