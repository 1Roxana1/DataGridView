using DataGridViewProject.Entities;
using DataGridViewProject.Repositories.Contracts;

namespace DataGridViewProject.Repositories;

/// <summary>
/// Хранилище студентов на памяти
/// </summary>
public class StudentStorageInMemory : IStudentStorage
{
    private readonly List<Student> students;

    /// <summary>
    /// Инициализирует новый экземпляр <see cref="StudentStorageInMemory"/>
    /// </summary>
    public StudentStorageInMemory()
    {
        students = [];
    }
    
    Task IStudentStorage.AddAsync(Student student, CancellationToken token)
    {
        students.Add(student);
        return Task.CompletedTask;
    }

    Task IStudentStorage.DeleteAsync(Guid id, CancellationToken token)
    {
        var found = students.FirstOrDefault(x => x.Id == id);
        if (found != null)
        {
            students.Remove(found);
        }
        return Task.CompletedTask;
    }

    Task<ICollection<Student>> IStudentStorage.GetAllAsync(CancellationToken token)
    {
        return Task.FromResult<ICollection<Student>>(students);
    }

    Task<Student?> IStudentStorage.GetByIdAsync(Guid id, CancellationToken token)
    {
        return Task.FromResult(students.FirstOrDefault(x => x.Id == id));
    }

    Task IStudentStorage.UpdateAsync(Student student, CancellationToken token)
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

    Task<int> IStudentStorage.GetCountAsync(CancellationToken token)
    {
        return Task.FromResult(students.Count);
    }

    Task<int> IStudentStorage.GetCountWithTotalScoreOfMoreThanAsync(int totalScore, CancellationToken token)
    {
        return Task.FromResult(students.Count(x => x.InformaticsScore + x.MathScore + x.RussianScore > totalScore));
    }
}