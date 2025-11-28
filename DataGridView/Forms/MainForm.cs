using DataGridViewProject.Entities;
using DataGridViewProject.Entities.Enums;
using DataGridViewProject.Infrastructure;
using DataGridViewProject.Services.Contracts;

namespace DataGridViewProject.Forms
{
    /// <summary>
    /// Главная форма
    /// </summary>
    public partial class MainForm : Form
    {
        private readonly BindingSource bindingSource;
        private readonly IStudentService studentService;

        /// <summary>
        /// Инициализировать новый экземпляр <see cref="MainForm"/>
        /// </summary>
        public MainForm(IStudentService studentService)
        {
            InitializeComponent();
            Load += MainForm_Load;
            
            bindingSource  = new();
            this.studentService = studentService;
            dataGridView.AutoGenerateColumns = false;
            ConfigureColumns();
        }

        private void ConfigureColumns()
        {
            Fio.DataPropertyName = nameof(Student.FullName);
            Fio.ReadOnly = true;
            Gender.DataPropertyName = nameof(Student.Gender);
            Gender.ReadOnly = true;
            DateOfBirth.DataPropertyName = nameof(Student.BirthDate);
            DateOfBirth.ReadOnly = true;
            Form.DataPropertyName = nameof(Student.FormEducation);
            Form.ReadOnly = true;
            ScoresMath.DataPropertyName = nameof(Student.MathScore);
            ScoresMath.ReadOnly = true;
            ScoresRussian.DataPropertyName = nameof(Student.RussianScore);
            ScoresRussian.ReadOnly = true;
            ScoreInform.DataPropertyName = nameof(Student.InformaticsScore);
            ScoreInform.ReadOnly = true;
            
            TotalScores.ReadOnly = true;
        }


        private async Task RefreshStats()
        {
            var statistics = await studentService.GetStatisticsAsync(CancellationToken.None);
            toolStripStatusLabelCount.Text = $"Всего студентов: {statistics.StudentCount}";
            toolStripStatusLabelStatusStudent.Text = $"Всего студентов с более 150 баллов: {statistics.ExcellentStudentCount}";
        }

        private async void btnAdd_Click(object sender, EventArgs e)
        {
            var form = new EditForm();
            if (form.ShowDialog() == DialogResult.OK)
            {
                await studentService.AddAsync(form.Student, CancellationToken.None);
                await OnUpdate();
            }
        }

        private async void btnEdit_Click(object sender, EventArgs e)
        {
            if (bindingSource.Current is not Student selected)
            {
                return;
            }

            var form = new EditForm(selected);
            if (form.ShowDialog() == DialogResult.OK)
            {
                await studentService.UpdateAsync(form.Student, CancellationToken.None);
                await OnUpdate();
            }
        }

        private void dataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.Value is Enum enumVal)
            {
                e.Value = enumVal.GetDisplayName();
            }

            if (dataGridView.Columns[e.ColumnIndex].Name == "TotalScores"
                && dataGridView.Rows[e.RowIndex].DataBoundItem is Student student)
            {
                e.Value = student.MathScore + student.RussianScore + student.InformaticsScore;
            }
        }

        private async void btnDelete_Click(object sender, EventArgs e)
        {
            if (bindingSource.Current is not Student selected)
            {
                return;
            }
            if (MessageBox.Show("Удалить запись?", "Подтверждение", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                await studentService.DeleteAsync(selected.Id,  CancellationToken.None);
                await OnUpdate();
            }
        }
        
        private async Task OnUpdate()
        {
            bindingSource.DataSource = await studentService.GetAllAsync(CancellationToken.None);
            bindingSource.ResetBindings(false);
            await RefreshStats();
        }

        private async void MainForm_Load(object sender, EventArgs e)
        {
            var student1 = new Student
            {
                FullName = "Иванов Иван Иванович",
                Gender = DataGridViewProject.Entities.Enums.Gender.Male,
                BirthDate = new(2006, 1, 24),
                FormEducation = FormEducation.FullTime,
                MathScore = 50,
                RussianScore = 50,
                InformaticsScore = 0
            };
            var student2 = new Student
            {
                FullName = "Алексеевич Алексей Олег",
                Gender = DataGridViewProject.Entities.Enums.Gender.Female,
                BirthDate = new(2006, 10, 21),
                FormEducation = FormEducation.Correspondence,
                MathScore = 75,
                RussianScore = 34,
                InformaticsScore = 12
            };
            await studentService.AddAsync(student1, CancellationToken.None);
            await studentService.AddAsync(student2, CancellationToken.None);
            await OnUpdate();
            dataGridView.DataSource = bindingSource;
        }
    }
}
