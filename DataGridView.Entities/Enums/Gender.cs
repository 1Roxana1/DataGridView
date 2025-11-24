using System.ComponentModel.DataAnnotations;

namespace DataGridViewProject.Entities.Enums
{
    /// <summary>
    /// Пол
    /// </summary>
    public enum Gender
    {
        /// <summary>
        /// Мужской
        /// </summary>
        [Display(Name = "Мужской")]
        Male,

        /// <summary>
        /// Женский
        /// </summary>
        [Display(Name = "Женский")]
        Female,
    }
}
