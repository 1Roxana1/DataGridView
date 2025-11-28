using DataGridViewProject.Entities;
using DataGridViewProject.Repositories.Contracts;
using DataGridViewProject.Services.Contracts;

namespace DataGridViewProject.Services
{
    /// <summary>
    /// Сервис для работы со студентами
    /// </summary>
    public class StudentService : IStudentService
    {
        private readonly IStudentStorage storage;

        /// <summary>
        /// Инициализировать новый экземпляр <see cref="StudentService"/>
        /// </summary>
        public StudentService(IStudentStorage storage)
        {
            this.storage = storage;
        }

        async Task IStudentService.AddAsync(Student student, CancellationToken token)
        {
            await storage.AddAsync(student, token);
        }

        async Task IStudentService.DeleteAsync(Guid id, CancellationToken token)
        {
            await storage.DeleteAsync(id, token);
        }

        async Task<ICollection<Student>> IStudentService.GetAllAsync(CancellationToken token)
            => await storage.GetAllAsync(token);

        async Task<Student?> IStudentService.GetByIdAsync(Guid id, CancellationToken token)
            => await storage.GetByIdAsync(id, token);

        async Task IStudentService.UpdateAsync(Student student, CancellationToken token)
        {
            await storage.UpdateAsync(student, token);
        }

        async Task<StudentStatistics> IStudentService.GetStatisticsAsync(CancellationToken token)
        {
            return new StudentStatistics
            {
                StudentCount = await storage.GetCountAsync(token),
                ExcellentStudentCount = await storage.GetCountWithTotalScoreOfMoreThanAsync(150, token),
            };
        }
    }
}
