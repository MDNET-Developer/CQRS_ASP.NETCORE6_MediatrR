namespace CQRS_ASP.NETCore6.CQRS.Queries
{
    public class GetStudentByIdQuery
    {
        public int Id { get; set; }

        public GetStudentByIdQuery(int ıd)
        {
            Id = ıd;
        }
    }
}
