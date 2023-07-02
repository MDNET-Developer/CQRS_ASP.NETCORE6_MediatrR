namespace CQRS_ASP.NETCore6.CQRS.Results
{
    public class GetStudentByIdQueryResult
    {
        public string? Name { get; set; }
        public string? Surname { get; set; }
        public int Age { get; set; }
        public string? Degree { get; set; }
        public string? University { get; set; }
    }
}
