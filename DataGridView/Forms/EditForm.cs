using DataGridViewProject.Infrastructure;
using System.ComponentModel.DataAnnotations;
using DataGridViewProject.Entities;
using DataGridViewProject.Entities.Enums;

namespace DataGridViewProject.Forms
{
    /// <summary>
    /// Форма редактирования студентов
    /// </summary>
    public partial class EditForm : Form
    {
        /// <summary>
        /// Текущий студент
        /// </summary>
        public Student Student { get; private set; }

        /// <summary>
        /// Инициализировать новый экземпляр <see cref="EditForm"/>
        /// </summary>
        public EditForm(Student? student = null)
        {
            InitializeComponent();
            birthdayDateTimePicker.MinDate = DateTime.Today - TimeSpan.FromDays(365 * 40);
            
            Student = new Student
            {
                FullName= string.Empty,
                Gender=Gender.Male,
                BirthDate= DateTime.Today,
                FormEducation = FormEducation.Correspondence,
                MathScore=0,
                RussianScore=0,
                InformaticsScore=0
            };
            if (student != null)
            {
                Student = new Student
                {
                    Id = student.Id,
                    FullName = student.FullName,
                    Gender = student.Gender,
                    BirthDate = student.BirthDate,
                    FormEducation = student.FormEducation,
                    MathScore = student.MathScore,
                    RussianScore = student.RussianScore,
                    InformaticsScore = student.InformaticsScore
                };
                Text = "Редактирование студента";
                buttonSave.Text = "Сохранить";
            }
            InitBindings();
        }

        private void InitBindings()
        {
            comboBoxFormEducation.DataSource = Enum.GetValues(typeof(FormEducation))
                    .Cast<FormEducation>()
                    .Select(g => new { Value = g, Name = g.GetDisplayName() })
                    .ToArray();
            comboBoxFormEducation.DisplayMember = "Name";
            comboBoxFormEducation.ValueMember = "Value";

            comboBoxGender.DataSource = Enum.GetValues(typeof(Gender))
                    .Cast<Gender>()
                    .Select(g => new { Value = g, Name = g.GetDisplayName() })
                    .ToArray();
            comboBoxGender.DisplayMember = "Name";
            comboBoxGender.ValueMember = "Value";

            textBoxFullName.AddBinding(x => x.Text, Student, x => x.FullName, errorProvider);
            comboBoxGender.AddBinding(x => x.Text, Student, x => x.Gender, errorProvider);
            comboBoxFormEducation.AddBinding(x => x.Text, Student, x => x.FormEducation, errorProvider);
            birthdayDateTimePicker.AddBinding(x => x.Text, Student, x => x.BirthDate, errorProvider);
            numericUpDownMath.AddBinding(x => x.Value, Student, x => x.MathScore, errorProvider);
            numericUpDownRussian.AddBinding(x => x.Value, Student, x => x.RussianScore, errorProvider);
            numericUpDownInformatics.AddBinding(x => x.Value, Student, x => x.InformaticsScore, errorProvider);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            errorProvider.Clear();

            var context = new ValidationContext(Student);
            var results = new List<ValidationResult>();

            var valid = Validator.TryValidateObject(Student, context, results, true);
            if (!valid)
            {
                foreach (var result in results)
                {
                    foreach (var member in result.MemberNames)
                    {
                        var control = Controls.Cast<Control>()
                            .FirstOrDefault(c => c.DataBindings.Cast<Binding>()
                                .Any(b => b.BindingMemberInfo.BindingField == member));

                        if (control != null)
                        {
                            errorProvider.SetError(control, result.ErrorMessage);
                            break;
                        }
                    }
                }
                return;
            }
            DialogResult = DialogResult.OK;
        }
    }
}
