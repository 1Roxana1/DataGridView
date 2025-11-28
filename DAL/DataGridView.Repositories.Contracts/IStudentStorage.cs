using DataGridViewProject.Entities;

namespace DataGridViewProject.Repositories.Contracts;

/// <summary>
/// Интерфейс хранилища студентов
/// </summary>
public interface IStudentStorage
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
    /// Возвращает количество студентов
    /// </summary>
    Task<int> GetCountAsync(CancellationToken token);
    
    /// <summary>
    /// Возвращает количество студентов с суммой баллов более чем <paramref name="totalScore"/>
    /// </summary>
    /// <param name="totalScore">Сумма баллов</param>
    Task<int> GetCountWithTotalScoreOfMoreThanAsync(int totalScore, CancellationToken token);
}