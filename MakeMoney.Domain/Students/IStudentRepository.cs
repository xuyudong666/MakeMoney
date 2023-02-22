namespace MakeMoney.Domain.Students
{
    public interface IStudentRepository
    {
        Student? GetAsync();
    }
}