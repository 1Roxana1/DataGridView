namespace DataGridViewProject.Services.Contracts;

/// <summary>
/// Статистика по студентам
/// </summary>
public class StudentStatistics
{
    /// <summary>
    /// Общее количество студентов
    /// </summary>
    public int StudentCount { get; set; }
    
    /// <summary>
    /// Количество учеников, с суммой балов более 150
    /// </summary>
    public int ExcellentStudentCount { get; set; }
}