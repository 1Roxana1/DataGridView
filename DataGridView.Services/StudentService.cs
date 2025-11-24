using DataGridViewProject.Entities;
using DataGridViewProject.Services.Contracts;

namespace DataGridViewProject.Services
{
    /// <summary>
    /// Сервис для работы со студентами
    /// </summary>
    public class StudentService : IStudentService
    {
        private readonly List<Student> students;

        /// <summary>
        /// Инициализировать новый экземпляр <see cref="StudentService"/>
        /// </summary>
        public StudentService()
        {
            students = [];
        }

        Task IStudentService.AddAsync(Student student, CancellationToken token)
        {
            students.Add(student);
            return Task.CompletedTask;
        }

        Task IStudentService.DeleteAsync(Guid id, CancellationToken token)
        {
            var found = students.FirstOrDefault(x => x.Id == id);
            if (found != null)
            {
                students.Remove(found);
            }
            return Task.CompletedTask;
        }

        Task<ICollection<Student>> IStudentService.GetAllAsync(CancellationToken token)
            => Task.FromResult<ICollection<Student>>(students);

        Task<Student?> IStudentService.GetByIdAsync(Guid id, CancellationToken token)
            => Task.FromResult(students.FirstOrDefault(x => x.Id == id));

        Task IStudentService.UpdateAsync(Student student, CancellationToken token)
        {
            var found = students.FirstOrDefault(x => x.Id == student.Id);
            if (found != null)
            {
                found.FullName = student.FullName;
                found.Gender = student.Gender;
                found.FormEducation = student.FormEducation;
                found.BirthDate = student.BirthDate;
                found.MathScore = student.MathScore;
                found.RussianScore = student.RussianScore;
                found.InformaticsScore = student.InformaticsScore;
            }
            return Task.CompletedTask;
        }

        Task<StudentStatistics> IStudentService.GetStatisticsAsync(CancellationToken token)
            => Task.FromResult(new StudentStatistics
                {
                    StudentCount = students.Count,
                    ExcellentStudentCount = students.Count(x => x.InformaticsScore + x.MathScore + x.RussianScore > 150),
                });
    }
}
