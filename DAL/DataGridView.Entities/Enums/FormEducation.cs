using System.ComponentModel.DataAnnotations;

namespace DataGridViewProject.Entities.Enums
{
    /// <summary>
    /// Форма обучения
    /// </summary>
    public enum FormEducation
    {
        /// <summary>
        /// Очная
        /// </summary>
        [Display(Name = "Очная")]
        FullTime,

        /// <summary>
        /// Заочная
        /// </summary>
        [Display(Name = "Заочная")]
        Correspondence,
    }
}
