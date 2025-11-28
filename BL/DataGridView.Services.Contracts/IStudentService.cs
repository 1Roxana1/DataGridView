using DataGridViewProject.Entities;

namespace DataGridViewProject.Services.Contracts;

/// <summary>
/// Хранилище
/// </summary>
public interface IStudentService
{
    /// <summary>
    /// Добавление студента
    /// </summary>
    Task AddAsync(Student student, CancellationToken token);

    /// <summary>
    /// Удаление студента
    /// </summary>
    Task DeleteAsync(Guid id, CancellationToken token);

    /// <summary>
    /// Получение всех студентов
    /// </summary>
    Task<ICollection<Student>> GetAllAsync(CancellationToken token);

    /// <summary>
    /// Получить студента по id
    /// </summary>
    Task<Student?> GetByIdAsync(Guid id, CancellationToken token);

    /// <summary>
    /// Обновление записи студента
    /// </summary>
    Task UpdateAsync(Student student, CancellationToken token);

    /// <summary>
    /// Получение статистики студента
    /// </summary>
    Task<StudentStatistics> GetStatisticsAsync(CancellationToken token);
}