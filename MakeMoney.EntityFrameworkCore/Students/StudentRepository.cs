using MakeMoney.Domain;
using MakeMoney.Domain.Students;
using System.Reflection;

namespace MakeMoney.EntityFrameworkCore.Students
{
    public class StudentRepository : IStudentRepository {
        public Student? GetAsync()
        {
            Student? student = default;
            var constructorInfos = typeof(Student).GetConstructors(BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.Public);
            foreach (var constructorInfo in constructorInfos) {
                var parameterInfos = constructorInfo.GetParameters();
                if(parameterInfos.Length == 0) {
                    student = (Student?)constructorInfo.Invoke(null);
                }
            }
            student?.SetName("张三");
            Console.WriteLine("MySql查询Student");
            Console.WriteLine($"student Name = {student?.Name}");
            return student;
        }
    }
}