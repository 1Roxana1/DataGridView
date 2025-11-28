namespace DataGridViewProject.Entities.Contracts;

/// <summary>
/// Константы валидации сущности
/// </summary>
public class EntityValidationConstants
{
    /// <summary>
    /// Максимальная длина ФИО
    /// </summary>
    public const int MaxLengthFullName = 100;

    /// <summary>
    /// Минимальная длина ФИО
    /// </summary>
    public const int MinLengthFullName = 5;

    /// <summary>
    /// Минимальный год поступления
    /// </summary>
    public const int MinYear = 18;
    
    /// <summary>
    /// Максимальный год поступления
    /// </summary>
    public const int MaxYear = 40;

    /// <summary>
    /// Минимальное кол-во баллов
    /// </summary>
    public const int MinScore = 0;

    /// <summary>
    /// Максимальное кол-во баллов
    /// </summary>
    public const int MaxScore = 100;
}