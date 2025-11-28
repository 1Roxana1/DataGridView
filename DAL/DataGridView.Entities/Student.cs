using System.ComponentModel.DataAnnotations;
using DataGridViewProject.Entities.Contracts;
using DataGridViewProject.Entities.Enums;
using DataGridViewProject.Entities.Validators;

namespace DataGridViewProject.Entities
{
    /// <summary>
    /// Модель ученика
    /// </summary>
    public class Student
    {
        /// <summary>
        /// Уникальный идентификатор
        /// </summary>
        public Guid Id { get; set; } = Guid.NewGuid();

        /// <summary>
        /// Полное имя
        /// </summary>
        [Required(ErrorMessage = "ФИО обязательно")]
        [StringLength(EntityValidationConstants.MaxLengthFullName,MinimumLength = EntityValidationConstants.MinLengthFullName)]
        public string FullName { get; set; } = string.Empty;

        /// <inheritdoc/>
        [Required(ErrorMessage = "Пол обязателен")]
        public Gender Gender { get; set; }

        /// <summary>
        /// Дата рождения
        /// </summary>
        [Required(ErrorMessage = "Дата рождения обязательна")]
        [AgeRange(EntityValidationConstants.MinYear, EntityValidationConstants.MaxYear, ErrorMessage = "Возраст должен быть от 18 до 40!")]
        public DateTime BirthDate { get; set; }


        /// <inheritdoc/>
        [Required(ErrorMessage = "Форма обучения обязательна")]
        public FormEducation FormEducation { get; set; }

        /// <summary>
        /// Баллы по математике
        /// </summary>
        [Range(EntityValidationConstants.MinScore, EntityValidationConstants.MaxScore)]
        public decimal MathScore { get; set; }

        /// <summary>
        /// Баллые по русскому языку
        /// </summary>
        [Range(EntityValidationConstants.MinScore, EntityValidationConstants.MaxScore)]
        public decimal RussianScore { get; set; }

        /// <summary>
        /// Баллы по информатике
        /// </summary>
        [Range(EntityValidationConstants.MinScore, EntityValidationConstants.MaxScore)]
        public decimal InformaticsScore { get; set; }
    }
}
