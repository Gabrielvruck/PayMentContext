using Domain.Entities;
using System.Linq.Expressions;

namespace Domain.Queries
{
    public class StudentQueries
    {
        public static Expression<Func<Student, bool>> GetStudentInfo(string document)
        {
            return x => x.Document.Number.Equals(document);
        }
    }
}
