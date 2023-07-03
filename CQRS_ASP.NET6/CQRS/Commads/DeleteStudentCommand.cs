namespace CQRS_ASP.NETCore6.CQRS.Commads
{
    public class DeleteStudentCommand
    {
        public int Id { get; set; }

        public DeleteStudentCommand(int ıd)
        {
            Id = ıd;
        }
    }
}
