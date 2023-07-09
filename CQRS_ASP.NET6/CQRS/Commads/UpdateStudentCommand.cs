using MediatR;

namespace CQRS_ASP.NETCore6.CQRS.Commads
{
    public class UpdateStudentCommand:IRequest
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Surname { get; set; }
        public int Age { get; set; }
        public string? Degree { get; set; }
        public string? University { get; set; }
    }
}
